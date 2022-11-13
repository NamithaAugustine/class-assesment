using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Account
    {
        public int Acc_no { get; set; }

        public string Name { get; set; }

        public int MobileNo { get; set; }

        public int Balance { get; set; }

        public void create()
        {
            Console.Write("Enter account number: ");
            Acc_no = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Mobile number: ");
            MobileNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Initial Balance: ");
            Balance = int.Parse(Console.ReadLine());
        }

        public void deposit()
        {
            Console.Write("Enter Deposit Ammount: ");
            Balance += int.Parse(Console.ReadLine());
            Console.WriteLine($"New balance is {Balance}");
        }

        public void withdraw()
        {
            Console.Write("Enter Withdraw Ammount: ");
            Balance -= int.Parse(Console.ReadLine());
            Console.WriteLine($"New balance is {Balance}");
        }

        public void balance()
        {
            Console.WriteLine($"Balance is {Balance}");
        }
    }
}
