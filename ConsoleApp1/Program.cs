using ConsoleApp1.NewFolder;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank(1, "TBC Bank", 50000m);
            Card card1 = new Card(101);
            Card card2 = new Card(102);

            Bankaccount account1 = new Bankaccount(1, 500m, "1234", card1);
            Bankaccount account2 = new Bankaccount(2, 200m, "5678", card2);


            Bankaccount[] userAccounts = new Bankaccount[] { account2 };
            User client = new User(1, "giorgi giorgadze", "giorgi@email.com", "password123", userAccounts);

            Bankaccount[] employeeAccounts = new Bankaccount[] { account1 };
            Emplooie employee = new Emplooie(2, "nika nikadze", "nika@email.com", "admin12345", employeeAccounts, myBank);
            employee.salary = 1500m;

            Console.WriteLine();
            account1.Deposit(300m);
            account1.TransferTo(account2, 150m);
            account1.ChangePinCode("4321");

            Console.WriteLine();
            client.ChangeFullname("giorgi beridze");
            client.Changepassword("newpassword123");

            Console.WriteLine();
            employee.GiveLoan(1000m, client);
            employee.TransferBalance(account2, account1);

            Console.ReadKey();
        }
    }
}
