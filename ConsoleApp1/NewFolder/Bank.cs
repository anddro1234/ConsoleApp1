using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    internal class Bank
    {
        public int Id { get; set; }
        public string bankName { get; set; }
        public decimal budget { get; set; }

        public Bank()
        {

        }

        public Bank(int id, string bankname, decimal budjet)
        {
            Id = id;
            bankName = bankname;
            budget = budjet;
        }
    }
}
