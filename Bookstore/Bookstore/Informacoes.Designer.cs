namespace Bookstore
{
    partial class Informacoes
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
            this.picbImage = new System.Windows.Forms.PictureBox();
            this.lblNameH = new System.Windows.Forms.Label();
            this.lblISBNH = new System.Windows.Forms.Label();
            this.lblAuthorH = new System.Windows.Forms.Label();
            this.lblPublisherH = new System.Windows.Forms.Label();
            this.lblSynopsisH = new System.Windows.Forms.Label();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateH = new System.Windows.Forms.Label();
            this.lblIDH = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picbImage
            // 
            this.picbImage.Location = new System.Drawing.Point(12, 32);
            this.picbImage.Name = "picbImage";
            this.picbImage.Size = new System.Drawing.Size(240, 350);
            this.picbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbImage.TabIndex = 0;
            this.picbImage.TabStop = false;
            // 
            // lblNameH
            // 
            this.lblNameH.AutoSize = true;
            this.lblNameH.Location = new System.Drawing.Point(259, 13);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(40, 15);
            this.lblNameH.TabIndex = 1;
            this.lblNameH.Text = "Título:";
            // 
            // lblISBNH
            // 
            this.lblISBNH.AutoSize = true;
            this.lblISBNH.Location = new System.Drawing.Point(259, 66);
            this.lblISBNH.Name = "lblISBNH";
            this.lblISBNH.Size = new System.Drawing.Size(35, 15);
            this.lblISBNH.TabIndex = 1;
            this.lblISBNH.Text = "ISBN:";
            // 
            // lblAuthorH
            // 
            this.lblAuthorH.AutoSize = true;
            this.lblAuthorH.Location = new System.Drawing.Point(259, 177);
            this.lblAuthorH.Name = "lblAuthorH";
            this.lblAuthorH.Size = new System.Drawing.Size(40, 15);
            this.lblAuthorH.TabIndex = 1;
            this.lblAuthorH.Text = "Autor:";
            // 
            // lblPublisherH
            // 
            this.lblPublisherH.AutoSize = true;
            this.lblPublisherH.Location = new System.Drawing.Point(259, 121);
            this.lblPublisherH.Name = "lblPublisherH";
            this.lblPublisherH.Size = new System.Drawing.Size(47, 15);
            this.lblPublisherH.TabIndex = 1;
            this.lblPublisherH.Text = "Editora:";
            // 
            // lblSynopsisH
            // 
            this.lblSynopsisH.AutoSize = true;
            this.lblSynopsisH.Location = new System.Drawing.Point(259, 239);
            this.lblSynopsisH.Name = "lblSynopsisH";
            this.lblSynopsisH.Size = new System.Drawing.Size(51, 15);
            this.lblSynopsisH.TabIndex = 3;
            this.lblSynopsisH.Text = "Sinópse:";
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(259, 258);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(338, 153);
            this.txtSynopsis.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(465, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(132, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // lblDateH
            // 
            this.lblDateH.AutoSize = true;
            this.lblDateH.Location = new System.Drawing.Point(465, 13);
            this.lblDateH.Name = "lblDateH";
            this.lblDateH.Size = new System.Drawing.Size(111, 15);
            this.lblDateH.TabIndex = 6;
            this.lblDateH.Text = "Data de publicação:";
            // 
            // lblIDH
            // 
            this.lblIDH.AutoSize = true;
            this.lblIDH.Location = new System.Drawing.Point(12, 9);
            this.lblIDH.Name = "lblIDH";
            this.lblIDH.Size = new System.Drawing.Size(20, 15);
            this.lblIDH.TabIndex = 7;
            this.lblIDH.Text = "Id:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 15);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "label1";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(465, 77);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(132, 23);
            this.btnRemoveBook.TabIndex = 9;
            this.btnRemoveBook.Text = "Remover Livro";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(465, 107);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(132, 23);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = "Salvar novos dados";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(12, 389);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(240, 23);
            this.btnImage.TabIndex = 11;
            this.btnImage.Text = "Enviar nova imagem";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(259, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(174, 23);
            this.txtTitle.TabIndex = 12;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(259, 85);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(174, 23);
            this.txtISBN.TabIndex = 13;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(259, 140);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(174, 23);
            this.txtPublisher.TabIndex = 14;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(259, 196);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(174, 23);
            this.txtAuthor.TabIndex = 15;
            // 
            // Informacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 423);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblIDH);
            this.Controls.Add(this.lblDateH);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.lblSynopsisH);
            this.Controls.Add(this.lblPublisherH);
            this.Controls.Add(this.lblAuthorH);
            this.Controls.Add(this.lblISBNH);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.picbImage);
            this.Name = "Informacoes";
            this.Text = "Informacoes";
            ((System.ComponentModel.ISupportInitialize)(this.picbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbImage;
        private System.Windows.Forms.Label lblNameH;
        private System.Windows.Forms.Label lblISBNH;
        private System.Windows.Forms.Label lblAuthorH;
        private System.Windows.Forms.Label lblPublisherH;
        private System.Windows.Forms.Label lblSynopsisH;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateH;
        private System.Windows.Forms.Label lblIDH;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
    }
}