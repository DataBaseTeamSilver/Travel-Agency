﻿namespace TravelAgency.UI
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.xmlGenerate = new System.Windows.Forms.Button();
=======
            this.button2 = new System.Windows.Forms.Button();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search archive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchZip);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(212, 162);
            this.dataGridView1.TabIndex = 1;
            // 
<<<<<<< HEAD
            // xmlGenerate
            // 
            this.xmlGenerate.Location = new System.Drawing.Point(449, 238);
            this.xmlGenerate.Name = "xmlGenerate";
            this.xmlGenerate.Size = new System.Drawing.Size(75, 23);
            this.xmlGenerate.TabIndex = 2;
            this.xmlGenerate.Text = "xmlGenerate";
            this.xmlGenerate.UseVisualStyleBackColor = true;
=======
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> origin/master
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(567, 320);
            this.Controls.Add(this.xmlGenerate);
=======
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.button2);
>>>>>>> origin/master
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
<<<<<<< HEAD
        private System.Windows.Forms.Button xmlGenerate;
=======
        private System.Windows.Forms.Button button2;
>>>>>>> origin/master
    }
}