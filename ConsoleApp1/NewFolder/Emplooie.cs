using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    internal class Emplooie : User
    {

        public decimal salary { get; set; }
        public Bank bank { get; set; } = new Bank();
        public Emplooie() : base()
        {

        }
        public Emplooie(int id, string fullname, string email, string password, Bankaccount[] bankaccounts, Bank bank) : base(id, fullname, email, password, bankaccounts)
        {
            this.salary = salary;
            this.bank = bank;
        }

        public void GiveLoan(decimal amount, User user)
        {
            if (amount <= 0)
            {
                Console.WriteLine("sesxi unda iyos dadebiti");
                return;
            }

            if (bank.budget >= amount)
            {
                bank.budget -= amount;

                if (user.bankacount != null && user.bankacount.Length > 0)
                {
                    user.bankacount[0].balanse += amount;
                    Console.WriteLine($"sesxi ({amount} GEL) warmatebit gaica");
                }
                else
                {
                    Console.WriteLine("momxmarebels aqtiui eqaunti ar aqvs");
                }
            }
            else
            {
                Console.WriteLine("sakmarisi biujeti ar aqvs banks");
            }
        }


        public void TransferBalance(Bankaccount from, Bankaccount to)
        {
            if (from == null || to == null)
            {
                Console.WriteLine("angarisi ver moizebna");
            }

            if (from.balanse > 0)
            {
                to.balanse += from.balanse;
                Console.WriteLine($"warmatebit gadairicxa {from.balanse} GEL");
                from.balanse = 0;
            }
            else
            {
                Console.WriteLine("angarisi nullis tolia");
            }
        }

    }
}
