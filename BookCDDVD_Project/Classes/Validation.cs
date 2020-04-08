using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVD_Project.Classes;


namespace BookCDDVD_Project.Classes
{
    public static class Validation
    {
        //validate product
        public static bool ValidateProduct(string UPC, string price, string title, string quantity)
        {
         if(ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
            {
                return true;
            }
            else
            {
                return false;
            }
         
        
        }
         //validate product quantity
        public static bool ValidateProductQuantity(string quantity)
        {
            if(quantity == "")
            {
                MessageBox.Show("Product quantity was blank ");
                return false;
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^[0-9]  $"))
            {
                MessageBox.Show("Product quantity must be equal or greather than zero");
                return false;

            }
            return true;
        }

        //validate product title
        public static bool ValidateProductTitle(string title)
        {
            if(title == ""|| title.Length == 1)
            {
                MessageBox.Show("Product title was blank or less then two characters");
                return false;

            }
            try
            {
                Convert.ToString(title);
            }
            catch
            {
                MessageBox.Show("Product title must be letters");
                return false;


            }
            return true;

        }

        //validate product UPC
        public static bool ValidateProductUPC(string UPC)
        {
            if (UPC ==""|| UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters");
                return false;
            }
            if(UPC[0] == '0')
            {
                MessageBox.Show("UPC began with a 0!");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9] {5} $"))
            {

                MessageBox.Show("Product UPC must be a 5 digit value with no leading zero");
                return false;

            }
            return true;

        }
        //validate product price
        public static bool ValidateProductPrice(string price)
        {
            if(price =="")
            {
                MessageBox.Show("Product Price was blank !");
                return false;

            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(price, @"^((\d+)(\.\d{2}))$"))
            {
                MessageBox.Show("Product UPC must be exactly 2 decimal places");
                return false;
            }
            return true;
        }

        //validate book entry
        public static bool ValidateBook(string ISBN, string author, string pages)
        {
            if (ValidateBookISBN(ISBN) && ValidateBookAuthor(author) && ValidateBookPages(pages))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool ValidateBookPages(string pages)
        {
            if(pages == "")
            {
                MessageBox.Show("Book Pages was blank !");
                return false;
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(pages, @"^[1-9]{1,5}$"))
            {
                MessageBox.Show("Book pages must be greater than 0");
                return false;
            }
            return true;
        }

        public static bool ValidateBookAuthor(string author)
        {
           if(author == "")
            {
                MessageBox.Show("Book Author was blank!");
                return false;
            }
           if(!System.Text.RegularExpressions.Regex.IsMatch(author,@"^\s *[A - Za - z] + (?:\s +[A - Za - z] +) *\s *$"))
            {
                MessageBox.Show("Book author must be letters ");
                return false;
            }
            return true;
        }

        public static bool ValidateBookISBN(string ISBN)
        {
            if( ISBN == ""|| ISBN.Length != 6)
            {
                MessageBox.Show("Book ISBN was blank or not exactly 6 digits!");
                return false;
            }
            try
            {
               
                Convert.ToInt32(ISBN);
            }
            catch
            {
                MessageBox.Show("Book author must be letters ");
                return false;
            }
            return true;
           
        }
        //validate DVD entry
       
    }
}
