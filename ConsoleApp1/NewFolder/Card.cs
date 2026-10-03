using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    internal class Card
    {
        public int Id { get; set; }
        public Guid Cardnumber { get; set; } = Guid.NewGuid();

        public Card()
        {

        }
        public Card(int id)
        {
            Id = id;
        }
    }
}
