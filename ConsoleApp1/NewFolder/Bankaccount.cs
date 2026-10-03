using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    internal class Bankaccount
    {
        public int Id { get; set; }
        public decimal balanse { get; set; }
        public string pincode { get; set; }
        public Card card { get; set; } = new Card();

        public Bankaccount()
        {

        }

        public Bankaccount(int id, decimal balance, string pincode, Card card)
        {
            Id = id;
            balanse = balance;
            this.pincode = pincode;
            this.card = card;
        }
        public void TransferTo(Bankaccount toAccount, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("gadaricxvis tanxa dadebiti unda iyos");
            }

            else if (balanse >= amount)
            {
                balanse -= amount;
                toAccount.balanse += amount;
                Console.WriteLine($"warmatebit gadairicxa {amount} GEL.");
            }
            else
            {
                Console.WriteLine("arasakmarisi tanxa");
            }
        }


        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balanse += amount;
                Console.WriteLine($"angarisi tanxa warmatebit seicvala {amount} GEL");
            }
            else
            {
                Console.WriteLine("sesatani tanxa dadebiti unda iyos");
            }
        }

        public void ChangePinCode(string newPin)
        {
            if (!string.IsNullOrWhiteSpace(newPin) && newPin.Length == 4)
            {
                pincode = newPin;
                Console.WriteLine("PIN kodi warmatebit seicvala.");
            }
            else
            {
                Console.WriteLine("araswori PIN kodi");
            }
        }
    }
}
