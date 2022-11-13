using Q15;

int option, i;
var b = new Account();

Console.WriteLine("Welcome to Bank");
while(true)
{
    Console.WriteLine("1.Create Account");
    Console.WriteLine("2.Deposit");
    Console.WriteLine("3.Withdraw");
    Console.WriteLine("4.Balance Enquiry");
    Console.WriteLine();
    Console.Write("Enter option");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            b.create();
            break;
        case 2:
            b.deposit();
            break;
        case 3:
            b.withdraw();
            break;
        case 4:
            b.balance();
            break;
        default:
            Console.WriteLine("Wrong option");
            break;
    }

    Console.Write("Enter 1 to exit");
    i = int.Parse(Console.ReadLine());
    if (i == 1)
        break;

}