using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVDShop;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;
using BookCDDVD_Project.Classes;




namespace BookCDDVD_Project.Classes
{
    public static class SFManager
    {
        // This class manages s serializable file object by reading from and writing to a file

        // Write the Product List to file as a serialized binary object
        public static bool writeToFile(ProductList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Owl Member List not written", "SFManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    MessageBox.Show("File write: Owl Member List was written to serializable file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Owl Member List not written", "SFManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Product in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Product List from file as a serialized binary object
        public static bool readFromFile(ref ProductList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Product List", "SFManager, File Open Error");
                    plist = new ProductList();
                    return false;
                }  // end Try

                try
                {
                    plist = (ProductList)deserializer.Deserialize(TestFileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Product List", "SFManager File Read");
                    plist = new ProductList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Product List", "SF Manager Does Not Exist ");
                plist = new ProductList();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end SFManager Class
}  // end namespace














  