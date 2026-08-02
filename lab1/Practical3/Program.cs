using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch = 0;
            List<Expense> expenses = new List<Expense>();

            do
            {
                Console.WriteLine("\n**********************");
                Console.WriteLine("EXPENSE TRACKER MODULE");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Delete Expense");
                Console.WriteLine("5. Exit");

                try
                {
                    Console.Write("Enter Your Choice: ");
                    ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            try
                            {
                                Expense e = new Expense();
                                e.AcceptExpense();
                                expenses.Add(e);
                                Console.WriteLine("Expense Added!!!");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Input Format.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Returning to Main Menu...");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\nDisplaying all expenses:");

                            if (expenses.Count == 0)
                            {
                                Console.WriteLine("No Expenses Found.");
                            }
                            else
                            {
                                foreach (Expense e in expenses)
                                {
                                    e.DisplayExpense();
                                }
                            }
                            break;

                        case 3:
                            double total = 0;

                            foreach (Expense e in expenses)
                            {
                                total += e.amt;
                            }

                            Console.WriteLine("Total Expenses = Rs. " + total);
                            break;

                        case 4:
                            try
                            {
                                if (expenses.Count == 0)
                                {
                                    Console.WriteLine("No Expenses Found.");
                                    break;
                                }

                                Console.Write("Enter Expense ID to Delete: ");
                                int id = int.Parse(Console.ReadLine());

                                Expense exp = null;

                                foreach (Expense e in expenses)
                                {
                                    if (e.expId == id)
                                    {
                                        exp = e;
                                        break;
                                    }
                                }

                                if (exp != null)
                                {
                                    expenses.Remove(exp);
                                    Console.WriteLine("Expense Deleted Successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Expense ID Not Found.");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Expense ID.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Thank you for using Expense Tracker.");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Enter a Valid Choice.");
                    ch = 0;
                }

            } while (ch != 5);

            Console.ReadLine();
        }

        class Expense
        {
            public int expId;
            public string category;
            public double amt;
            public string paymentmode;
            public DateTime expDate;

            public void AcceptExpense()
            {
                Console.Write("Enter Expense ID: ");
                expId = int.Parse(Console.ReadLine());

                Console.Write("Enter Category: ");
                category = Console.ReadLine();

                Console.Write("Enter Amount: ");
                double inputAmt = double.Parse(Console.ReadLine());

                if (inputAmt <= 0)
                {
                    throw new ArgumentException("Amount must be greater than zero.");
                }

                amt = inputAmt;

                Console.Write("Enter Payment Mode: ");
                paymentmode = Console.ReadLine();

                Console.Write("Enter Date (yyyy-mm-dd): ");
                expDate = DateTime.Parse(Console.ReadLine());
            }

            public void DisplayExpense()
            {
                Console.WriteLine("\n--- Expense Details ---");
                Console.WriteLine("ID: " + expId);
                Console.WriteLine("Category: " + category);
                Console.WriteLine("Amount: " + amt);
                Console.WriteLine("Payment Mode: " + paymentmode);
                Console.WriteLine("Date: " + expDate.ToShortDateString());
            }
        }
    }
}