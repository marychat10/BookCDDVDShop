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
    class BookCIS : Book
    {
        private string hiddenCISArea;

        public BookCIS()
        {
            hiddenCISArea = "";
        }
        // Parameterized Constructor
        public BookCIS(int UPC, decimal price, string title, int quantity, int ISBN, string author, int pages, string CISArea) : base(UPC, price, title, quantity, ISBN, author, pages)
        {

            hiddenCISArea = CISArea;
        }  // end Employee Parameterized Constructor
        // Accessor/mutator for CIS Book CISArea
        public string CISArea
        {
            get
            {
                return hiddenCISArea;
            }  // end get
            set   // (string value)
            {
                hiddenCISArea = value;
            }  // end get
        }  // end Property


        
        // Save data from form to object
        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenCISArea = f.comboCISArea.Text;
           
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            base.Display(f);
            f.comboCISArea.Text = hiddenCISArea;
            
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenCISArea;
            return s;
        }  // end ToString

    }  // end BookCIS class
}  // end namespace  





   