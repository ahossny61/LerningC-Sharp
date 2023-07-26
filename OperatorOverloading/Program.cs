
//Main

Money m1 = new Money(10);
Money m2 = new Money(20);

Money m3 = m1 + m2; // here we want to use Operator Overloading

Console.WriteLine(m3.Amount);

m3 = m2 - m1;
Console.WriteLine(m3.Amount);



public class Money
{
    public decimal Amount { get; private set; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator + (Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }
    public static Money operator -(Money a, Money b)
    {
        return new Money(a.Amount - b.Amount);
    }

    public static bool operator >(Money a, Money b) // we must define the two operator > and <
    {
        return a.Amount > b.Amount;
    }

    public static bool operator <(Money a, Money b)
    {
        return a.Amount < b.Amount;
    }

    // we can define >= , <= , == ,!= ,++ , --(one value) ,
}