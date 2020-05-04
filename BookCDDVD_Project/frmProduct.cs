using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVD_Project.Classes;

// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;
using BookCDDVDShop;
using BookCDDVDShop_Project.Classes;

namespace BookCDDVD_Project
{

    public partial class frmBookCDDVD : Form
    {
        // This is a class object that manages a List of Products		
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Owl
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        string FileName = "PersistentObject.bin";

        // Database methods and attributes stored here
        ProductDB dbFunctions = new ProductDB();// Parameterless Constructor for fmrEmpMan



        public frmBookCDDVD()
        {
            InitializeComponent();
        }

        // Tooltip messages
        string ttCreateCDChamber = "Click to enter Make CDChamber mode to add a CDChamber to the List of Products.";
        string ttCreateCDOrchestra = "Click to enter Make CDOrchestra mode to add a CDOrchestra to the List of Products.";
        string ttCreateBook = "Click to enter Make Book mode to add a Book to the List of Products.";
        string ttCreateBookCIS = "Click to enter Make BookCIS mode to add a BookCIS to the List of Products.";
        string ttCreateDVD = "Click to enter Make DVD mode to add a DVD to the List of Products.";
        string ttSaveCDChamber = "Click to Save a CDChamber object to the List of Products.";
        string ttSaveCDOrchestra = "Click to Save a CDOrchestra object to the List of Products.";
        string ttSaveBookCIS = "Click to Save a BookCIS object to the list of Products.";
        string ttSaveBook = "Click to Save the Book object to the List of Products.";
        string ttSaveDVD = "Click to Save the DVD to the List of Products.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Product in the List of Products.";
        string ttDelete = "Click to Delete Product from the List of Products.";
        string ttEdit = "Click to Edit a Product's data.";
        string ttExit = "Click to exit application.";

        // ?????????? Fix The Specs (in red) for Each Item ??????????

        string ttProductUPC = "Enter a 5 digit integer - no leading zeros";
        string ttProductPrice = "Enter dollars and cents >= 0.0. NO $. Exactly two decimal digits";
        string ttProductTitle = "Enter a string of words (all letters) separated by blanks for any item in the shop";
        string ttProductQuantity = "Enter any integer greater than or equal to 0";
        string ttBookISBN = "Enter Book ISBN in format nnn-nnn)";
        string ttBookAuthor = "Enter Book Author first and last names (all letters) separated by a blank";
        string ttBookPages = "Enter Book page count as an integer greater than 0.";
        string ttDVDLeadActor = "Enter DVD Lead Actor with first and last names (all letters) separated by a blank.";
        string ttDVDReleaseDate = "Enter DVD Release Date in form mm/dd/yyyy between Jan 1 1980 and Dec 31 2019. Use date picker.";
        string ttDVDRunTime = "Enter DVD run time in minutes. Must be a positive integer.";
        string ttBookCISCISArea = "Enter valid CIS area of study using a drop-down menu.";
        string ttCDClassicalLabel = "Enter any sequence of words (all letters) separated by blanks.";
        string ttCDClassicalArtists = "Enter soloists last names separated by a blank";
        string ttCDChamberInstrumentList = "Enter Instrument names separated by a blank";
        string ttCDOrchestraConductor = "Enter Conductor last name with all letters and one blank or one hyphen";


        // This sub is called when the form is loaded
        private void frmBookCDDVD_Load(System.Object sender, System.EventArgs e)
        {
            //// Read serialized binary data file
            //SFManager.readFromFile(ref thisProductList, FileName);
            // FormController.clear(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateCISBook, ttCreateBookCIS);
            toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDOrchestra);
            toolTip1.SetToolTip(btnCreateCDOrc, ttCreateDVD);
            toolTip1.SetToolTip(btnCreateDVD, ttCreateCDChamber);

