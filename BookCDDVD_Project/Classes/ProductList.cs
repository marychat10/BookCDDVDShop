using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BookCDDVD_Project.Classes
{
    [Serializable()]
    public class ProductList
    {
        //Product List
        private List<Product> hiddenProductList = new List<Product>();

        //Parameterless Constructor
        public ProductList()
        {

        }
        //Add a Product to List

        public void Add(Product p)
        {
            hiddenProductList.Add(p);
        }
        // These two methods replace what was a VB Property
        // get or set an item in the List
        public Product getAnItem(int i)
        {
            return hiddenProductList[i];
        } // end getAnItem


        public void setAnItem(int i, Product value)
        {
            hiddenProductList[i] = value;

        } // end set


        public int Count()
        {
            return (hiddenProductList.Count);

        }

        public void displayProductList()
        {
            foreach(Product p in hiddenProductList)
            {
                MessageBox.Show("Product Information Added:" + "\r\n" + "Title:" + p.ProductTitle + "\r\n" + "UPC:" + p.ProductUPC.ToString() + "\r\n" + "Quantity:" + p.ProductQuantity.ToString() + "\r\n"
                    + "Price: $" + p.ProductPrice.ToString("0.00"));


            }

        }

        public Boolean Duplicate(string UPC)
        {
            for (int i = 0; i > hiddenProductList.Count();)
            {
                if (UPC == hiddenProductList[i].ProductUPC.ToString())
                {
                    return true;

                }
                else
                {
                    i++;
                }
            }
            return false;

        }


        //If matching UPC was found return true
        public int UPCMatch(string UPC)
        {
            for(int i = 0; i < hiddenProductList.Count(); i++)
            {
                string productUPC = hiddenProductList[i].ProductUPC.ToString();
                if (UPC == productUPC)
                {
                    return i;

                }
            }
            return -1;
        }

        public bool findUPC(string UPC)
        {
            for (int i = 0; i > hiddenProductList.Count();)
            {
                if (UPC == hiddenProductList[i].ProductUPC.ToString())
                {
                    return true;

                }
                else
                {
                    i++;
                }
            }
            return false;
        }



    }
}
