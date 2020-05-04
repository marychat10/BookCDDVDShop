namespace BookCDDVD_Project
{
    partial class frmBookCDDVD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnCreateCISBook = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateCDOrc = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBNLeft = new System.Windows.Forms.TextBox();
            this.lblHyphen = new System.Windows.Forms.Label();
            this.txtISBNRight = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblCISBook = new System.Windows.Forms.Label();
            this.comboCISArea = new System.Windows.Forms.ComboBox();
            this.lblCISArea = new System.Windows.Forms.Label();
            this.lblDVD = new System.Windows.Forms.Label();
            this.lblLeadActor = new System.Windows.Forms.Label();
            this.txtLeadActor = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtRunTime = new System.Windows.Forms.TextBox();
            this.lblCDClassical = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.Label();
            this.txtCDLabel = new System.Windows.Forms.TextBox();
            this.lblArtists = new System.Windows.Forms.Label();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.lblCDOrchestraMusic = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.lblCDChamberMusic = new System.Windows.Forms.Label();
            this.lblInstruments = new System.Windows.Forms.Label();
            this.lblMoreInstructions = new System.Windows.Forms.Label();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(791, 67);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Entry and Display for Book CD DVD Shop\r\n";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(402, 150);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(1452, 32);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "To CREATE a new Book, CIS Book, DVD, Orchestra CD or Chamber CD always press a bu" +
    "tton below before typing\r\n";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(174, 282);
            this.lblControls.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(422, 32);
            this.lblControls.TabIndex = 2;
            this.lblControls.Text = "Controls for creating a new entry\r\n";
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(181, 344);
            this.btnCreateBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(281, 70);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // btnCreateCISBook
            // 
            this.btnCreateCISBook.Location = new System.Drawing.Point(571, 344);
            this.btnCreateCISBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCISBook.Name = "btnCreateCISBook";
            this.btnCreateCISBook.Size = new System.Drawing.Size(281, 70);
            this.btnCreateCISBook.TabIndex = 4;
            this.btnCreateCISBook.Text = "Create CIS Book";
            this.btnCreateCISBook.UseVisualStyleBackColor = true;
            this.btnCreateCISBook.Click += new System.EventHandler(this.btnCreateCISBook_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(962, 344);
            this.btnCreateDVD.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(281, 70);
            this.btnCreateDVD.TabIndex = 5;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.btnCreateDVD_Click);
            // 
            // btnCreateCDOrc
            // 
            this.btnCreateCDOrc.Location = new System.Drawing.Point(1330, 344);
            this.btnCreateCDOrc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCDOrc.Name = "btnCreateCDOrc";
            this.btnCreateCDOrc.Size = new System.Drawing.Size(357, 70);
            this.btnCreateCDOrc.TabIndex = 6;
            this.btnCreateCDOrc.Text = "Create CD Orchestra";
            this.btnCreateCDOrc.UseVisualStyleBackColor = true;
            this.btnCreateCDOrc.Click += new System.EventHandler(this.btnCreateCDOrc_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(174, 470);
            this.lblDirections.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(1364, 32);
            this.lblDirections.TabIndex = 8;
            this.lblDirections.Text = "To Find/Search, Edit/Update or Delete. Enter Product UPC and Select appropriate c" +
    "ontrol at bottom of form.\r\n";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(153, 535);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(134, 39);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "Product";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(185, 611);
            this.lblUPC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(74, 32);
            this.lblUPC.TabIndex = 10;
            this.lblUPC.Text = "UPC";
            // 
            // txtUPC
            // 
            this.txtUPC.Enabled = false;
            this.txtUPC.Location = new System.Drawing.Point(308, 606);
            this.txtUPC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(217, 38);
            this.txtUPC.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(642, 611);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 32);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(770, 611);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(217, 38);
            this.txtPrice.TabIndex = 13;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(1100, 620);
            this.lblProductTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(70, 32);
            this.lblProductTitle.TabIndex = 14;
            this.lblProductTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(1212, 611);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(217, 38);
            this.txtTitle.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(1506, 615);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 32);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(1678, 606);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(217, 38);
            this.txtQuantity.TabIndex = 17;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Enabled = false;
            this.btnClearForm.Location = new System.Drawing.Point(2039, 535);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(171, 119);
            this.btnClearForm.TabIndex = 18;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(2039, 713);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 119);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(153, 687);
            this.lblBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(95, 39);
            this.lblBook.TabIndex = 20;
            this.lblBook.Text = "Book";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(176, 783);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(80, 32);
            this.lblISBN.TabIndex = 21;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBNLeft
            // 
            this.txtISBNLeft.Enabled = false;
            this.txtISBNLeft.Location = new System.Drawing.Point(308, 773);
            this.txtISBNLeft.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtISBNLeft.Name = "txtISBNLeft";
            this.txtISBNLeft.Size = new System.Drawing.Size(98, 38);
            this.txtISBNLeft.TabIndex = 22;
            // 
            // lblHyphen
            // 
            this.lblHyphen.AutoSize = true;
            this.lblHyphen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHyphen.Location = new System.Drawing.Point(427, 775);
            this.lblHyphen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHyphen.Name = "lblHyphen";
            this.lblHyphen.Size = new System.Drawing.Size(31, 42);
            this.lblHyphen.TabIndex = 23;
            this.lblHyphen.Text = "-";
            // 
            // txtISBNRight
            // 
            this.txtISBNRight.Enabled = false;
            this.txtISBNRight.Location = new System.Drawing.Point(473, 775);
            this.txtISBNRight.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtISBNRight.Name = "txtISBNRight";
            this.txtISBNRight.Size = new System.Drawing.Size(98, 38);
            this.txtISBNRight.TabIndex = 24;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(642, 783);
            this.Author.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(99, 32);
            this.Author.TabIndex = 25;
            this.Author.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(770, 775);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(217, 38);
            this.txtAuthor.TabIndex = 26;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(1100, 773);
            this.lblPages.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(96, 32);
            this.lblPages.TabIndex = 27;
            this.lblPages.Text = "Pages";
            // 
            // txtPages
            // 
            this.txtPages.Enabled = false;
            this.txtPages.Location = new System.Drawing.Point(1212, 764);
            this.txtPages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(217, 38);
            this.txtPages.TabIndex = 28;
            // 
            // lblCISBook
            // 
            this.lblCISBook.AutoSize = true;
            this.lblCISBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCISBook.Location = new System.Drawing.Point(153, 876);
            this.lblCISBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCISBook.Name = "lblCISBook";
            this.lblCISBook.Size = new System.Drawing.Size(162, 39);
            this.lblCISBook.TabIndex = 29;
            this.lblCISBook.Text = "CIS Book";
            // 
            // comboCISArea
            // 
            this.comboCISArea.Enabled = false;
            this.comboCISArea.FormattingEnabled = true;
            this.comboCISArea.Items.AddRange(new object[] {
            "Java101",
            "Introduction Python",
            "Data Structures 101",
            "Cyber Security",
            "Database Management",
            "Network Architecture"});
            this.comboCISArea.Location = new System.Drawing.Point(308, 933);
            this.comboCISArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboCISArea.Name = "comboCISArea";
            this.comboCISArea.Size = new System.Drawing.Size(226, 39);
            this.comboCISArea.TabIndex = 30;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Location = new System.Drawing.Point(174, 945);
            this.lblCISArea.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(128, 32);
            this.lblCISArea.TabIndex = 31;
            this.lblCISArea.Text = "CIS Area";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVD.Location = new System.Drawing.Point(153, 1049);
            this.lblDVD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(90, 39);
            this.lblDVD.TabIndex = 32;
            this.lblDVD.Text = "DVD";
            // 
            // lblLeadActor
            // 
            this.lblLeadActor.AutoSize = true;
            this.lblLeadActor.Location = new System.Drawing.Point(155, 1111);
            this.lblLeadActor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLeadActor.Name = "lblLeadActor";
            this.lblLeadActor.Size = new System.Drawing.Size(152, 32);
            this.lblLeadActor.TabIndex = 33;
            this.lblLeadActor.Text = "Lead Actor";
            // 
            // txtLeadActor
            // 
            this.txtLeadActor.Enabled = false;
            this.txtLeadActor.Location = new System.Drawing.Point(308, 1111);
            this.txtLeadActor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLeadActor.Name = "txtLeadActor";
            this.txtLeadActor.Size = new System.Drawing.Size(409, 38);
            this.txtLeadActor.TabIndex = 34;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(763, 1116);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(187, 32);
            this.lblReleaseDate.TabIndex = 35;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Enabled = false;
            this.txtReleaseDate.Location = new System.Drawing.Point(976, 1116);
            this.txtReleaseDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(217, 38);
            this.txtReleaseDate.TabIndex = 36;
            // 
            // txtRunTime
            // 
            this.txtRunTime.Enabled = false;
            this.txtRunTime.Location = new System.Drawing.Point(1467, 1111);
            this.txtRunTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.Size = new System.Drawing.Size(217, 38);
            this.txtRunTime.TabIndex = 38;
            // 
            // lblCDClassical
            // 
            this.lblCDClassical.AutoSize = true;
            this.lblCDClassical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDClassical.Location = new System.Drawing.Point(153, 1198);
            this.lblCDClassical.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCDClassical.Name = "lblCDClassical";
            this.lblCDClassical.Size = new System.Drawing.Size(214, 39);
            this.lblCDClassical.TabIndex = 39;
            this.lblCDClassical.Text = "CD Classical";
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(174, 1274);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(86, 32);
            this.txtLabel.TabIndex = 40;
            this.txtLabel.Text = "Label";
            // 
            // txtCDLabel
            // 
            this.txtCDLabel.Enabled = false;
            this.txtCDLabel.Location = new System.Drawing.Point(308, 1269);
            this.txtCDLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCDLabel.Name = "txtCDLabel";
            this.txtCDLabel.Size = new System.Drawing.Size(217, 38);
            this.txtCDLabel.TabIndex = 41;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(642, 1279);
            this.lblArtists.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(94, 32);
            this.lblArtists.TabIndex = 42;
            this.lblArtists.Text = "Artists";
            // 
            // txtArtists
            // 
            this.txtArtists.Enabled = false;
            this.txtArtists.Location = new System.Drawing.Point(784, 1274);
            this.txtArtists.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(409, 38);
            this.txtArtists.TabIndex = 43;
            // 
            // lblCDOrchestraMusic
            // 
            this.lblCDOrchestraMusic.AutoSize = true;
            this.lblCDOrchestraMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDOrchestraMusic.Location = new System.Drawing.Point(153, 1389);
            this.lblCDOrchestraMusic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCDOrchestraMusic.Name = "lblCDOrchestraMusic";
            this.lblCDOrchestraMusic.Size = new System.Drawing.Size(322, 39);
            this.lblCDOrchestraMusic.TabIndex = 44;
            this.lblCDOrchestraMusic.Text = "CD Orchestra Music";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(162, 1463);
            this.lblConductor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(146, 32);
            this.lblConductor.TabIndex = 45;
            this.lblConductor.Text = "Conductor";
            // 
            // txtConductor
            // 
            this.txtConductor.Enabled = false;
            this.txtConductor.Location = new System.Drawing.Point(331, 1459);
            this.txtConductor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(409, 38);
            this.txtConductor.TabIndex = 46;
            // 
            // lblCDChamberMusic
            // 
            this.lblCDChamberMusic.AutoSize = true;
            this.lblCDChamberMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDChamberMusic.Location = new System.Drawing.Point(1026, 1389);
            this.lblCDChamberMusic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCDChamberMusic.Name = "lblCDChamberMusic";
            this.lblCDChamberMusic.Size = new System.Drawing.Size(314, 39);
            this.lblCDChamberMusic.TabIndex = 47;
            this.lblCDChamberMusic.Text = "CD Chamber Music\r\n";
            // 
            // lblInstruments
            // 
            this.lblInstruments.AutoSize = true;
            this.lblInstruments.Location = new System.Drawing.Point(1028, 1459);
            this.lblInstruments.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInstruments.Name = "lblInstruments";
            this.lblInstruments.Size = new System.Drawing.Size(162, 32);
            this.lblInstruments.TabIndex = 48;
            this.lblInstruments.Text = "Instruments";
            // 
            // lblMoreInstructions
            // 
            this.lblMoreInstructions.AutoSize = true;
            this.lblMoreInstructions.Location = new System.Drawing.Point(155, 1555);
            this.lblMoreInstructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMoreInstructions.Name = "lblMoreInstructions";
            this.lblMoreInstructions.Size = new System.Drawing.Size(922, 128);
            this.lblMoreInstructions.TabIndex = 50;
            this.lblMoreInstructions.Text = "Form Controls for Data Processing\r\n\r\nThese operations require entry of an Product" +
    " UPC (see above) before\r\nthey can be executed. Press CLEAR FORM when operation i" +
    "s complete.\r\n";
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.Enabled = false;
            this.btnEnterUPC.ForeColor = System.Drawing.Color.Green;
            this.btnEnterUPC.Location = new System.Drawing.Point(162, 1736);
            this.btnEnterUPC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(434, 53);
            this.btnEnterUPC.TabIndex = 51;
            this.btnEnterUPC.Text = "Click HERE to enter a UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(743, 1736);
            this.btnFind.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(281, 57);
            this.btnFind.TabIndex = 52;
            this.btnFind.Text = "Find/Display\r\n\r\n";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1092, 1731);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(281, 62);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit/Update\r\n";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1429, 1731);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(281, 62);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save Updates\r\n";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1780, 1731);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(281, 62);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete\r\n";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Location = new System.Drawing.Point(1264, 1116);
            this.lblRunTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(137, 32);
            this.lblRunTime.TabIndex = 56;
            this.lblRunTime.Text = "Run Time\r\n";
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.Location = new System.Drawing.Point(1732, 344);
            this.btnCreateCDChamber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(357, 70);
            this.btnCreateCDChamber.TabIndex = 58;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            this.btnCreateCDChamber.Click += new System.EventHandler(this.btnCreateCDChamber_Click);
            // 
            // txtInstruments
            // 
            this.txtInstruments.Enabled = false;
            this.txtInstruments.Location = new System.Drawing.Point(1200, 1452);
            this.txtInstruments.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(409, 38);
            this.txtInstruments.TabIndex = 59;
            // 
            // frmBookCDDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2260, 1604);
            this.Controls.Add(this.txtInstruments);
            this.Controls.Add(this.btnCreateCDChamber);
            this.Controls.Add(this.lblRunTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnEnterUPC);
            this.Controls.Add(this.lblMoreInstructions);
            this.Controls.Add(this.lblInstruments);
            this.Controls.Add(this.lblCDChamberMusic);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblCDOrchestraMusic);
            this.Controls.Add(this.txtArtists);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.txtCDLabel);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.lblCDClassical);
            this.Controls.Add(this.txtRunTime);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.txtLeadActor);
            this.Controls.Add(this.lblLeadActor);
            this.Controls.Add(this.lblDVD);
            this.Controls.Add(this.lblCISArea);
            this.Controls.Add(this.comboCISArea);
            this.Controls.Add(this.lblCISBook);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.txtISBNRight);
            this.Controls.Add(this.lblHyphen);
            this.Controls.Add(this.txtISBNLeft);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblProductTitle);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.lblUPC);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnCreateCDOrc);
            this.Controls.Add(this.btnCreateDVD);
            this.Controls.Add(this.btnCreateCISBook);
            this.Controls.Add(this.btnCreateBook);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmBookCDDVD";
            this.Text = "BookCDDVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblHyphen;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblCISBook;
        private System.Windows.Forms.Label lblCISArea;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblLeadActor;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblCDClassical;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblCDOrchestraMusic;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblCDChamberMusic;
        private System.Windows.Forms.Label lblInstruments;
        private System.Windows.Forms.Label lblMoreInstructions;
        public System.Windows.Forms.TextBox txtUPC;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtISBNLeft;
        public System.Windows.Forms.TextBox txtISBNRight;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtPages;
        public System.Windows.Forms.ComboBox comboCISArea;
        public System.Windows.Forms.TextBox txtLeadActor;
        public System.Windows.Forms.TextBox txtReleaseDate;
        public System.Windows.Forms.TextBox txtRunTime;
        public System.Windows.Forms.TextBox txtCDLabel;
        public System.Windows.Forms.TextBox txtArtists;
        public System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnClearForm;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnEnterUPC;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnCreateBook;
        public System.Windows.Forms.Button btnCreateCISBook;
        public System.Windows.Forms.Button btnCreateDVD;
        public System.Windows.Forms.Button btnCreateCDOrc;
        public System.Windows.Forms.Button btnCreateCDChamber;
        public System.Windows.Forms.TextBox txtInstruments;
    }
}