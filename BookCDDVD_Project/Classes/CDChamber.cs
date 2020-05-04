using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVD_Project.Classes
{
    [Serializable()]

    class CDChamber : CDClassical
    {
        private string hiddenInstrumentList;

        public CDChamber()
        {
        }

        // Parameterized Constructor
        public CDChamber(int UPC, decimal price, string title, int quantity, string label, string artists, string instrumentList) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenInstrumentList = instrumentList;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for Book ISBN
        public string CDInstrumentList
        {
            get
            {
                return hiddenInstrumentList;
            }  // end get
            set   // (string value)
            {
                hiddenInstrumentList = value;
            }  // end get
        }  // end Property


        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenInstrumentList = f.txtInstruments.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            base.Display(f);
            f.txtInstruments.Text =  hiddenInstrumentList;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CD Info: " + hiddenInstrumentList.ToString();
            return s;
        }  // end ToString

    }  // end Book class
}  // end namespace  





