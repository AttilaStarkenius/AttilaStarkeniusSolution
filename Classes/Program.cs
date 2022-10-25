using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());
            /*24.10.2022. I follow the tutorial
             in https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
            like this: "var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());"*/

            //var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            // How much is too much to borrow?
            //lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            //lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            //lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            //lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            //lineOfCredit.PerformMonthEndTransactions();
            //Console.WriteLine(lineOfCredit.GetAccountHistory());









            //Console.WriteLine("Hello World!");
            var account = new BankAccount("Attila Starkenius", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            /*24.10.2022. I add: "account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);"*/
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            /*24.10.2022. "You use the try and catch statements to mark a 
             block of code that may throw exceptions and to catch 
             those errors that you expect. You can use the same technique 
             to test the code that throws an exception for a negative balance. 
             Add the following code before the declaration of invalidAccount in your Main method:
            // Test for a negative balance.
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}"*/
            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            /*24.10.2022. "The history uses the StringBuilder class to format a string that contains 
            one line for each transaction.You've seen the string formatting code 
            earlier in these tutorials. One new character is \t. That inserts a tab 
            to format the output.
Add this line to test it in Program.cs:
            Console.WriteLine(account.GetAccountHistory());"*/

            Console.WriteLine(account.GetAccountHistory());

            /*24.10.2022. I continue
            tutorial to next step on web page: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
            like this: "Instead, you can create new bank account types that inherit methods and data 
            from the BankAccount class created in the preceding tutorial. 
            These new classes can extend the BankAccount class with the specific behavior needed for each type:
            public class InterestEarningAccount : BankAccount
{
}

public class LineOfCreditAccount : BankAccount
{
}

public class GiftCardAccount : BankAccount
{
}"*/



            /*24.10.2022. "Next, test that you're catching error conditions 
             by trying to create an account with a negative balance. 
             Add the following code after the preceding code you just added:
            // Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}"*/
            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
        }
    }
}

/*24.10.2022. I begin with tutorial https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
so I create a console application project called "Classes", set that
as the startup project and continue working here
like this: "In this tutorial, you're going to create new types that represent a bank account. Typically developers define each class in a different text file. That makes it easier to manage as a program grows in size. Create a new file named BankAccount.cs in the Classes directory.

This file will contain the definition of a bank account. Object Oriented programming organizes code by creating types in the form of classes. These classes contain the code that represents a specific entity. The BankAccount class represents a bank account. The code implements specific operations through methods and properties. In this tutorial, the bank account supports this behavior:

It has a 10-digit number that uniquely identifies the bank account.
It has a string that stores the name or names of the owners.
The balance can be retrieved.
It accepts deposits.
It accepts withdrawals.
The initial balance must be positive.
Withdrawals can't result in a negative balance."
so I create a class file called BankAccount.cs*/
