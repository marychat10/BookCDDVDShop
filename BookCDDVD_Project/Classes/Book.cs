using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using BookCDDVD_Project.Classes;
using System.Windows.Forms;



namespace BookCDDVD_Project.Classes
{
    [Serializable()]
    class Book: Product
    {
        private int hiddenISBN;
        private string hiddenAuthor;
        private int hiddenPages;

        public Book()
        {
            hiddenISBN = 0;
            hiddenAuthor = "";
            hiddenPages = 0;

        } // end Book Parameterless Constructor


        // Parameterized Constructor
        public Book(int UPC, decimal price, string title, int quantity, int ISBN, string author, int pages) : base(UPC, price, title, quantity)
        {
            hiddenISBN = ISBN;
            hiddenAuthor = author;
            hiddenPages = pages;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for Book ISBN
        public int BookISBN
        {
            get
            {
                return hiddenISBN;
            }  // end get
            set   // (string value)
            {
                hiddenISBN = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for Book Author
        public string BookAuthor
        {
            get
            {
                return hiddenAuthor;
            }  // end get
            set   // (string value)
            {
                hiddenAuthor = value;
            }  // end get
        }  // end Property

        // Accessor/mutator for Book Pages
        public int BookPages
        {
            get
            {
                return hiddenPages;
            }  // end get
            set   // (string value)
            {
                hiddenPages = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenISBN = Convert.ToInt32(f.txtISBNLeft.Text + f.txtISBNRight.Text);
            hiddenAuthor = f.txtAuthor.Text;
            hiddenPages= Convert.ToInt32(f.txtPages.Text);
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            String leftISBN = Convert.ToString(hiddenISBN).Substring(0, 3);
            String rightISBN = Convert.ToString(hiddenISBN).Substring(3);
            base.Display(f);
            f.txtISBNLeft.Text = Convert.ToString(hiddenISBN).Substring(0, 3);
            f.txtISBNRight.Text = Convert.ToString(hiddenISBN).Substring(3);
            f.txtAuthor.Text = hiddenAuthor.ToString();
            f.txtPages.Text = hiddenPages.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenISBN + hiddenAuthor + hiddenPages;
            return s;
        }  // end ToString

    }  // end Book class
}  // end namespace  









   