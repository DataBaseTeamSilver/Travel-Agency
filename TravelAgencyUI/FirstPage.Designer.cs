namespace TravelAgencyUI
{
    public partial class FirstPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button excelZipButton;
        private System.Windows.Forms.Button exportFromMngoDbButton;
        private System.Windows.Forms.Button exportFromSqlServerButton;
        private System.Windows.Forms.Button exportXmlFileButton;
        private System.Windows.Forms.Label loadDataLabel;
        private System.Windows.Forms.Button readFromMySqlAndSqliteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button importFromExcelToSqlButton;
        private System.Windows.Forms.Button importFromSqlToPdfButton;
        private System.Windows.Forms.Button importFromSqlToXmlButton;
        private System.Windows.Forms.Button importFromSqlToJsonButton;
        private System.Windows.Forms.Button loadFromXmlToMongoDbButton;
        private System.Windows.Forms.Button importToExcelButton;
        private System.Windows.Forms.Button importFormXmlToSqlButton;
        private System.Windows.Forms.Button addExcursionsButton;
        private System.Windows.Forms.Button add1000randomExcursionsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importFromMongoDbToSqlButton;
        private System.Windows.Forms.ComboBox destinationsComboBox;
        private System.Windows.Forms.ComboBox guidesComboBox;
        private System.Windows.Forms.ComboBox transportsComboBox;
        private System.Windows.Forms.Button backButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.excelZipButton = new System.Windows.Forms.Button();
            this.exportFromMngoDbButton = new System.Windows.Forms.Button();
            this.exportFromSqlServerButton = new System.Windows.Forms.Button();
            this.exportXmlFileButton = new System.Windows.Forms.Button();
            this.loadDataLabel = new System.Windows.Forms.Label();
            this.readFromMySqlAndSqliteButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.importFromExcelToSqlButton = new System.Windows.Forms.Button();
            this.importFromSqlToPdfButton = new System.Windows.Forms.Button();
            this.importFromSqlToXmlButton = new System.Windows.Forms.Button();
            this.importFromSqlToJsonButton = new System.Windows.Forms.Button();
            this.loadFromXmlToMongoDbButton = new System.Windows.Forms.Button();
            this.importToExcelButton = new System.Windows.Forms.Button();
            this.importFormXmlToSqlButton = new System.Windows.Forms.Button();
            this.addExcursionsButton = new System.Windows.Forms.Button();
            this.add1000randomExcursionsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importFromMongoDbToSqlButton = new System.Windows.Forms.Button();
            this.destinationsComboBox = new System.Windows.Forms.ComboBox();
            this.guidesComboBox = new System.Windows.Forms.ComboBox();
            this.transportsComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excelZipButton
            // 
            this.excelZipButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excelZipButton.BackgroundImage")));
            this.excelZipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excelZipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelZipButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excelZipButton.FlatAppearance.BorderSize = 0;
            this.excelZipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelZipButton.ForeColor = System.Drawing.Color.Transparent;
            this.excelZipButton.Location = new System.Drawing.Point(30, 86);
            this.excelZipButton.Name = "excelZipButton";
            this.excelZipButton.Size = new System.Drawing.Size(161, 180);
            this.excelZipButton.TabIndex = 1;
            this.excelZipButton.UseVisualStyleBackColor = true;
            this.excelZipButton.Click += new System.EventHandler(this.ReadExcelFromZip);
            // 
            // exportFromMngoDbButton
            // 
            this.exportFromMngoDbButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportFromMngoDbButton.BackgroundImage")));
            this.exportFromMngoDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportFromMngoDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportFromMngoDbButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportFromMngoDbButton.Location = new System.Drawing.Point(438, 93);
            this.exportFromMngoDbButton.Name = "exportFromMngoDbButton";
            this.exportFromMngoDbButton.Size = new System.Drawing.Size(140, 137);
            this.exportFromMngoDbButton.TabIndex = 2;
            this.exportFromMngoDbButton.UseVisualStyleBackColor = true;
            this.exportFromMngoDbButton.Click += new System.EventHandler(this.ReadFromMongoDb);
            // 
            // exportFromSqlServerButton
            // 
            this.exportFromSqlServerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportFromSqlServerButton.BackgroundImage")));
            this.exportFromSqlServerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportFromSqlServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportFromSqlServerButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportFromSqlServerButton.Location = new System.Drawing.Point(666, 96);
            this.exportFromSqlServerButton.Name = "exportFromSqlServerButton";
            this.exportFromSqlServerButton.Size = new System.Drawing.Size(143, 144);
            this.exportFromSqlServerButton.TabIndex = 4;
            this.exportFromSqlServerButton.UseVisualStyleBackColor = true;
            this.exportFromSqlServerButton.Click += new System.EventHandler(this.ReadFromSQL);
            // 
            // exportXmlFileButton
            // 
            this.exportXmlFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportXmlFileButton.BackgroundImage")));
            this.exportXmlFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportXmlFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportXmlFileButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportXmlFileButton.Location = new System.Drawing.Point(247, 106);
            this.exportXmlFileButton.Name = "exportXmlFileButton";
            this.exportXmlFileButton.Size = new System.Drawing.Size(128, 124);
            this.exportXmlFileButton.TabIndex = 5;
            this.exportXmlFileButton.UseVisualStyleBackColor = true;
            this.exportXmlFileButton.Click += new System.EventHandler(this.ReadFromXML);
            // 
            // loadDataLabel
            // 
            this.loadDataLabel.AutoSize = true;
            this.loadDataLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataLabel.Location = new System.Drawing.Point(338, 20);
            this.loadDataLabel.Name = "loadDataLabel";
            this.loadDataLabel.Size = new System.Drawing.Size(181, 22);
            this.loadDataLabel.TabIndex = 7;
            this.loadDataLabel.Text = "LOAD DATA FROM:";
            // 
            // readFromMySqlAndSqliteButton
            // 
            this.readFromMySqlAndSqliteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("readFromMySqlAndSqliteButton.BackgroundImage")));
            this.readFromMySqlAndSqliteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readFromMySqlAndSqliteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFromMySqlAndSqliteButton.ForeColor = System.Drawing.Color.Transparent;
            this.readFromMySqlAndSqliteButton.Location = new System.Drawing.Point(320, 286);
            this.readFromMySqlAndSqliteButton.Name = "readFromMySqlAndSqliteButton";
            this.readFromMySqlAndSqliteButton.Size = new System.Drawing.Size(249, 126);
            this.readFromMySqlAndSqliteButton.TabIndex = 8;
            this.readFromMySqlAndSqliteButton.UseVisualStyleBackColor = true;
            this.readFromMySqlAndSqliteButton.Click += new System.EventHandler(this.ReadFromMySqlAndSQLite);
            // 
            // importFromExcelToSqlButton
            // 
            this.importFromExcelToSqlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFromExcelToSqlButton.BackgroundImage")));
            this.importFromExcelToSqlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFromExcelToSqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromExcelToSqlButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFromExcelToSqlButton.Location = new System.Drawing.Point(68, 98);
            this.importFromExcelToSqlButton.Name = "importFromExcelToSqlButton";
            this.importFromExcelToSqlButton.Size = new System.Drawing.Size(149, 148);
            this.importFromExcelToSqlButton.TabIndex = 10;
            this.importFromExcelToSqlButton.UseVisualStyleBackColor = true;
            this.importFromExcelToSqlButton.Visible = false;
            this.importFromExcelToSqlButton.Click += new System.EventHandler(this.ImportExcelDataToSql);
            // 
            // importFromSqlToPdfButton
            // 
            this.importFromSqlToPdfButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFromSqlToPdfButton.BackgroundImage")));
            this.importFromSqlToPdfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFromSqlToPdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromSqlToPdfButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFromSqlToPdfButton.Location = new System.Drawing.Point(68, 101);
            this.importFromSqlToPdfButton.Name = "importFromSqlToPdfButton";
            this.importFromSqlToPdfButton.Size = new System.Drawing.Size(123, 120);
            this.importFromSqlToPdfButton.TabIndex = 11;
            this.importFromSqlToPdfButton.UseVisualStyleBackColor = true;
            this.importFromSqlToPdfButton.Visible = false;
            this.importFromSqlToPdfButton.Click += new System.EventHandler(this.ImportFromSqlToPdf);
            // 
            // importFromSqlToXmlButton
            // 
            this.importFromSqlToXmlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFromSqlToXmlButton.BackgroundImage")));
            this.importFromSqlToXmlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFromSqlToXmlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromSqlToXmlButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFromSqlToXmlButton.Location = new System.Drawing.Point(451, 108);
            this.importFromSqlToXmlButton.Name = "importFromSqlToXmlButton";
            this.importFromSqlToXmlButton.Size = new System.Drawing.Size(127, 123);
            this.importFromSqlToXmlButton.TabIndex = 12;
            this.importFromSqlToXmlButton.UseVisualStyleBackColor = true;
            this.importFromSqlToXmlButton.Visible = false;
            this.importFromSqlToXmlButton.Click += new System.EventHandler(this.ImportFromSqlToXml);
            // 
            // importFromSqlToJsonButton
            // 
            this.importFromSqlToJsonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFromSqlToJsonButton.BackgroundImage")));
            this.importFromSqlToJsonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFromSqlToJsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromSqlToJsonButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFromSqlToJsonButton.Location = new System.Drawing.Point(253, 108);
            this.importFromSqlToJsonButton.Name = "importFromSqlToJsonButton";
            this.importFromSqlToJsonButton.Size = new System.Drawing.Size(136, 130);
            this.importFromSqlToJsonButton.TabIndex = 13;
            this.importFromSqlToJsonButton.UseVisualStyleBackColor = true;
            this.importFromSqlToJsonButton.Visible = false;
            this.importFromSqlToJsonButton.Click += new System.EventHandler(this.ImportFromSqlToJson);
            // 
            // loadFromXmlToMongoDbButton
            // 
            this.loadFromXmlToMongoDbButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadFromXmlToMongoDbButton.BackgroundImage")));
            this.loadFromXmlToMongoDbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadFromXmlToMongoDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromXmlToMongoDbButton.ForeColor = System.Drawing.Color.Transparent;
            this.loadFromXmlToMongoDbButton.Location = new System.Drawing.Point(253, 101);
            this.loadFromXmlToMongoDbButton.Name = "loadFromXmlToMongoDbButton";
            this.loadFromXmlToMongoDbButton.Size = new System.Drawing.Size(142, 141);
            this.loadFromXmlToMongoDbButton.TabIndex = 14;
            this.loadFromXmlToMongoDbButton.UseVisualStyleBackColor = true;
            this.loadFromXmlToMongoDbButton.Visible = false;
            this.loadFromXmlToMongoDbButton.Click += new System.EventHandler(this.ImportFromXmlToMongo);
            // 
            // ImportToExcelButton
            // 
            this.importToExcelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportToExcelButton.BackgroundImage")));
            this.importToExcelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importToExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importToExcelButton.ForeColor = System.Drawing.Color.Transparent;
            this.importToExcelButton.Location = new System.Drawing.Point(68, 83);
            this.importToExcelButton.Name = "ImportToExcelButton";
            this.importToExcelButton.Size = new System.Drawing.Size(125, 138);
            this.importToExcelButton.TabIndex = 15;
            this.importToExcelButton.UseVisualStyleBackColor = true;
            this.importToExcelButton.Visible = false;
            this.importToExcelButton.Click += new System.EventHandler(this.ImportFromMySqlAndSqliteToExcel);
            // 
            // importFormXmlToSqlButton
            // 
            this.importFormXmlToSqlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFormXmlToSqlButton.BackgroundImage")));
            this.importFormXmlToSqlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormXmlToSqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFormXmlToSqlButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFormXmlToSqlButton.Location = new System.Drawing.Point(68, 97);
            this.importFormXmlToSqlButton.Name = "importFormXmlToSqlButton";
            this.importFormXmlToSqlButton.Size = new System.Drawing.Size(135, 142);
            this.importFormXmlToSqlButton.TabIndex = 16;
            this.importFormXmlToSqlButton.UseVisualStyleBackColor = true;
            this.importFormXmlToSqlButton.Visible = false;
            this.importFormXmlToSqlButton.Click += new System.EventHandler(this.ImportFromXmlToSql);
            // 
            // addExcursionsButton
            // 
            this.addExcursionsButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExcursionsButton.Location = new System.Drawing.Point(156, 433);
            this.addExcursionsButton.Name = "addExcursionsButton";
            this.addExcursionsButton.Size = new System.Drawing.Size(162, 44);
            this.addExcursionsButton.TabIndex = 17;
            this.addExcursionsButton.Text = "Add sample data";
            this.addExcursionsButton.UseVisualStyleBackColor = true;
            this.addExcursionsButton.Click += new System.EventHandler(this.AddExcursions);
            // 
            // add1000randomExcursionsButton
            // 
            this.add1000randomExcursionsButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1000randomExcursionsButton.Location = new System.Drawing.Point(474, 433);
            this.add1000randomExcursionsButton.Name = "add1000randomExcursionsButton";
            this.add1000randomExcursionsButton.Size = new System.Drawing.Size(278, 44);
            this.add1000randomExcursionsButton.TabIndex = 18;
            this.add1000randomExcursionsButton.Text = "Add 1000 random excursions";
            this.add1000randomExcursionsButton.UseVisualStyleBackColor = true;
            this.add1000randomExcursionsButton.Click += new System.EventHandler(this.Add1000RandomExcursions);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "IMPORT DATA TO:";
            this.label1.Visible = false;
            // 
            // importFromMongoDbToSqlButton
            // 
            this.importFromMongoDbToSqlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importFromMongoDbToSqlButton.BackgroundImage")));
            this.importFromMongoDbToSqlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFromMongoDbToSqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromMongoDbToSqlButton.ForeColor = System.Drawing.Color.Transparent;
            this.importFromMongoDbToSqlButton.Location = new System.Drawing.Point(68, 96);
            this.importFromMongoDbToSqlButton.Name = "importFromMongoDbToSqlButton";
            this.importFromMongoDbToSqlButton.Size = new System.Drawing.Size(138, 150);
            this.importFromMongoDbToSqlButton.TabIndex = 20;
            this.importFromMongoDbToSqlButton.UseVisualStyleBackColor = true;
            this.importFromMongoDbToSqlButton.Visible = false;
            this.importFromMongoDbToSqlButton.Click += new System.EventHandler(this.ImportFromMongoToSQL);
            // 
            // destinationsComboBox
            // 
            this.destinationsComboBox.FormattingEnabled = true;
            this.destinationsComboBox.Location = new System.Drawing.Point(572, 119);
            this.destinationsComboBox.Name = "destinationsComboBox";
            this.destinationsComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationsComboBox.TabIndex = 21;
            this.destinationsComboBox.Visible = false;
            // 
            // guidesComboBox
            // 
            this.guidesComboBox.FormattingEnabled = true;
            this.guidesComboBox.Location = new System.Drawing.Point(572, 162);
            this.guidesComboBox.Name = "guidesComboBox";
            this.guidesComboBox.Size = new System.Drawing.Size(121, 21);
            this.guidesComboBox.TabIndex = 22;
            this.guidesComboBox.Visible = false;
            // 
            // transportsComboBox
            // 
            this.transportsComboBox.FormattingEnabled = true;
            this.transportsComboBox.Location = new System.Drawing.Point(572, 200);
            this.transportsComboBox.Name = "transportsComboBox";
            this.transportsComboBox.Size = new System.Drawing.Size(121, 21);
            this.transportsComboBox.TabIndex = 23;
            this.transportsComboBox.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(30, 319);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 38);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 509);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transportsComboBox);
            this.Controls.Add(this.guidesComboBox);
            this.Controls.Add(this.destinationsComboBox);
            this.Controls.Add(this.importFromMongoDbToSqlButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add1000randomExcursionsButton);
            this.Controls.Add(this.addExcursionsButton);
            this.Controls.Add(this.importFormXmlToSqlButton);
            this.Controls.Add(this.importToExcelButton);
            this.Controls.Add(this.loadFromXmlToMongoDbButton);
            this.Controls.Add(this.importFromSqlToJsonButton);
            this.Controls.Add(this.importFromSqlToXmlButton);
            this.Controls.Add(this.importFromSqlToPdfButton);
            this.Controls.Add(this.importFromExcelToSqlButton);
            this.Controls.Add(this.readFromMySqlAndSqliteButton);
            this.Controls.Add(this.loadDataLabel);
            this.Controls.Add(this.exportXmlFileButton);
            this.Controls.Add(this.exportFromSqlServerButton);
            this.Controls.Add(this.exportFromMngoDbButton);
            this.Controls.Add(this.excelZipButton);
            this.Name = "FirstPage";
            this.Text = "FirstPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}