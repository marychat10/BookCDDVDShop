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


        public static void searchForm(frmBookCDDVD f)
        {
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

        }





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


        // Deactivate all but Book
        public static void deactivateAllButBook(frmBookCDDVD f)
        {
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        } // end deactivateAllButBook
          // Deactivate all but BookCIS
        public static void deactivateAllButBookCIS(frmBookCDDVD f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        } // end deactivateAllButBookCIS
          // Deactivtae all but DVD
        public static void deactivateAllButDVD(frmBookCDDVD f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateAddButtons(f);
        } // end deactivateAllButDVD
          // Deactivate all but CDOrchestra
        public static void deactivateAllButCDOrchestra(frmBookCDDVD f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        } // end deactivateAllButCDChamber

        // Deactivate all but CDChamber
        public static void deactivateAllButCDChamber(frmBookCDDVD f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        } // end deactivateAllButCDOrchestra

      

        // Enables Product textboxes and highlights the Product groupbox
        public static void activateProduct(frmBookCDDVD f)
        {
            f.txtUPC.Enabled = true;
            f.txtPrice.Enabled = true;
            f.txtTitle.Enabled = true;
            f.txtQuantity.Enabled = true;
            f.txtUPC.BackColor = Color.LimeGreen;
            f.txtPrice.BackColor = Color.LimeGreen;
            f.txtTitle.BackColor = Color.LimeGreen;
            f.txtQuantity.BackColor = Color.LimeGreen;
        } // end activateProduct

        // Enables CDClassical textboxes and highlights the CDClassical groupbox
        public static void activateCDClassical(frmBookCDDVD f)
        {
            activateProduct(f);
            f.txtISBNLeft.Enabled = false;
            f.txtISBNRight.Enabled = false;
            f.txtAuthor.Enabled = false;
            f.txtPages.Enabled = false;
            f.txtLeadActor.Enabled = false;
            f.txtReleaseDate.Enabled = false;
            f.txtRunTime.Enabled = false;
            f.comboInstruments.Enabled = false;
            f.txtConductor.Enabled = false;
            f.comboCISArea.Enabled = false;
            f.txtISBNLeft.BackColor = Color.Red;
            f.txtISBNRight.BackColor = Color.Red;
            f.txtAuthor.BackColor = Color.Red;
            f.txtPages.BackColor = Color.Red;
            f.txtLeadActor.BackColor = Color.Red;
            f.txtReleaseDate.BackColor = Color.Red;
            f.txtRunTime.BackColor = Color.Red;
            f.comboInstruments.BackColor = Color.Red;
            f.txtConductor.BackColor = Color.Red;
            f.comboCISArea.BackColor = Color.Red;

            f.txtCDLabel.BackColor = Color.LimeGreen;
            f.txtArtists.BackColor = Color.LimeGreen;
            f.txtCDLabel.Enabled = true;
            f.txtArtists.Enabled = true;

        } // end ActivateCDCLassical

        // Enables Book textboxes and highlights the Book groupbox
        public static void activateBook(frmBookCDDVD f)
        {
            activateProduct(f);
            f.txtISBNLeft.Enabled = true;
            f.txtISBNRight.Enabled = true;
            f.txtAuthor.Enabled = true;
            f.txtPages.Enabled = true;
            f.txtISBNLeft.BackColor = Color.LimeGreen;
            f.txtISBNRight.BackColor = Color.LimeGreen;
            f.txtAuthor.BackColor = Color.LimeGreen;
            f.txtPages.BackColor = Color.LimeGreen;
            f.txtCDLabel.BackColor = Color.Red;
            f.txtArtists.BackColor = Color.Red;
            f.txtLeadActor.BackColor = Color.Red;
            f.txtReleaseDate.BackColor = Color.Red;
            f.txtRunTime.BackColor = Color.Red;
           
        } // end activateBook

        // Enables DVD textboxes and highlights the DVD groupbox
        public static void activateDVD(frmBookCDDVD f)
        {
            activateProduct(f);
            f.txtLeadActor.Enabled = true;
            f.txtReleaseDate.Enabled = true;
            f.txtRunTime.Enabled = true;
            f.txtLeadActor.BackColor = Color.LimeGreen;
            f.txtReleaseDate.BackColor = Color.LimeGreen;
            f.txtRunTime.BackColor = Color.LimeGreen;
            f.txtISBNLeft.BackColor = Color.Red;
            f.txtISBNRight.BackColor = Color.Red;
            f.txtAuthor.BackColor = Color.Red;
            f.txtPages.BackColor = Color.Red;
            f.txtCDLabel.BackColor = Color.Red;
            f.txtArtists.BackColor = Color.Red;


        } // end activateBook

        // Enables CDCl Chamber Nusic textboxes and highlights the CDCl Chamber Music
      
      public static void activateCDChamber(frmBookCDDVD f)
        {
            activateCDClassical(f); // CD Classical must be activated too
            f.comboInstruments.BackColor = Color.LimeGreen;
            f.comboInstruments.Enabled = true;
        } // end activateCDCLChamber

        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateCDOrchestra(frmBookCDDVD f)
        {
            activateCDClassical(f); // CDClassical must be activated too
            f.txtConductor.Enabled = true;
            f.txtConductor.BackColor = Color.LimeGreen;

        } // end activateCDClOrch

        // Enables BookCIS textboxes and highlights the BookCIS groupbox
        public static void activateBookCIS(frmBookCDDVD f)
        {
            activateBook(f); // Book must be activated too
            f.comboCISArea.Enabled = true;
            f.comboCISArea.BackColor = Color.LimeGreen;
           
        } // end activateWorker
          // ***** Disables Product textboxes and highlights the Product groupbox
        public static void deactivateProduct(frmBookCDDVD f)

        {
            deactivateCDClassical(f);
            deactivateBook(f);
            deactivateDVD(f);
            f.txtUPC.Enabled = false;
            f.txtPrice.Enabled = false;
            f.txtTitle.Enabled = false;
            f.txtQuantity.Enabled = false;
            f.txtUPC.BackColor = Color.Red;
            f.txtPrice.BackColor = Color.Red;
            f.txtTitle.BackColor = Color.Red;
            f.txtQuantity.BackColor = Color.Red;
        } // end deactivateProduct

        // Disables CDClassical textboxes and groupbox
        public static void deactivateCDClassical(frmBookCDDVD f)
        {
            deactivateCDChamber(f);
            deactivateCDOrchestra(f);
            f.txtCDLabel.BackColor = Color.Red;
            f.txtArtists.BackColor = Color.Red;
            f.txtCDLabel.Enabled = false;
            f.txtArtists.Enabled = true;
        } // end deactivateCDClassical

        // Disables Book textboxes and groupbox
        public static void deactivateBook(frmBookCDDVD f)
        {
            deactivateBookCIS(f);
            f.txtISBNLeft.Enabled = false;
            f.txtISBNRight.Enabled = false;
            f.txtAuthor.Enabled = false;
            f.txtPages.Enabled = false;
            f.txtISBNLeft.BackColor = Color.Red;
            f.txtISBNRight.BackColor = Color.Red;
            f.txtAuthor.BackColor = Color.Red;
            f.txtPages.BackColor = Color.Red;

        } // end deactivateBook

        // Disables CDClChamber textboxes and highlights the CD Chamber groupbox
        public static void deactivateCDChamber(frmBookCDDVD f)
        {
            f.comboInstruments.BackColor = Color.Red;
            f.comboInstruments.Enabled = false;
        } // end deactivateCDChamber

        // Disables CD Orchestra textboxes and the CD Orchestra groupbox
        public static void deactivateCDOrchestra(frmBookCDDVD f)
        {

            f.txtConductor.Enabled = false;
            f.txtConductor.BackColor = Color.Red;
        } // end deativateCDClOrch

        // Disables textboxes groupbox
        public static void deactivateBookCIS(frmBookCDDVD f)
        {
            f.comboCISArea.Enabled = false;
            f.comboCISArea.BackColor = Color.Red;
        } // end deativateBookCIS

        // Disables textboxes groupbox
        public static void deactivateDVD(frmBookCDDVD f)
        {
            f.txtLeadActor.Enabled = false;
            f.txtReleaseDate.Enabled = false;
            f.txtRunTime.Enabled = false;
            f.txtLeadActor.BackColor = Color.LimeGreen;
            f.txtReleaseDate.BackColor = Color.LimeGreen;
            f.txtRunTime.BackColor = Color.LimeGreen;
        } // end deativateBookCIS

      
    } // end FormController
}



