using System;
using System.Collections.Generic;
using System.Text;

//namespace Classes
//{
//    class BankAccount
//    {
//    }
//}

namespace Classes { 

public class BankAccount
{
        /*24.10.2022. "An interest earning account:
Will get a credit of 2% of the month-ending-balance.
A line of credit:
Can have a negative balance, but not be greater in absolute value than the credit limit.
Will incur an interest charge each month where the end of month balance isn't 0.
Will incur a fee on each withdrawal that goes over the credit limit.
A gift card account:
Can be refilled with a specified amount once each month, on the last day of the month.
You can see that all three of these account types have an action that takes places at 
        the end of each month. However, each account type does different tasks. 
        You use polymorphism to implement this code. Create a single virtual method 
        in the BankAccount class:
        public virtual void PerformMonthEndTransactions() { }"*/
        public virtual void PerformMonthEndTransactions() { }

        private static int accountNumberSeed = 1234567890;
        /*24.10.2022. I add in BankAccount.cs: 
        "private static int accountNumberSeed = 1234567890;" 
         */
        public string Number { get; }
    public string Owner { get; set; }
        /*24.10.2022. To get the updated Balance,
         instead of just the initial first Balance value
        that might no longer be correct, I replace "public decimal Balance { get; }"
         with: "public decimal Balance
{
    get
    {
        decimal balance = 0;
        foreach (var item in allTransactions)
        {
            balance += item.Amount;
        }

        return balance;
    }
}"
*/
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
        //public decimal Balance { get; }


        //        public BankAccount(string name, decimal initialBalance)
        //        {
        //            this.Owner = name;
        //            this.Balance = initialBalance;
        //            /*24.10.2022. In BankAccount.cs I add:
        //            "this.Number = accountNumberSeed.ToString();
        //accountNumberSeed++;"*/
        //            this.Number = accountNumberSeed.ToString();
        //            accountNumberSeed++;
        //        }

        /*24.10.2022. I change from: "public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            //24.10.2022. In BankAccount.cs I add:
            //"this.Number = accountNumberSeed.ToString();
//accountNumberSeed++;"
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }"
        to: "public BankAccount(string name, decimal initialBalance)
{
    Number = accountNumberSeed.ToString();
    accountNumberSeed++;

    Owner = name;
    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
}"
        */

        //public BankAccount(string name, decimal initialBalance)
        //{
        //    Number = accountNumberSeed.ToString();
        //    accountNumberSeed++;

        //    Owner = name;
        //    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        //}

        /*24.10.2022. "Instead, you can use constructor chaining to have one constructor call another. 
         * The following code shows the two constructors and the new additional field:
         * private readonly decimal _minimumBalance;

public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
{
    Number = s_accountNumberSeed.ToString();
    s_accountNumberSeed++;

    Owner = name;
    _minimumBalance = minimumBalance;
    if (initialBalance > 0)
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
}
        "
        so I change from: "public BankAccount(string name, decimal initialBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }"
        to: "private readonly decimal _minimumBalance;

public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
{
    Number = s_accountNumberSeed.ToString();
    s_accountNumberSeed++;

    Owner = name;
    _minimumBalance = minimumBalance;
    if (initialBalance > 0)
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
}"*/
        private readonly decimal _minimumBalance;

        private static int s_accountNumberSeed = 1234567890; 

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        /*24.10.2022. I add a list of Transaction class objects:
        private List<Transaction> allTransactions = new List<Transaction>();*/
        private List<Transaction> allTransactions = new List<Transaction>();

        /*24.10.2022. I continue to follow the instructions
         in the tutorial https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
        like this: "Let's start by creating a new type to represent a transaction. 
        The transaction is a simple type that doesn't have any responsibilities. 
        It needs a few properties. 
        Create a new file named Transaction.cs. 
        Add the following code to it:
        namespace Classes;

public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}"*/

        /*24.10.2022. I change from: "public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }"
        to: "public void MakeDeposit(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
    }
    var deposit = new Transaction(amount, date, note);
    allTransactions.Add(deposit);
}

public void MakeWithdrawal(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    if (Balance - amount < 0)
    {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    var withdrawal = new Transaction(-amount, date, note);
    allTransactions.Add(withdrawal);
}"*/
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        //public void MakeWithdrawal(decimal amount, DateTime date, string note)
        //{
        //    if (amount <= 0)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        //    }
        //    //if (Balance - amount < 0)
        //    if (Balance - amount < _minimumBalance)
        //    {
        //        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        //    }
        //    var withdrawal = new Transaction(-amount, date, note);
        //    allTransactions.Add(withdrawal);
        //}

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            /*25.10.2022. Like stated in https://bartwullems.blogspot.com/2021/04/c-9target-typed-conditional-expressions.html
             I get error because I use C#8(With .NET 3.1) I should upgrade to C#9(With .NET 5)
            Severity	Code	Description	Project	File	Line	Suppression State
Error	CS8400	Feature 'target-typed object creation' is not available in C# 8.0. Please use language version 9.0 or greater.	Classes	C:\Users\symph\source\repos\AttilaStarkeniusSolution\Classes\BankAccount.cs	258	Active
I just move on to next tutorial: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio
            like this: "Start Visual Studio and select Create a new project.
In the Create a new project dialog, select ASP.NET Core Web App (Model-View-Controller) > Next.
In the Configure your new project dialog, enter MvcMovie for Project name. It's important to name the project MvcMovie. Capitalization needs to match each namespace when code is copied.
Select Next.
In the Additional information dialog, select .NET 6.0 (Long-term support).
Select Create."
            Actually I choose .NET 3.1 because I only have Visual Studio 2019*/
            Transaction? withdrawal = new(-amount, date, note);
            _allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        /*24.10.2022. "Different overdraft rules
The last feature to add enables the LineOfCreditAccount to charge a fee for going over 
        the credit limit instead of refusing the transaction.
One technique is to define a virtual function where you implement 
        the required behavior. The BankAccount class refactors the 
        MakeWithdrawal method into two methods. The new method does 
        the specified action when the withdrawal takes the balance 
        below the minimum. The existing MakeWithdrawal method has the following code:
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    if (Balance - amount < _minimumBalance)
    {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    var withdrawal = new Transaction(-amount, date, note);
    allTransactions.Add(withdrawal);
}
        Replace it with the following code:
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
    Transaction? withdrawal = new(-amount, date, note);
    _allTransactions.Add(withdrawal);
    if (overdraftTransaction != null)
        _allTransactions.Add(overdraftTransaction);
}

protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
{
    if (isOverdrawn)
    {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    else
    {
        return default;
    }
}
" */

        /*24.10.2022. "Challenge - log all transactions
To finish this tutorial, you can write the GetAccountHistory method that creates 
        a string for the transaction history. Add this method to the BankAccount type:
        public string GetAccountHistory()
{
    var report = new System.Text.StringBuilder();

    decimal balance = 0;
    report.AppendLine("Date\t\tAmount\tBalance\tNote");
    foreach (var item in allTransactions)
    {
        balance += item.Amount;
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
    }

    return report.ToString();
}" */
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        //    public void MakeDeposit(decimal amount, DateTime date, string note)
        //{
        //}

        //public void MakeWithdrawal(decimal amount, DateTime date, string note)
        //{
        //}
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
so I create a class file called BankAccount.cs and
change it from this: "using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class BankAccount
    {
    }
}"
to this: "namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}"
and in Program.cs I change from: "Console.WriteLine("Hello World!");"
to: "var account = new BankAccount("Attila Starkenius", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");"
*/

