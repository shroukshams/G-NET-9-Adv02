using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G_NET_9_Adv02
{
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }


        public override string ToString()
            => $"{Name} - ${Price} (Stock: {Stock})";



    }
}
