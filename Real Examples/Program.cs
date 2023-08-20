

using Real_Examples;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;


StringBuilder result = new StringBuilder();
string input = Console.ReadLine();
bool isNumberStarted = false;

foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        result.Append(c);
        isNumberStarted = true;
    }
    else if (c == '-' && !isNumberStarted)
    {
        result.Append(c);
        isNumberStarted = true;
    }
    else
    {
        isNumberStarted = false;
    }
}

Console.WriteLine(result);
//try
//{
//    BankAccount bankAccount = new BankAccount("Ahmed", 1500);

//    Console.WriteLine($"Bank Account Number is {bankAccount.Number}");

//    bankAccount.MakeDeposit(1500, DateTime.Now, "");
//    Console.WriteLine($"your balance is {bankAccount.Balance}");
//    bankAccount.MakeWithdrawal(2500, DateTime.Now, "");
//    Console.WriteLine($"your balance is {bankAccount.Balance}");
//    bankAccount.MakeWithdrawal(2500, DateTime.Now, "");
//    Console.WriteLine($"your balance is {bankAccount.Balance}");


//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}




