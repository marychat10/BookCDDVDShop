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

// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;
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
       


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            //closes the form
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            txtISBNLeft.Enabled = true;
            txtISBNRight.Enabled = true;
            txtPages.Enabled = true;
            txtAuthor.Enabled = true;
            btnClearForm.Enabled = true;
            

        }

        private void btnCreateCDOrc_Click(object sender, EventArgs e)
        {
            txtArtists.Enabled = true;
            txtCDLabel.Enabled = true;
            txtConductor.Enabled = true;
        }

        private void btnCreateCDCham_Click(object sender, EventArgs e)
        {
            txtArtists.Enabled = true;
            txtCDLabel.Enabled = true;
            txtInstruments.Enabled = true;
        }
    }    
}
