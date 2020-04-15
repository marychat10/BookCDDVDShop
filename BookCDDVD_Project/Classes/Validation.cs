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
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
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
            if (quantity == "")
            {
                MessageBox.Show("Product quantity was blank ");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^[0-9]{1,5}$"))
            {
                MessageBox.Show("Product quantity must be equal or greather than zero");
                return false;

            }
            return true;
        }

        //validate product title
        public static bool ValidateProductTitle(string title)
        {
            if (title == "" || title.Length == 1)
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
            if (UPC == "" || UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters");
                return false;
            }
            if (UPC[0] == '0')
            {
                MessageBox.Show("UPC began with a 0!");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"\b\d{5}\b$"))
            {

                MessageBox.Show("Product UPC must be a 5 digit value with no leading zero");
                return false;

            }
            return true;

        }
        //validate product price
        public static bool ValidateProductPrice(string price)
        {
            if (price == "")
            {
                MessageBox.Show("Product Price was blank !");
                return false;

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(price, @"^((\$\d+)(\.\d{2}))$"))
            {
                MessageBox.Show("Product Price must be exactly 2 decimal places");
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
            if (pages == "")
            {
                MessageBox.Show("Book Pages was blank !");
                return false;
            }
            if (pages == "0")
            {
                MessageBox.Show("Book pages must be greater than 0");
                return false;
            }
            return true;
        }

        public static bool ValidateBookAuthor(string author)
        {
            if (author == "")
            {
                MessageBox.Show("Book Author was blank!");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(author, @"[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Book author must be letters ");
                return false;
            }
            return true;
        }

        public static bool ValidateBookISBN(string ISBN)
        {
            if (ISBN == "" || ISBN.Length != 6)
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

        //validate book entry
        public static bool ValidateCISBook(string CISArea)
        {
            if (ValidateCISArea(CISArea))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //validate CIS Book entry
        public static bool ValidateCISArea(string CISArea)
        {
            if (String.IsNullOrEmpty(CISArea))
            {
                MessageBox.Show("There must be at least one CISArea !");
                return false;
            }

            return true;
        }
        //validate product
        public static bool ValidateDVD(string leadActor, string releaseDate, string runTime)
        {
            if (ValidateDVDLeadActor(leadActor) && ValidateDVDReleaseDate(releaseDate) && ValidateDVDRunTime(runTime))
            {
                return true;
            }

           
            else
            {
                return false;
            }

        }
    


        //validate DVD entry
        public static bool ValidateDVDLeadActor(string leadActor)
        {
            if(String.IsNullOrEmpty(leadActor))
            {
                MessageBox.Show("Lead Actor is blank!");
                return false;
            }
            try
            {
                Convert.ToString(leadActor);

            }
            catch
            {
                MessageBox.Show("Lead Actor cannot contain numbers");
                return false;
            }
            return true;
        }

        public static bool ValidateDVDReleaseDate(string releaseDate)
        {
            try
            {
                DateTime date = Convert.ToDateTime(releaseDate);
                DateTime maxDate = new DateTime(2019, 12, 31);
                DateTime minDate = new DateTime(1980, 1, 1);
                if (String.IsNullOrEmpty(releaseDate))
                {
                    MessageBox.Show("DVD Release Date is empty!");
                    return false;
            }
                if (date.Date > maxDate)
                {
                    MessageBox.Show("Release date cannot be after December 31, 2019");
                    return false;
                }
                if (date.Date < minDate)
                {
                    MessageBox.Show("Release date cannot be before January 1, 1980");
                    return false;
                }
                return true;
            }

            catch
            {
                MessageBox.Show("DVD Release Date must be in correct format!");
                return false;
            }
        }

        public static bool ValidateDVDRunTime(string runTime)
        {
            try
            {
                int minutes = Convert.ToInt32(runTime);
                if (String.IsNullOrEmpty(runTime))
                {
                    MessageBox.Show("DVD Run Time is empty!");
                    return false;
                }

                if (minutes <= 0)
                {
                    MessageBox.Show("DVD Run Time cannot be less than or equal to 0 minutes!");
                    return false;
                }

                if (minutes > 240)
                {
                    MessageBox.Show("DVD Run Time cannot be more than 240 minutes!");
                    return false;
                }

                return true;
            }

            catch
            {
                MessageBox.Show("DVD Run Time must be an integer (run time in minutes)");
                return false;
            }
            
        }


        // Validate CD Entry
        public static bool ValidateCDLabel(string label)
        {
            if(String.IsNullOrEmpty(label))
            {
                MessageBox.Show("CD Label cannot be empty!");
                return false;
            }
            return true;
        }

        public static bool ValidateCDArtists(string artists)
        {
            if(String.IsNullOrEmpty(artists))
            {
                MessageBox.Show("CD Artists cannot be empty!");
                return false;
            }

            if(System.Text.RegularExpressions.Regex.IsMatch(artists, @"[\d]"))
            {
                MessageBox.Show("Artist name cannot contain numbers");
                return false;
            }

            return true;
        }

        public static bool  ValidateCDConductor(string conductor)
        {
            if(String.IsNullOrEmpty(conductor))
            {
                MessageBox.Show("CD Conductor cannot be empty!");
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(conductor, @"[\d]"))
            {
                MessageBox.Show("Conductor name cannot contain numbers");
                return false;
            }

            return true;
        }

        public static bool ValidateCDInstrumentList(string instruments)
        {
            if(String.IsNullOrEmpty(instruments))
            {
                MessageBox.Show("There must be at least one instrument in the CD Instrument List!");
                return false;
            }

            return true;
        }
    }
}