            toolTip1.SetToolTip(btnClearForm, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtUPC, ttProductUPC);
            toolTip1.SetToolTip(txtPrice, ttProductPrice);
            toolTip1.SetToolTip(txtQuantity, ttProductQuantity);
            toolTip1.SetToolTip(txtTitle, ttProductTitle);
            toolTip1.SetToolTip(txtConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtISBNLeft, ttBookISBN);
            toolTip1.SetToolTip(txtAuthor, ttBookAuthor);
            toolTip1.SetToolTip(txtPages, ttBookPages);
            toolTip1.SetToolTip(txtLeadActor, ttDVDLeadActor);
            toolTip1.SetToolTip(txtReleaseDate, ttDVDReleaseDate);
            toolTip1.SetToolTip(txtRunTime, ttDVDRunTime);
            toolTip1.SetToolTip(txtCDLabel, ttCDClassicalLabel);
            toolTip1.SetToolTip(txtArtists, ttCDClassicalArtists);
            toolTip1.SetToolTip(txtConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtInstruments, ttCDChamberInstrumentList);
            toolTip1.SetToolTip(comboCISArea, ttBookCISCISArea);
            toolTip1.SetToolTip(btnCreateCISBook, ttCreateBookCIS);
        } // end frmEBookCDDVDShop_Load

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of records processed = " +
                 recordsProcessedCount.ToString(),
                 "Exit Message", MessageBoxButtons.OK);
            MessageBox.Show("The list entries are ...", "Display List Entries");
            // thisProductList.displayProductList();

            // Save serialized binary file
            //  SFManager.writeToFile(thisProductList, FileName);

            this.Close();

        }
        // Validate Product data
        private bool ValidateProduct()
        {
            if (Validation.ValidateProductUPC(txtUPC.Text) == false)
            {
                txtUPC.Text = "";
                txtUPC.Focus();
                MessageBox.Show("Product UPC not valid. Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.ValidateProductPrice(txtPrice.Text) == false)
            {
                txtPrice.Text = "";
                txtPrice.Focus();
                MessageBox.Show("Product Price not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.ValidateProductTitle(txtTitle.Text) == false)
            {
                txtTitle.Text = "";
                txtTitle.Focus();
                MessageBox.Show("Product Title not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validation.ValidateProductQuantity(txtQuantity.Text) == false)
            {
                txtQuantity.Text = "";
                txtQuantity.Focus();
                MessageBox.Show("Product Quantity not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            return true;
        }   // end Validate Product data


        //Displays the part of the form for Book processing
        public void DisplayBookForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Book

            btnCreateBook.Text = "Save Book";
            FormController.formAddMode(this);
            txtUPC.Enabled = true;
            txtPrice.Enabled = true;
            txtTitle.Enabled = true;
            txtQuantity.Enabled = true;
            txtISBNLeft.Enabled = true;
            txtISBNRight.Enabled = true;
            txtAuthor.Enabled = true;
            txtPages.Enabled = true;


            toolTip1.SetToolTip(btnCreateBook, ttSaveBook);
            txtUPC.Focus();
        } // end DisplayCDChamberForm

        //Displays the part of the form for CIS Book processing
        public void DisplayCISBookForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Book

            btnCreateCISBook.Text = "Save CIS Book";
            FormController.formAddMode(this);
            txtUPC.Enabled = true;
            txtPrice.Enabled = true;
            txtTitle.Enabled = true;
            txtQuantity.Enabled = true;
            txtISBNLeft.Enabled = true;
            txtISBNRight.Enabled = true;
            txtAuthor.Enabled = true;
            txtPages.Enabled = true;
            comboCISArea.Enabled = true;


            toolTip1.SetToolTip(btnCreateCISBook, ttSaveBookCIS);
            txtUPC.Focus();
        } // end DisplayCISBook Form


        //Displays the part of the form for DVD processing
        public void DisplayDVDForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Book

            btnCreateDVD.Text = "Save DVD";
            FormController.formAddMode(this);
            txtUPC.Enabled = true;
            txtPrice.Enabled = true;
            txtTitle.Enabled = true;
            txtQuantity.Enabled = true;
            txtLeadActor.Enabled = true;
            txtReleaseDate.Enabled = true;
            txtRunTime.Enabled = true;


            toolTip1.SetToolTip(btnCreateDVD, ttSaveDVD);
            txtUPC.Focus();
        } // end DVD Form 


        public void DisplayCDOrchestraForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Book

            btnCreateCDOrc.Text = "Save CD";
            FormController.formAddMode(this);
            txtUPC.Enabled = true;
            txtPrice.Enabled = true;
            txtTitle.Enabled = true;
            txtQuantity.Enabled = true;
            txtArtists.Enabled = true;
            txtCDLabel.Enabled = true;
            txtConductor.Enabled = true;


            toolTip1.SetToolTip(btnCreateCDOrc, ttSaveCDOrchestra);
            txtUPC.Focus();
        } // end DVD Form 

        public void DisplayCDChamberForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Book

            btnCreateCDChamber.Text = "Save CD";
            FormController.formAddMode(this);
            txtUPC.Enabled = true;
            txtPrice.Enabled = true;
            txtTitle.Enabled = true;
            txtQuantity.Enabled = true;
            txtArtists.Enabled = true;
            txtCDLabel.Enabled = true;
            txtInstruments.Enabled = true;


            toolTip1.SetToolTip(btnCreateCDChamber, ttSaveCDChamber);
            txtUPC.Focus();
        } // end DVD Form 



        //Create a book
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            txtUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateBook.Text == "Create Book")
            {
                // Set up form for Undergrad processing
                DisplayBookForm();
                txtUPC.Focus();
            }

            else
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate
                //if (lookForDuplicate(Convert.ToInt32(txtUPC.Text)))
                //{
                //    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                //        MessageBoxButtons.OK);
                //    return;
                //}
                // Save an  if data is OK
                if (ValidateProduct() == false) return;
                string ISBN = txtISBNLeft.Text + txtISBNRight.Text;
                if (Validation.ValidateBook(ISBN, txtAuthor.Text, txtPages.Text) == false)
                {
                    txtISBNLeft.Text = "";
                    txtISBNRight.Text = "";
                    txtAuthor.Text = "";
                    txtPages.Text = "";
                    txtISBNLeft.Focus();
                    txtISBNRight.Focus();
                    txtAuthor.Focus();
                    txtPages.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }  // end inner if then

                dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "Book");
                dbFunctions.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(txtISBNLeft.Text + txtISBNRight.Text), txtAuthor.Text, Convert.ToInt32(txtPages.Text));

                Book thisBookObject = new Book();
                thisBookObject.Save(this);
                thisProductList.Add(thisBookObject);
                recordsProcessedCount++;
                MessageBox.Show("Book " + txtTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                FormController.clear(this);
                toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            }  // end outer else
        }  // end Create Book Object





        //Create a CIS book
        private void btnCreateCISBook_Click(object sender, EventArgs e)
        {
            txtUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCISBook.Text == "Create CIS Book")
            {
                // Set up form for Undergrad processing
                DisplayCISBookForm();
                txtUPC.Focus();
            }
            else
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate
                //if (lookForDuplicate(Convert.ToInt32(txtUPC.Text)))
                //{
                //    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                //        MessageBoxButtons.OK);
                //    return;
                //}
                // Save an  if data is OK

                if (ValidateProduct() == false) return;
                string ISBN = txtISBNLeft.Text + txtISBNRight.Text;
                if (Validation.ValidateBook(ISBN, txtAuthor.Text, txtPages.Text) == false)
                {
                    txtISBNLeft.Text = "";
                    txtISBNRight.Text = "";
                    txtAuthor.Text = "";
                    txtPages.Text = "";
                    txtISBNLeft.Focus();
                    txtISBNRight.Focus();
                    txtAuthor.Focus();
                    txtPages.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                if (Validation.ValidateCISBook(Convert.ToString(comboCISArea)) == false)
                {
                    comboCISArea.Text = "";
                    comboCISArea.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }

                // end inner if then

                dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "BookCIS");
                dbFunctions.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(txtISBNLeft.Text + txtISBNRight.Text), txtAuthor.Text, Convert.ToInt32(txtPages.Text));
                dbFunctions.InsertBookCIS(Convert.ToInt32(txtUPC.Text), comboCISArea.Text);

                BookCIS thisBookCISObject = new BookCIS();
                thisBookCISObject.Save(this);
                thisProductList.Add(thisBookCISObject);
                recordsProcessedCount++;
                MessageBox.Show("CISBook " + txtTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                FormController.clear(this);
                toolTip1.SetToolTip(btnCreateCISBook, ttCreateBookCIS);
            }
        }// end outer else



        //Create a DVD
        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            txtUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateDVD.Text == "Create DVD")
            {
                // Set up form for Undergrad processing
                DisplayDVDForm();
                txtUPC.Focus();
            }
            else
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate
                //if (lookForDuplicate(Convert.ToInt32(txtUPC.Text)))
                //{
                //    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                //        MessageBoxButtons.OK);
                //    return;
                //}
                // Save an  if data is OK
                if (ValidateProduct() == false) return;
                if (Validation.ValidateDVD(txtLeadActor.Text, txtReleaseDate.Text, txtRunTime.Text) == false)
                {
                    txtLeadActor.Text = "";
                    txtReleaseDate.Text = "";
                    txtRunTime.Text = "";
                    txtLeadActor.Focus();
                    txtReleaseDate.Focus();
                    txtRunTime.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }  // end inner if then

                dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "DVD");
                dbFunctions.InsertDVD(Convert.ToInt32(txtUPC.Text), txtLeadActor.Text,
                    Convert.ToDateTime(txtReleaseDate.Text), Convert.ToInt32(txtRunTime.Text));

                DVD thisDVDObject = new DVD();
                thisDVDObject.Save(this);
                thisProductList.Add(thisDVDObject);
                recordsProcessedCount++;
                MessageBox.Show("DVD " + txtTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                FormController.clear(this);
                toolTip1.SetToolTip(btnCreateDVD, ttCreateDVD);
            }  // end outer else
        }  // end Create DVD Object


        //this is a static variable to be referenced throughout the form code behind
        ProductDB pdb = new ProductDB(); // Creates new productDB object

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool temp = Validation.ValidateProductUPC(txtUPC.Text); //first make sure the format is correct
            if (temp)
            {
                bool found; // boolean reference for search success
                string pstring; // Product string updated upon product DB search call.
                Product prod;

                //  this returns an OleDbDataReader object, but you don't really need to use it
                //  the boolean flag and string that are returned are important
                //  pstring will hold the attributes of a product from the database in a single string, separated by newline characters
                //  split it below 

                OleDbDataReader odb = pdb.SelectProductFromProduct(Convert.ToInt32(txtUPC.Text), out found, out pstring);

                if (!found) //not found
                {
                    MessageBox.Show("Product not found");
                    txtUPC.Clear();
                    txtUPC.Focus();

                } // Creates a new product to display in form.
                else
                {
                    string[] attributes = pstring.Split('\n'); // splits product attributes into array

                    for (int i = 0; i < attributes.Length; i++)
                    {
                        attributes[i] = attributes[i].Trim('\r'); // clears "junk" from each field
                    }

                    string ptype = attributes[4]; // gets the product type from this attribute and then creates new product to display in form

                    if (ptype == "DVD")
                    {
                        prod = new DVD(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                           attributes[4], Convert.ToDateTime(attributes[7]), Convert.ToInt32(attributes[6]));
                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();
                    }
                    else if (ptype == "Book")
                    {

                        prod = new Book(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            Convert.ToInt32(attributes[4]), attributes[5], Convert.ToInt32(attributes[6]));

                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();


                    }
                    else if (ptype == "BookCIS")
                    {
                        prod = new BookCIS(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            Convert.ToInt32(attributes[4]), attributes[5], Convert.ToInt32(attributes[6]), attributes[7]);

                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();


                    }
                    else if (ptype == "CDOrchestra")
                    {
                        prod = new CDOrchestra(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[4], attributes[5], attributes[6]);

                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();


                    }
                    else if (ptype == "CDClassical")
                    {
                        prod = new CDClassical(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[4], attributes[5]);

                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();
                    }
                    else if (ptype == "CDChamber")
                    {
                        prod = new CDChamber(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                            attributes[4], attributes[5], attributes[6]);

                        prod.Display(this);
                        FormController.searchForm(this);
                        txtUPC.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Invalid record, Record is not type product");
                        // this is an invalid record (since it does not fit one of our types)
                    }
                }
            }

            else
            {
                MessageBox.Show("Product UPC is invlalid");
                // UPC is invalid
            }
        }

        private Boolean findAnItem(string Edit)
        {

            return true;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool success;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            success = findAnItem(" Edit / Update"); 
            if (success)
            {
                btnEdit.Enabled = true;
                btnEdit.Enabled = false;
                Product p = thisProductList.getAnItem(currentIndex);
                txtPrice.Text = p.ProductPrice.ToString();
                txtUPC.Text = p.ProductUPC.ToString();
                txtQuantity.Text = p.ProductQuantity.ToString();
                txtTitle.Text = p.ProductTitle.ToString();
                MessageBox.Show("Edit / UPDATE current Product(as shown). Press Save Updates Button", "Edit / Update Notice", MessageBoxButtons.OK);
                if (p.GetType() == typeof(CDChamber))
                {
                    FormController.activateCDChamber(this);
                    FormController.deactivateAllButCDChamber(this);
                    FormController.deactivateAddButtons(this);
                    txtLabel.Text = ((CDClassical)p).CDLabel;
                    txtArtists.Text = ((CDClassical)p).CDArtists;
                    txtInstruments.Text =
                    ((CDChamber)p).CDInstrumentList;
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);
                    txtLabel.Text = ((CDClassical)p).CDLabel;
                    txtArtists.Text = ((CDClassical)p).CDArtists;
                    txtConductor.Text = ((CDOrchestra)p).CDConductor;
                }
                else if (p.GetType() == typeof(Book))
                {
                    FormController.activateBook(this);
                    FormController.deactivateAllButBook(this);
                    FormController.deactivateAddButtons(this);
                    txtISBNLeft.Text = (((Book)p).BookISBN).ToString().Substring(0, 3);

                    txtISBNRight.Text = (((Book)p).BookISBN).ToString().Substring(3, 6);
                    txtAuthor.Text = ((Book)p).BookAuthor;
                    txtPages.Text = ((Book)p).BookPages.ToString();
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);
                    txtISBNLeft.Text = (((Book)p).BookISBN).ToString().Substring(0, 3);

                    txtISBNRight.Text = (((Book)p).BookISBN).ToString().Substring(3, 6);
                    txtAuthor.Text = ((Book)p).BookAuthor;
                    txtPages.Text = ((Book)p).BookPages.ToString();
                    comboCISArea.Text = ((BookCIS)p).CISArea; ;
                } // end multiple alternative if
                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);
                    txtLeadActor.Text = ((DVD)p).LeadActor;
                    txtReleaseDate.Text =
                    ((DateTime)((DVD)p).releaseDate).ToString(" mm / dd / yyyy");
                    txtRunTime.Text = (((DVD)p).runTime).ToString();
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated.","Mis - typed Object ", MessageBoxButtons.OK);
                    this.Close();
                } // end multiple alternative if
            } // end if on success
        } // end btnEdit_Click

        private void btnCreateCDOrc_Click(object sender, EventArgs e)
        {
            txtUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCDOrc.Text == "Create CD Orchestra")
            {
                // Set up form for Undergrad processing
                DisplayCDOrchestraForm();
                txtUPC.Focus();
            }
            else 
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate
                //if (lookForDuplicate(Convert.ToInt32(txtUPC.Text)))
                //{
                //    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                //        MessageBoxButtons.OK);
                //    return;
                //}
                // Save an  if data is OK

                if (Validation.ValidateCD(txtCDLabel.Text, txtArtists.Text, txtConductor.Text, txtInstruments.Text) == false)
                {
                    txtCDLabel.Text = "";
                    txtArtists.Text = "";
                    txtConductor.Text = "";
                    txtInstruments.Text = "";
                    txtCDLabel.Focus();
                    txtArtists.Focus();
                    txtConductor.Focus();
                    txtInstruments.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }
                if (Validation.ValidateCDOrchestra(txtConductor.Text) == false)
                {
                    txtConductor.Text = "";
                    txtConductor.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }


                // end inner if then

                dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "CDOrchestra");
                dbFunctions.InsertCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text,
                    txtArtists.Text);
                dbFunctions.InsertCDOrchestra(Convert.ToInt32(txtUPC.Text), txtConductor.Text);

                CDOrchestra thisCDOrchestraObject = new CDOrchestra();
                thisCDOrchestraObject.Save(this);
                thisProductList.Add(thisCDOrchestraObject);
                recordsProcessedCount++;
                MessageBox.Show("CD Orchestra " + txtTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                FormController.clear(this);
                toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDChamber);
            }
        }// end outer else

        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            txtUPC.Focus();
            btnEnterUPC.Enabled = false;
            if (btnCreateCDChamber.Text == "Create CD Chamber")
            {
                // Set up form for Undergrad processing
                DisplayCDChamberForm();
                txtUPC.Focus();
            }

            else
            {
                if (ValidateProduct() == false) return;
                // Look for duplicate
                //if (lookForDuplicate(Convert.ToInt32(txtUPC.Text)))
                //{
                //    MessageBox.Show("Duplicates not allowed in this application.", "Duplicates Not Allowed",
                //        MessageBoxButtons.OK);
                //    return;
                //}
                // Save an  if data is OK

                if (Validation.ValidateCD(txtCDLabel.Text, txtArtists.Text, txtConductor.Text, txtInstruments.Text) == false)
                {
                    txtCDLabel.Text = "";
                    txtArtists.Text = "";
                    txtConductor.Text = "";
                    txtInstruments.Text = "";
                    txtCDLabel.Focus();
                    txtArtists.Focus();
                    txtConductor.Focus();
                    txtInstruments.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }

                if (Validation.ValidateCDChamber(txtInstruments.Text) == false)
                {
                    txtInstruments.Text = "";
                    txtConductor.Focus();
                    MessageBox.Show("Please check that all data is entered and valid.");
                    return;
                }

                // end inner if then

                dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "CDChamber");
                dbFunctions.InsertCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text,
                    txtArtists.Text);
                dbFunctions.InsertCDChamber(Convert.ToInt32(txtUPC.Text), txtInstruments.Text);

                CDChamber thisCDChamberObject = new CDChamber();
                thisCDChamberObject.Save(this);
                thisProductList.Add(thisCDChamberObject);
                recordsProcessedCount++;
                MessageBox.Show("CD Chamber " + txtTitle.Text +
                    " Added to DB and Serializable File. Press OK to continue.",
                    "Transaction Complete", MessageBoxButtons.OK);
                FormController.clear(this);
                toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDChamber);
            }
        }

        private void lookForDuplicates(int UPC)
        {

        }

        private void getItem(int i)
        {
            if (thisProductList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                // btnToString.Enabled = false;
                lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisProductList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                thisProductList.getAnItem(i).Display(this);
                lblUserMessage.Text = "Object Type: " +
                   thisProductList.getAnItem(i).GetType().ToString() +
                   " List Index: " + i.ToString();
                btnFind.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }  // end else
        } // end getItem

    }
}
