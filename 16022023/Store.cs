using System;
using System.Collections.Generic;

namespace _16022023
{
	public class Store
	{
        private Product[] products = new Product[100];
        private int productCount = 0;
        public int DairyProductCountLimit { get; set; }
        public decimal AlcoholPercentLimit { get; set; }

        public void AddProduct(Product product)
        {
            if (product is Drink && ((Drink)product).AlcoholPercent > AlcoholPercentLimit)
            {
                throw new ArgumentException("Alcohol percent is too high.");
            }
            else if (product is Dairy && CountDairyProducts() >= DairyProductCountLimit)
            {
                throw new ArgumentException("Dairy product count limit exceeded.");
            }
            else
            {
                product.No = GetNextProductNo();
                products[productCount] = product;
                productCount++;
            }
        }

        public bool HasProductByNo(int no)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public Drink[] GetDrinkProducts()
        {
            Drink[] drinkProducts = new Drink[CountDrinkProducts()];
            int drinkProductCount = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Drink)
                {
                    drinkProducts[drinkProductCount] = (Drink)products[i];
                    drinkProductCount++;
                }
            }
            return drinkProducts;
        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[] dairyProducts = new Dairy[CountDairyProducts()];
            int dairyProductCount = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Dairy)
                {
                    dairyProducts[dairyProductCount] = (Dairy)products[i];
                    dairyProductCount++;
                }
            }
            return dairyProducts;
        }

        private int GetNextProductNo()
        {
            return productCount + 1;
        }

        private int CountDrinkProducts()
        {
            int drinkProductCount = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Drink)
                {
                    drinkProductCount++;
                }
            }
            return drinkProductCount;
        }

        private int CountDairyProducts()
        {
            int dairyProductCount = 0;
            for (int i = 0; i < productCount; i++)
            {
                if (products[i] is Dairy)
                {
                    dairyProductCount++;
                }
            }
            return dairyProductCount;
        }
    }
}

