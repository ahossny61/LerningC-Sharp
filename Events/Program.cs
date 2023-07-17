

var stock = new Stock("Amazon");
stock.Price= 1000m;
stock.OnPriceChanged += StockPriceChanged;
Console.WriteLine("Old Price "+stock.Price);
stock.ChangeStockPriceBy(0.05m);
Console.WriteLine("New Price "+ stock.Price);

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
