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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnCreateCISBook = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateCDOrc = new System.Windows.Forms.Button();
            this.btnCreateCDCham = new System.Windows.Forms.Button();
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
            this.txtRunTime = new System.Windows.Forms.Label();
            this.txtRTime = new System.Windows.Forms.TextBox();
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
            this.comboInstruments = new System.Windows.Forms.ComboBox();
            this.lblMoreInstructions = new System.Windows.Forms.Label();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(445, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Entry and Display for Book CD DVD Shop\r\n";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(226, 97);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(819, 20);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "To CREATE a new Book, CIS Book, DVD, Orchestra CD or Chamber CD always press a bu" +
    "tton below before typing\r\n";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Location = new System.Drawing.Point(98, 182);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(237, 20);
            this.lblControls.TabIndex = 2;
            this.lblControls.Text = "Controls for creating a new entry\r\n";
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(102, 222);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(158, 45);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // btnCreateCISBook
            // 
            this.btnCreateCISBook.Location = new System.Drawing.Point(321, 222);
            this.btnCreateCISBook.Name = "btnCreateCISBook";
            this.btnCreateCISBook.Size = new System.Drawing.Size(158, 45);
            this.btnCreateCISBook.TabIndex = 4;
            this.btnCreateCISBook.Text = "Create CIS Book";
            this.btnCreateCISBook.UseVisualStyleBackColor = true;
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(541, 222);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(158, 45);
            this.btnCreateDVD.TabIndex = 5;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            // 
            // btnCreateCDOrc
            // 
            this.btnCreateCDOrc.Location = new System.Drawing.Point(748, 222);
            this.btnCreateCDOrc.Name = "btnCreateCDOrc";
            this.btnCreateCDOrc.Size = new System.Drawing.Size(201, 45);
            this.btnCreateCDOrc.TabIndex = 6;
            this.btnCreateCDOrc.Text = "Create CD Orchestra\r\n";
            this.btnCreateCDOrc.UseVisualStyleBackColor = true;
            // 
            // btnCreateCDCham
            // 
            this.btnCreateCDCham.Location = new System.Drawing.Point(990, 222);
            this.btnCreateCDCham.Name = "btnCreateCDCham";
            this.btnCreateCDCham.Size = new System.Drawing.Size(192, 45);
            this.btnCreateCDCham.TabIndex = 7;
            this.btnCreateCDCham.Text = "Create CD Chamber";
            this.btnCreateCDCham.UseVisualStyleBackColor = true;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(98, 303);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(769, 20);
            this.lblDirections.TabIndex = 8;
            this.lblDirections.Text = "To Find/Search, Edit/Update or Delete. Enter Product UPC and Select appropriate c" +
    "ontrol at bottom of form.\r\n";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(86, 345);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(79, 25);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "Product";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(104, 394);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(42, 20);
            this.lblUPC.TabIndex = 10;
            this.lblUPC.Text = "UPC";
            // 
            // txtUPC
            // 
            this.txtUPC.Enabled = false;
            this.txtUPC.Location = new System.Drawing.Point(173, 391);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(124, 26);
            this.txtUPC.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(361, 394);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(433, 394);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(619, 400);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(38, 20);
            this.lblProductTitle.TabIndex = 14;
            this.lblProductTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(682, 394);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(124, 26);
            this.txtTitle.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(847, 397);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(944, 391);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(124, 26);
            this.txtQuantity.TabIndex = 17;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Enabled = false;
            this.btnClearForm.Location = new System.Drawing.Point(1147, 345);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(96, 77);
            this.btnClearForm.TabIndex = 18;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1147, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 77);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(86, 443);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(57, 25);
            this.lblBook.TabIndex = 20;
            this.lblBook.Text = "Book";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(99, 505);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 20);
            this.lblISBN.TabIndex = 21;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBNLeft
            // 
            this.txtISBNLeft.Enabled = false;
            this.txtISBNLeft.Location = new System.Drawing.Point(173, 499);
            this.txtISBNLeft.Name = "txtISBNLeft";
            this.txtISBNLeft.Size = new System.Drawing.Size(57, 26);
            this.txtISBNLeft.TabIndex = 22;
            // 
            // lblHyphen
            // 
            this.lblHyphen.AutoSize = true;
            this.lblHyphen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHyphen.Location = new System.Drawing.Point(240, 500);
            this.lblHyphen.Name = "lblHyphen";
            this.lblHyphen.Size = new System.Drawing.Size(20, 26);
            this.lblHyphen.TabIndex = 23;
            this.lblHyphen.Text = "-";
            // 
            // txtISBNRight
            // 
            this.txtISBNRight.Enabled = false;
            this.txtISBNRight.Location = new System.Drawing.Point(266, 500);
            this.txtISBNRight.Name = "txtISBNRight";
            this.txtISBNRight.Size = new System.Drawing.Size(57, 26);
            this.txtISBNRight.TabIndex = 24;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(361, 505);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(57, 20);
            this.Author.TabIndex = 25;
            this.Author.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(433, 500);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(124, 26);
            this.txtAuthor.TabIndex = 26;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(619, 499);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(54, 20);
            this.lblPages.TabIndex = 27;
            this.lblPages.Text = "Pages";
            // 
            // txtPages
            // 
            this.txtPages.Enabled = false;
            this.txtPages.Location = new System.Drawing.Point(682, 493);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(124, 26);
            this.txtPages.TabIndex = 28;
            // 
            // lblCISBook
            // 
            this.lblCISBook.AutoSize = true;
            this.lblCISBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCISBook.Location = new System.Drawing.Point(86, 565);
            this.lblCISBook.Name = "lblCISBook";
            this.lblCISBook.Size = new System.Drawing.Size(96, 25);
            this.lblCISBook.TabIndex = 29;
            this.lblCISBook.Text = "CIS Book";
            // 
            // comboCISArea
            // 
            this.comboCISArea.Enabled = false;
            this.comboCISArea.FormattingEnabled = true;
            this.comboCISArea.Items.AddRange(new object[] {
            "Java101"});
            this.comboCISArea.Location = new System.Drawing.Point(173, 602);
            this.comboCISArea.Name = "comboCISArea";
            this.comboCISArea.Size = new System.Drawing.Size(129, 28);
            this.comboCISArea.TabIndex = 30;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Location = new System.Drawing.Point(98, 610);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(74, 20);
            this.lblCISArea.TabIndex = 31;
            this.lblCISArea.Text = "CIS Area";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVD.Location = new System.Drawing.Point(86, 677);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(54, 25);
            this.lblDVD.TabIndex = 32;
            this.lblDVD.Text = "DVD";
            // 
            // lblLeadActor
            // 
            this.lblLeadActor.AutoSize = true;
            this.lblLeadActor.Location = new System.Drawing.Point(87, 717);
            this.lblLeadActor.Name = "lblLeadActor";
            this.lblLeadActor.Size = new System.Drawing.Size(87, 20);
            this.lblLeadActor.TabIndex = 33;
            this.lblLeadActor.Text = "Lead Actor";
            // 
            // txtLeadActor
            // 
            this.txtLeadActor.Enabled = false;
            this.txtLeadActor.Location = new System.Drawing.Point(173, 717);
            this.txtLeadActor.Name = "txtLeadActor";
            this.txtLeadActor.Size = new System.Drawing.Size(232, 26);
            this.txtLeadActor.TabIndex = 34;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(429, 720);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(107, 20);
            this.lblReleaseDate.TabIndex = 35;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Enabled = false;
            this.txtReleaseDate.Location = new System.Drawing.Point(549, 720);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(124, 26);
            this.txtReleaseDate.TabIndex = 36;
            // 
            // txtRunTime
            // 
            this.txtRunTime.AutoSize = true;
            this.txtRunTime.Location = new System.Drawing.Point(711, 717);
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.Size = new System.Drawing.Size(77, 20);
            this.txtRunTime.TabIndex = 37;
            this.txtRunTime.Text = "Run Time";
            // 
            // txtRTime
            // 
            this.txtRTime.Enabled = false;
            this.txtRTime.Location = new System.Drawing.Point(794, 717);
            this.txtRTime.Name = "txtRTime";
            this.txtRTime.Size = new System.Drawing.Size(124, 26);
            this.txtRTime.TabIndex = 38;
            // 
            // lblCDClassical
            // 
            this.lblCDClassical.AutoSize = true;
            this.lblCDClassical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDClassical.Location = new System.Drawing.Point(86, 773);
            this.lblCDClassical.Name = "lblCDClassical";
            this.lblCDClassical.Size = new System.Drawing.Size(125, 25);
            this.lblCDClassical.TabIndex = 39;
            this.lblCDClassical.Text = "CD Classical";
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(98, 822);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(48, 20);
            this.txtLabel.TabIndex = 40;
            this.txtLabel.Text = "Label";
            // 
            // txtCDLabel
            // 
            this.txtCDLabel.Enabled = false;
            this.txtCDLabel.Location = new System.Drawing.Point(173, 819);
            this.txtCDLabel.Name = "txtCDLabel";
            this.txtCDLabel.Size = new System.Drawing.Size(124, 26);
            this.txtCDLabel.TabIndex = 41;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(361, 825);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(54, 20);
            this.lblArtists.TabIndex = 42;
            this.lblArtists.Text = "Artists";
            // 
            // txtArtists
            // 
            this.txtArtists.Enabled = false;
            this.txtArtists.Location = new System.Drawing.Point(441, 822);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(232, 26);
            this.txtArtists.TabIndex = 43;
            // 
            // lblCDOrchestraMusic
            // 
            this.lblCDOrchestraMusic.AutoSize = true;
            this.lblCDOrchestraMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDOrchestraMusic.Location = new System.Drawing.Point(86, 896);
            this.lblCDOrchestraMusic.Name = "lblCDOrchestraMusic";
            this.lblCDOrchestraMusic.Size = new System.Drawing.Size(189, 25);
            this.lblCDOrchestraMusic.TabIndex = 44;
            this.lblCDOrchestraMusic.Text = "CD Orchestra Music";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(91, 944);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(83, 20);
            this.lblConductor.TabIndex = 45;
            this.lblConductor.Text = "Conductor";
            // 
            // txtConductor
            // 
            this.txtConductor.Enabled = false;
            this.txtConductor.Location = new System.Drawing.Point(186, 941);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(232, 26);
            this.txtConductor.TabIndex = 46;
            // 
            // lblCDChamberMusic
            // 
            this.lblCDChamberMusic.AutoSize = true;
            this.lblCDChamberMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDChamberMusic.Location = new System.Drawing.Point(577, 896);
            this.lblCDChamberMusic.Name = "lblCDChamberMusic";
            this.lblCDChamberMusic.Size = new System.Drawing.Size(184, 25);
            this.lblCDChamberMusic.TabIndex = 47;
            this.lblCDChamberMusic.Text = "CD Chamber Music\r\n";
            // 
            // lblInstruments
            // 
            this.lblInstruments.AutoSize = true;
            this.lblInstruments.Location = new System.Drawing.Point(578, 941);
            this.lblInstruments.Name = "lblInstruments";
            this.lblInstruments.Size = new System.Drawing.Size(94, 20);
            this.lblInstruments.TabIndex = 48;
            this.lblInstruments.Text = "Instruments";
            // 
            // comboInstruments
            // 
            this.comboInstruments.Enabled = false;
            this.comboInstruments.FormattingEnabled = true;
            this.comboInstruments.Items.AddRange(new object[] {
            "Banjo",
            "Cello",
            "Violin",
            "Trumpet",
            "Flute",
            "Bass",
            "Drums",
            "Piano"});
            this.comboInstruments.Location = new System.Drawing.Point(715, 939);
            this.comboInstruments.Name = "comboInstruments";
            this.comboInstruments.Size = new System.Drawing.Size(129, 28);
            this.comboInstruments.TabIndex = 49;
            // 
            // lblMoreInstructions
            // 
            this.lblMoreInstructions.AutoSize = true;
            this.lblMoreInstructions.Location = new System.Drawing.Point(87, 1003);
            this.lblMoreInstructions.Name = "lblMoreInstructions";
            this.lblMoreInstructions.Size = new System.Drawing.Size(518, 80);
            this.lblMoreInstructions.TabIndex = 50;
            this.lblMoreInstructions.Text = "Form Controls for Data Processing\r\n\r\nThese operations require entry of an Product" +
    " UPC (see above) before\r\nthey can be executed. Press CLEAR FORM when operation i" +
    "s complete.\r\n";
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.Enabled = false;
            this.btnEnterUPC.ForeColor = System.Drawing.Color.Green;
            this.btnEnterUPC.Location = new System.Drawing.Point(91, 1120);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(244, 34);
            this.btnEnterUPC.TabIndex = 51;
            this.btnEnterUPC.Text = "Click HERE to enter a UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(418, 1120);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(158, 37);
            this.btnFind.TabIndex = 52;
            this.btnFind.Text = "Find/Display\r\n\r\n";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(614, 1117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 40);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit/Update\r\n";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(804, 1117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 40);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save Updates\r\n";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1001, 1117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 40);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete\r\n";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmBookCDDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 1208);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnEnterUPC);
            this.Controls.Add(this.lblMoreInstructions);
            this.Controls.Add(this.comboInstruments);
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
            this.Controls.Add(this.txtRTime);
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
            this.Controls.Add(this.btnCreateCDCham);
            this.Controls.Add(this.btnCreateCDOrc);
            this.Controls.Add(this.btnCreateDVD);
            this.Controls.Add(this.btnCreateCISBook);
            this.Controls.Add(this.btnCreateBook);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBookCDDVD";
            this.Text = "BookCDDVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Button btnCreateCISBook;
        private System.Windows.Forms.Button btnCreateDVD;
        private System.Windows.Forms.Button btnCreateCDOrc;
        private System.Windows.Forms.Button btnCreateCDCham;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBNLeft;
        private System.Windows.Forms.Label lblHyphen;
        private System.Windows.Forms.TextBox txtISBNRight;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblCISBook;
        private System.Windows.Forms.ComboBox comboCISArea;
        private System.Windows.Forms.Label lblCISArea;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblLeadActor;
        private System.Windows.Forms.TextBox txtLeadActor;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label txtRunTime;
        private System.Windows.Forms.TextBox txtRTime;
        private System.Windows.Forms.Label lblCDClassical;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.TextBox txtCDLabel;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label lblCDOrchestraMusic;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label lblCDChamberMusic;
        private System.Windows.Forms.Label lblInstruments;
        private System.Windows.Forms.ComboBox comboInstruments;
        private System.Windows.Forms.Label lblMoreInstructions;
        private System.Windows.Forms.Button btnEnterUPC;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtUPC;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtQuantity;
    }
}

