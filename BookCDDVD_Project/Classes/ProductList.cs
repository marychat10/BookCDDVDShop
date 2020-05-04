using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;

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

    }
}
