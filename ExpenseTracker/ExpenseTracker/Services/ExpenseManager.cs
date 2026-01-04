using ExpenseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.Services
{
    public class ExpenseManager
    {
        private readonly List<Expense> _expenses = new();
        private int _id = 1;

        public void AddExpense()
        {
            Console.Write("Enter Expense Title: ");
            string title = Console.ReadLine()!;

            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            _expenses.Add(new Expense
            {
                Id = _id++,
                Title = title,
                Amount = amount,
                Date = DateTime.Now
            });

            Console.WriteLine("✅ Expense added successfully");
        }

        public void ViewExpenses()
        {
            if (_expenses.Count == 0)
            {
                Console.WriteLine("❌ No expenses found");
                return;
            }

            Console.WriteLine("\n--- Expense List ---");
            foreach (var e in _expenses)
            {
                Console.WriteLine($"{e.Id}. {e.Title} | ₹{e.Amount} | {e.Date:d}");
            }
        }

        public void ShowTotalExpense()
        {
            decimal total = _expenses.Sum(e => e.Amount);
            Console.WriteLine($"💰 Total Expense: ₹{total}");
        }
    }
}
