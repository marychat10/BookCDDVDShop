using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BookCDDVDShop_Project.Classes
{
    class ProductDB
    {
        string dbProductType = "";  // type of record found in data base: Book, BookCIS, CDChamber, CDOrchestra, DVD
        string dbStringProduct = "";
        string fieldsFound = "";

        // Connection string for ProductDB (type: Microsoft Access) in the Resources folder
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../Debug/ProductDB.accdb";
        //string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source= " +
        // "L:\\ALL MY DATA\\Frank's Syllabus\\AAA CIS 3309 CSharp F19-S20\\CIS 3309 All Projects 2019-20\\BookCDDVD Project (adapted Jupin) DB Version\\ProductDB.accdb";

        // *********** INSERTION METHODS **********
        // 1 Inserts a new record for Product in the Product table with parameters UPC, Price, Title, Quantity, and
        //   productType
        public bool InsertProduct(int UPC, decimal price, string title, int quantity, string productType)
        {
            // SQL insert statement for Product
            // String dobStringTemp = ProductBirthdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

            string strInsertProduct = "INSERT INTO Product (fldUPC, fldPrice, fldTitle, fldQuantity, fldProductType) " +
                "VALUES(" + UPC + " , " + price + " , '" + title + "', " + quantity + ", '" + productType + "');";
            /*
            string strInsertBook = "INSERT INTO Book (fldUPC, fldISBN, fldauthor, fldpages) " +
                "VALUES(" + UPC + ", '" + ISBN + "', '" + author + "', " + pages + " );";

            */
            // Convert.ToDateTime(ProductBirthDate)
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertProduct, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert Product error: " + ex.Message,
                    "Product Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertProduct
    

        // 2 Inserts a new record into Book table with parameters UPC and ISBN, Author, Pages
        public bool InsertBook(int UPC, int ISBN, string author, int pages)
        {
            string strInsertBook = "INSERT INTO Book (fldUPC, fldISBN, fldAuthor, fldPages) " +
                "VALUES(" + UPC + ", '" + ISBN + "', '" + author + "', " + pages + " );";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertBook, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert Book error: " + ex.Message,
                     "Book Insert Failed", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertBook


        // 3 Inserts a new record into BookCIS table with parameters UPC and CISArea
        public bool InsertBookCIS(int UPC, string CISArea)
        {
            string strInsertBookCIS = "INSERT INTO BookCIS (fldUPC, fldCISArea) " +
                "VALUES(" + UPC + ", '" + CISArea + "' );";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertBookCIS, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert BookCIS error: " + ex.Message,
                    "BookCIS Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertBookCIS


        // 4 Inserts a new record into DVD table with parameters UPC and Lead Actor, Release Date and Run Time
        public bool InsertDVD(int UPC, string lead, DateTime relDate, int runTime)
        {
            string strInsertDVD = "INSERT INTO DVD (fldUPC, fldLeadActor, fldReleaseDate, fldRunTime) " +
                "VALUES(" + UPC + ", '" + lead + "', '" + relDate + "', " + runTime + " );";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertDVD, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert DVD error: " + ex.Message,
                   "DVD Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertDVD



        // 5 Inserts a new record into CDClassical table with parameters ProductUPC and 
        //     CDClassical Label and CDClassical Artists
        public bool InsertCDClassical(int UPC, string label, string artists)
        {
            string strInsertCDClassical = "INSERT INTO CDCLASSICAL (fldUPC, fldLabel, fldArtists) " +
                "VALUES(" + UPC + ", '" + label + "', '" + artists + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertCDClassical, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert CDCLassical error: " + ex.Message,
                    "CDClassical Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertCDClassical



        // 6 Inserts a new record into CD Chamber Music table with parameters ProductUPC and InstrumentList
        public bool InsertCDChamber(int UPC, string instrumentList)
        {
            string strInsertCDChamber = "INSERT INTO CDChamber (fldUPC, fldInstrumentList) " +
                "VALUES(" + UPC + ", '" + instrumentList + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertCDChamber, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert CDChamber error: " + ex.Message,
                    "CDChamber Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertCDChamber


        // 7 Inserts a new record into CDOrchestra table with parameters ProductUPC and Conductor
        public bool InsertCDOrchestra(int UPC, string Conductor)
        {
            string strInsertCDOrchestra = "INSERT INTO CDOrchestra (fldUPC, fldConductor) " +
                "VALUES(" + UPC + ", '" + Conductor + "') ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertCDOrchestra, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert CDOrchestra error: " + ex.Message,
                     "CDOrchestral Insert Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        }  // end InsertCDOrchestra

        // ********** End of INSERT methods **********



        // ********** SELECT (Query) Methods ********** 
        // 1 Queries/Selects records from all tables that match integer parameter ProductUPC
        // Returns a reference to the retrieved record

        public OleDbDataReader SelectProduct(int ProductUPC, out bool OKFlag)
        {
            // CURRENTLY NOT USED
            string strSelectProduct = "SELECT * FROM Product, Book, DVD, CDClassical, BookCIS, CDOrchestra, CDChamber "
                                                                                           + " WHERE Product.fldUPC = " + ProductUPC
                                                                                                + ", Book.fldUPC = " + ProductUPC
                                                                                                + ", BookCISUPC.fldUPC = " + ProductUPC
                                                                                                + ", DVD.fldUPC = " + ProductUPC
                                                                                                + ", CDClassicalUPC.fldUPC = " + ProductUPC
                                                                                                + ", CDChamberUPC.fldUPC = " + ProductUPC
                                                                                                + ", CDOrchestraUPCC.fldUPC = " + ProductUPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Select Product error: " + ex.Message,
                     "Product Select Failed", MessageBoxButtons.OK);
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            return myDataReader;
        }  // end SelectProduct



        // 1 Queries/selects records from Product table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a Product.
        public OleDbDataReader SelectProductFromProduct(int ProductUPC,
            out bool OKFlag, out string fieldsOut)
        {
            string strSelectProduct = "SELECT * FROM Product WHERE Product.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;
            string dbStringProduct = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true;

                myDataReader.Read();
                dbProductType = myDataReader["fldProductType"].ToString();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + dbProductType + Environment.NewLine;

                MessageBox.Show("Product Found ..." + Environment.NewLine
                    + dbStringProduct, "Show Found Product", MessageBoxButtons.OK);

                //dbProductType = myDataReader["fldProductType"].ToString();

                if (dbProductType == "Book")
                {
                    myDataReader = SelectProductFromBook(ProductUPC, out OKFlag, out fieldsFound);
                }
                else if (dbProductType == "BookCIS")
                {
                    myDataReader = SelectProductFromBookCIS(ProductUPC, out OKFlag, out fieldsFound);
                }
                else if (dbProductType == "DVD")
                {
                    myDataReader = SelectProductFromDVD(ProductUPC, out OKFlag, out fieldsFound);
                }
                else if (dbProductType == "CDClassical")
                {
                    myDataReader = SelectProductFromCDClassical(ProductUPC, out OKFlag, out fieldsFound);
                }
                else if (dbProductType == "CDOrchestra")
                {
                    myDataReader = SelectProductFromCDOrchestra(ProductUPC, out OKFlag, out fieldsFound);
                }
                else if (dbProductType == "CDChamber")
                {
                    myDataReader = SelectProductFromCDChamber(ProductUPC, out OKFlag, out fieldsFound);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select from Product error: " + ex.Message,
                    "Select from Product Failed", MessageBoxButtons.OK);

                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }
            //fieldsOut = dbStringProduct + fieldsFound;
            fieldsOut = fieldsFound;
            return myDataReader;
        } // end SelectProductFromProduct


        public string getProductType()
        {
            return dbProductType;
        }



        // 2 Queries/selects records from Book table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a Book record.

        public OleDbDataReader SelectProductFromBook(int ProductUPC,
            out Boolean OKFlag, out string fieldsFound)
        {
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
               + "Book.fldISBN, Book.fldAuthor, Book.fldPages FROM Product "
               + "INNER JOIN Book ON Book.fldUPC = Product.fldUPC "
               + "WHERE Book.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;

            string dbStringBook = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringBook = dbStringBook + myDataReader["fldISBN"].ToString() + Environment.NewLine;
                dbStringBook = dbStringBook + myDataReader["fldAuthor"].ToString() + Environment.NewLine;
                dbStringBook = dbStringBook + myDataReader["fldPages"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from Book error: " + ex.Message,
                     "Select Book Failed", MessageBoxButtons.OK);

                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            fieldsFound = dbStringProduct + dbStringBook;
            MessageBox.Show("Book Found ..." + Environment.NewLine
                + fieldsFound, "Show Found Product", MessageBoxButtons.OK);
            return myDataReader;
        }  // end SelectProductFromBook



        // 3 Queries/selects records from CDClassical table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a CDClassical record.

        public OleDbDataReader SelectProductFromCDClassical(int ProductUPC,
            out bool OKFlag, out string fieldsFound)
        {
            // string strSelectProduct = "SELECT * FROM CDClassical WHERE CDCLassical.fldUPC = " + ProductUPC;
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
                + "CDClassical.fldLabel, CDClassical.fld.Artists FROM Product"
                + "INNER JOIN CDClassical ON CDClassical.fldUPC = Product.fldUPC  "
                + "WHERE CDClassical.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;

            string dbStringCDClassical = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringCDClassical = dbStringCDClassical + myDataReader["fldLabel"].ToString() + Environment.NewLine;
                dbStringCDClassical = dbStringCDClassical + myDataReader["fldArtists"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from CDClassical error: " + ex.Message,
                    "Select CDClassical Failed", MessageBoxButtons.OK);

                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            fieldsFound = dbStringProduct + dbStringCDClassical;
            MessageBox.Show("CDClassical Found ..." + Environment.NewLine
                + fieldsFound, "Show Found CDCLassical", MessageBoxButtons.OK);
            return myDataReader;
        }  // end SelectProductFromCDClassical



        // 4 Queries/selects records from CDChamber table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a CDChamber record.

        public OleDbDataReader SelectProductFromCDChamber(int ProductUPC,
            out bool OKFlag, out string fieldsFound)
        {
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
                + "CDClassical.fldLabel, CDClassical.fldArtists, CDChamber.fldInstrumentList "
                + "FROM (Product "
                + "INNER JOIN CDClassical ON CDClassical.fldUPC = Product.fldUPC) "
                + "INNER JOIN CDChamber ON CDChamber.fldUPC = Product.fldUPC "
                + "WHERE Product.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;
            string dbStringProduct = "";
            string dbStringCDChamber = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringProduct = dbStringProduct + myDataReader["fldLabel"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldArtists"].ToString() + Environment.NewLine;

                dbStringCDChamber = dbStringCDChamber + myDataReader["fldInstrumentList"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from CDChamber error: " + ex.Message,
                    "Select CDChamber Failed", MessageBoxButtons.OK);

                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            fieldsFound = dbStringProduct + dbStringCDChamber;
            MessageBox.Show("CDChamber Found ..." + Environment.NewLine
                + fieldsFound, "Show Found CDChamber", MessageBoxButtons.OK);

            return myDataReader;
        } // end SelectProductFromCDChamber



        // 5 Queries/selects records from CDOrchestra table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a CDOrchestra record.

        public OleDbDataReader SelectProductFromCDOrchestra(int ProductUPC,
            out bool OKFlag, out string fieldsFound)
        {
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
                + "CDClassical.fldLabel, CDClassical.fldArtists, CDOrchestra.fldConductor "
                + "FROM (Product "
                + "INNER JOIN CDClassical ON Product.fldUPC = CDClassical.fldUPC) "
                + "INNER JOIN CDOrchestra ON CDClassical.fldUPC = CDOrchestra.fldUPC "
                + "WHERE Product.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;
            string dbStringProduct = "";
            string dbStringCDOrchestra = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringProduct = dbStringProduct + myDataReader["fldLabel"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldArtists"].ToString() + Environment.NewLine;

                dbStringCDOrchestra = dbStringCDOrchestra + myDataReader["fldConductor"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from CDOrchestra error: " + ex.Message,
                     "Select CDOrchestra Failed", MessageBoxButtons.OK);

                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            fieldsFound = dbStringProduct + dbStringCDOrchestra;
            MessageBox.Show("CDOrchestra Found ..." + Environment.NewLine
                + fieldsFound, "Show Found CDOrchestra", MessageBoxButtons.OK);
            return myDataReader;
        } // end SelectProductFromCDOrchestra



        // 6 Queries/selects records from DVD table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a DVD record.

        public OleDbDataReader SelectProductFromDVD(int ProductUPC,
            out bool OKFlag, out string fieldsFound)
        {
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
                + "DVD.fldLeadActor, DVD.fldReleaseDate, DVD.fldRunTime "
                + "FROM Product "
                + "INNER JOIN DVD ON DVD.fldUPC = Product.fldUPC "
                + "WHERE Product.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;
            string dbStringProduct = "";
            string dbStringDVD = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringDVD = dbStringDVD + myDataReader["fldLeadActor"].ToString() + Environment.NewLine;
                dbStringDVD = dbStringDVD + myDataReader["fldReleaseDate"].ToString() + Environment.NewLine;
                dbStringDVD = dbStringDVD + myDataReader["fldRunTime"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from DVD error: " + ex.Message,
                    "Select DVD Failed", MessageBoxButtons.OK);

                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            fieldsFound = dbStringProduct + dbStringDVD;
            MessageBox.Show("DVD Found ..." + Environment.NewLine
                + dbStringProduct, "Show Found DVD", MessageBoxButtons.OK);
            return myDataReader;
        } // end SelectProductFromDVD



        // 7 Queries/selects records from BookCIS table that match integer parameter ProductUPC
        // Returns a reference to the retrieved record AND a Success flag AND a String containing 
        //     substrings representing all the fields in a BookCIS record.

        public OleDbDataReader SelectProductFromBookCIS(int ProductUPC,
            out bool OKFlag, out string fieldsFound)
        {
            string strSelectProduct = "SELECT Product.fldUPC, Product.fldPrice, Product.fldTitle, Product.fldQuantity, Product.fldProductType, "
                + "Book.fldISBN, Book.fldAuthor, Book.fldPages, BookCIS.fldCISArea FROM (Product "
                + "INNER JOIN Book ON Product.fldUPC = Book.fldUPC) "
                + "INNER JOIN BookCIS ON Book.fldUPC = BookCIS.fldUPC "
                + "WHERE Product.fldUPC = " + ProductUPC + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectProduct, myConnection);
            OleDbDataReader myDataReader;
            string dbStringProduct = "";
            string dbStringBookCIS = "";

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false) OKFlag = false;
                else OKFlag = true; // returns true if Select was successful

                myDataReader.Read();
                dbStringProduct = myDataReader["fldUPC"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPrice"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldTitle"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldQuantity"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldProductType"].ToString() + Environment.NewLine;

                dbStringProduct = dbStringProduct + myDataReader["fldISBN"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldAuthor"].ToString() + Environment.NewLine;
                dbStringProduct = dbStringProduct + myDataReader["fldPages"].ToString() + Environment.NewLine;

                dbStringBookCIS = dbStringBookCIS + myDataReader["fldCISArea"].ToString() + Environment.NewLine;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select Product from BookCIS error: " + ex.Message,
                    "Select BookCIS Failed", MessageBoxButtons.OK);
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            fieldsFound = dbStringProduct + dbStringBookCIS;
            MessageBox.Show("BookCIS Found ..." + Environment.NewLine
                + dbStringProduct, "Show Found BookCIS", MessageBoxButtons.OK);
            return myDataReader;
        } // end SelectProductFromCBookCIS

        // ********** End of SELECT methods **********



        // ********** UPDATE Methods ********** 

        // Updates records from Product, Book, CDClassical, UndergraduateCDClassical and GraduateCDClassical tables that match integer parameter ProductUPC

        // 1 Updates record from Product Table using Product UPC
        public bool UpdateProduct(int UPC, decimal price, string title, int quantity)
        {
            string strUpdateProduct = "UPDATE Product SET " +
                                     "fldUPC = " + UPC + ", fldPrice = " + price + ", fldTitle = '" + title + "', fldQuantity = " + quantity +
                                     " WHERE fldUPC = " + UPC;  // Update Product record that matches the UPC

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateProduct, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update Product error: " + ex.Message,
                    "Update Product Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; // returns true if Update was successful
        }  // end UpdateProduct



        // 2 Updates record from Book table that match integer parameter ProductUPC
        public bool UpdateBook(int UPC, int ISBN, string author, int pages)
        {
            string strUpdateFaculty = "UPDATE Book SET " +
                                    "fldISBN = " + ISBN + ", fldAuthor = '" + author + "', fldPages = " + pages +
                                    " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateFaculty, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update Book error: " + ex.Message,
                    "Update Book Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Book


        // 3 Updates record from BookCIS table that match integer parameter ProductUPC
        public bool UpdateBookCIS(int UPC, string CISArea)
        {
            string strUpdateBookCIS = "UPDATE BookCIS SET fldCISArea = '" + CISArea + "' " +
                                    " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateBookCIS, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update BookCIS error: " + ex.Message,
                    "Update BookCIS Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update BookCIS



        // 4 Updates record from DVD table that match integer parameter ProductUPC
        public bool UpdateDVD(int UPC, string leadActor, DateTime releaseDate, int runTime)
        {
            string strUpdateFaculty = "UPDATE DVD SET " +
                                    "fldUPC = " + UPC + ", fldLeadActor = '" + leadActor + "', fldReleaseDate = " +
                                    releaseDate + ", fldRunTime = " + runTime +
                                    " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateFaculty, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update DVD error: " + ex.Message,
                     "DVD Update Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Book

        // 5 Updates records from CDClassical table that match integer parameter ProductUPC
        public bool UpdateCDClassical(int UPC, string label, string artist)
        {
            // string strUpdateCDClassical = "SELECT * FROM CDClassical WHERE CDClassical.CDClassicalID = " + ProductUPC; // string select statement
            string strUpdateCDClassical = "UPDATE CDClassical SET fldLabel = '" + label + "', fldArtist = '" + artist + "'" +
                                       " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDClassical, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update CDClassical error: " + ex.Message,
                   "CDClassical Update Failed", MessageBoxButtons.OK);
                return false; // returns false if Insert was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end UpdateCDClassical



        // 6 Updates records from CDChamber table that match integer parameter ProductUPC
        public bool UpdateCDChamber(int UPC, string instrumentList)
        {
            string strUpdateCDChamber =
                "UPDATE CDChamber SET fldInstrumentList = '" + instrumentList + "' " +
                " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDChamber, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update CDCHamber error: " + ex.Message,
                    "Update CDChamber Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        } // end UpdateCDChamber


        // 7 Updates records from CDOrchestra table that match integer parameter ProductUPC
        public bool UpdateCDOrchestra(int UPC, string conductor)
        {
            string strUpdateCDOrchestra =
                "UPDATE CDOrchestra SET fldConductor = '" + conductor + "' " +
                " WHERE fldUPC = " + UPC;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDOrchestra, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Update CDOrchestra error: " + ex.Message,
                    "Update CDOrchestra Failed", MessageBoxButtons.OK);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        } // end UpdateCDOrchestra




        // ********** End of UPDATE methods **********

        // ********** End edits



        // ********** DELETE Method ********** 
        // Deletes records all tables that have a matching ProductUPC 

        // Uses strConnection to open a connection with the database
        // Deletes Product with given ID from every table in the database
        // If a Product with the given ID is not in a table, the Delete command does nothing
        // Code written by Christopher Tither and Frank Branigan, CIS 3309 Section 1, April 2017
        // Updated by Frank Friedman June 2019
        public void Delete(int UPC)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM Product WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM Book WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM BookCIS WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM DVD WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM CDClassical WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    using (OleDbCommand command6 = new OleDbCommand("DELETE FROM CDChamber WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command6.ExecuteReader();
                    }
                    using (OleDbCommand command7 = new OleDbCommand("DELETE FROM CDOrchestra WHERE fldUPC = " + UPC, connection))
                    {
                        OleDbDataReader reader = command7.ExecuteReader();
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was a Delete Database Entry error: " + ex.Message,
                        "Delete Database Entry Failed", MessageBoxButtons.OK);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete
    } // end of Product class
} // end Namespace

