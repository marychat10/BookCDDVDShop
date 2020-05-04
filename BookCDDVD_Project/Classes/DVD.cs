using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVD_Project.Classes
{
    [Serializable()]
    class DVD : Product
    {
        private string hiddenLeadActor;
        private DateTime hiddenReleaseDate;
        private int hiddenRunTime;

        public DVD()
        {
            hiddenLeadActor = "";

            hiddenReleaseDate = new DateTime(1998, 04, 30); ;
            hiddenRunTime = 0;

        } // end DVD Parameterless Constructor


        // Parameterized Constructor
        public DVD(int UPC, decimal price, string title, int quantity, string leadActor, DateTime releaseDate, int runTime) : base(UPC, price, title, quantity)
        {
            hiddenLeadActor= leadActor;
            hiddenReleaseDate = releaseDate;
            hiddenRunTime = runTime;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for leadActor
        public string LeadActor
        {
            get
            {
                return hiddenLeadActor;
            }  // end get
            set   // (string value)
            {
                hiddenLeadActor = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for release date
        public DateTime releaseDate
        {
            get
            {
                return hiddenReleaseDate;
            }  // end get
            set   // (string value)
            {
                hiddenReleaseDate = value;
            }  // end get
        }  // end Property

        // Accessor/mutator for runtime
        public int runTime
        {
            get
            {
                return hiddenRunTime;
            }  // end get
            set   // (string value)
            {
                hiddenRunTime = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmBookCDDVD f)
        {
            base.Save(f);
            hiddenLeadActor = f.txtLeadActor.Text;
            hiddenReleaseDate = Convert.ToDateTime(f.txtReleaseDate.Text);
            hiddenRunTime= Convert.ToInt32(f.txtRunTime.Text);
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVD f)
        {
            base.Display(f);
            f.txtLeadActor.Text = hiddenLeadActor.ToString();
            f.txtReleaseDate.Text = hiddenReleaseDate.ToString();
            f.txtRunTime.Text = hiddenRunTime.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenLeadActor  + hiddenReleaseDate + hiddenRunTime;
            return s;
        }  // end ToString

    }  // end CDClassical class
}  // end namespace  






  