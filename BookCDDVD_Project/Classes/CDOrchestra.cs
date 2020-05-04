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

    class CDOrchestra : CDClassical
    {
        private string hiddenConductor;

        public CDOrchestra()
        {
            hiddenConductor = "";
        }
        // Parameterized Constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity, string label, string artists, string conductor) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenConductor = conductor;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for Book ISBN
        public string CDConductor
        {
            get
            {
                return hiddenConductor;
            }  // end get
            set   // (string value)
            {
                hiddenConductor = value;
            }  // end get
        }  // end Property


        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenConductor = f.txtConductor.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            base.Display(f);
            f.txtConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CD Info: " + hiddenConductor;
            return s;
        }  // end ToString

    }  // end Book class
}  // end namespace  









