

var stock = new Stock("Amazon");
stock.Price= 1000m;
stock.OnPriceChanged += StockPriceChanged;
Console.WriteLine("Old Price "+stock.Price);
stock.ChangeStockPriceBy(0.05m);
Console.WriteLine("New Price "+ stock.Price);


//  Example 2 

Door door = new Door();
door.DoorOpened += (sender, e) =>
{
    Console.WriteLine("Someone opened the door.");
};

door.Open();

void StockPriceChanged(Stock stock, decimal oldPrice)
{
    if(stock.Price > oldPrice)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        
    }
    else if(oldPrice > stock.Price)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine(stock.Name + " " + stock.Price);
}

public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
public class Stock
{
    private string name;
    private decimal price;

    public event StockPriceChangeHandler OnPriceChanged;
    public string Name => this.name;
    public decimal Price { get => this.price; set => this.price = value;}

    public Stock(string stockName)
    {
        this.name = stockName;
    }

    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = this.price;
        this.price = Math.Round(this.price*percent,2);
        if(OnPriceChanged != null)
        {
            OnPriceChanged(this, oldPrice);
        }
    }
}




public class Door
{
    // Define a delegate type for the event
    public delegate void DoorEventHandler(object sender, EventArgs e);

    // Declare an event of the delegate type
    public event DoorEventHandler DoorOpened;

    public void Open()
    {
        Console.WriteLine("The door is opened.");
        // Raise the event when the door is opened
        OnDoorOpened(EventArgs.Empty);
    }

    protected virtual void OnDoorOpened(EventArgs e)
    {
        DoorOpened?.Invoke(this, e);
    }
}


