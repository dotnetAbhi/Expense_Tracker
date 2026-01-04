using ExpenseTracker.Services;

ExpenseManager manager = new();

while (true)
{
    Console.WriteLine("\n==== Expense Tracker ====");
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. View Expenses");
    Console.WriteLine("3. Show Total Expense");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            manager.AddExpense();
            break;

        case 2:
            manager.ViewExpenses();
            break;

        case 3:
            manager.ShowTotalExpense();
            break;

        case 4:
            Console.WriteLine("👋 Application closed");
            return;

        default:
            Console.WriteLine("❌ Invalid option");
            break;
    }
}
