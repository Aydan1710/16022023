using System;
namespace _16022023
{
	public class Product
	{
        private static int _no = 0;
        public int No { get; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string value)
        {
            _no++;
            No = _no;
        }

       
    }
}

