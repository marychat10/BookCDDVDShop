using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using BookCDDVD_Project;
using BookCDDVD_Project.Classes;

namespace BookCDDVDShop
{
    class FormController 
    {
        private frmBookCDDVD f;

        // Parametrized Constructor
        public FormController(frmBookCDDVD parentForm)
        {
            f = parentForm;
        }  // end Parameterized Constructor

        // Resets form to initial state after form is loaded or
        //    an add operation is performed

        public static void resetForm(frmBookCDDVD f)
        {
            //  Reset button components
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
            f.btnExit.Enabled = true;
            f.btnSave.Enabled = false;
            f.btnEnterUPC.Enabled = true;
            f.btnCreateBook.Enabled = true;
            f.btnCreateBook.Text = "Create Book";
            f.btnCreateCISBook.Enabled = true;
            f.btnCreateCISBook.Text = "Create Book CIS";
            f.btnCreateCDOrc.Enabled = true;
            f.btnCreateCDOrc.Text = "Create CD Orchestra";
            f.btnCreateCDChamber.Enabled = true;
            f.btnCreateCDChamber.Text = "Create CD Chamber";
            f.btnCreateDVD.Enabled = true;
            f.btnCreateDVD.Text = "Create DVD";

           
            // Reset Text boxes
            // f.txtProductUPC.Focus();
            f.txtUPC.Enabled = false;
            f.txtPrice.Enabled = false;
            f.txtTitle.Enabled = false;
            f.txtQuantity.Enabled = false;
            f.txtISBNLeft.Enabled = false;
            f.txtISBNRight.Enabled = false;
            f.txtAuthor.Enabled = false;
            f.txtPages.Enabled = false;
            f.txtLeadActor.Enabled = false;
            f.txtReleaseDate.Enabled = false;
            f.txtRunTime.Enabled = false;
            f.txtCDLabel.Enabled = false;
            f.txtArtists.Enabled = false;
            f.comboInstruments.Enabled = false;
            f.txtConductor.Enabled = false;
            f.comboCISArea.Enabled = false;
        } // end resetForm





        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmBookCDDVD f)
        {
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmBookCDDVD f)
        {
            f.btnCreateCDOrc.Enabled = true;
            f.btnCreateCISBook.Enabled = true;
            f.btnCreateCDChamber.Enabled = true;
            f.btnCreateBook.Enabled = true;
            f.btnCreateDVD.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmBookCDDVD f)
        {
            f.btnCreateCDOrc.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnCreateCISBook.Enabled = false;
        }  // end deactivateAddButtons


       


       


        // Clear all textboxes on the form
        public static void clear(frmBookCDDVD f)
        {
            f.txtUPC.Text = "";
            f.txtPrice.Text = "";
            f.txtTitle.Text = "";
            f.txtQuantity.Text = "";
            f.txtISBNLeft.Text = "";
            f.txtISBNRight.Text = "";
            f.txtAuthor.Text = "";
            f.txtPages.Text = "";
            f.txtCDLabel.Text = "";
            f.txtArtists.Text = "";
            f.comboInstruments.Text = "";
            f.txtConductor.Text = "";
            f.comboCISArea.Text = "";
            f.txtLeadActor.Text = "";
            f.txtReleaseDate.Text = "";
            f.txtRunTime.Text = "";
            resetForm(f);
        } // end Clear

    }  // end FormController class
}  // end namespace 

