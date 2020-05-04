using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using BookCDDVD_Project.Classes;
using System.Windows.Forms;
using BookCDDVD_Project;

namespace BookCDDVD_Project.Classes
{
    [Serializable()]
    class CDClassical : Product
    {
        private string hiddenLabel;
        private string[] hiddenArtists;

        public CDClassical()
        {
        } // end CD Parameterless Constructor


        // Parameterized Constructor
        public CDClassical(int UPC, decimal price, string title, int quantity, string label, string[] artists) : base(UPC, price, title, quantity)
        {
            hiddenLabel = label;
            hiddenArtists = artists;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for Book ISBN
        public string CDLabel
        {
            get
            {
                return CDLabel;
            }  // end get
            set   // (string value)
            {
                hiddenLabel = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for Book Author
        public string[] CDArtists
        {
            get
            {
                return hiddenArtists;
            }  // end get
            set   // (string value)
            {
                hiddenArtists = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenLabel = f.txtCDLabel.Text;
            hiddenArtists = (f.txtArtists.Text).Split(',');
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            base.Display(f);
            f.txtCDLabel.Text = hiddenLabel;
            f.txtArtists.Text = string.Join(",", hiddenArtists);
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CD Info: " + hiddenLabel + hiddenArtists.ToString();
            return s;
        }  // end ToString

    }  // end Book class
}  // end namespace  









