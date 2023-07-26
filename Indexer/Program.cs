
ShoppingCart cart = new ShoppingCart();
cart[0] = "Item 1";
cart[1] = "Item 2";

Console.WriteLine(cart[0]); // Output: "Item 1"
Console.WriteLine(cart[1]); // Output: "Item 2"

public class ShoppingCart
{
    private string[] items = new string[5];

    // Indexer declaration
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < items.Length)
                return items[index];
            else
                throw new IndexOutOfRangeException("Invalid index.");
        }
        set
        {
            if (index >= 0 && index < items.Length)
                items[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid index.");
        }
    }
}



