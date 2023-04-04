
namespace BooksToDatabase
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lst_books = new System.Windows.Forms.ListBox();
            this.btn_createBook = new System.Windows.Forms.Button();
            this.lbl_bookCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(106, 44);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(167, 27);
            this.txt_title.TabIndex = 0;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(106, 92);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(167, 27);
            this.txt_year.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(55, 47);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(45, 20);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title :";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(55, 95);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(48, 20);
            this.lbl_year.TabIndex = 3;
            this.lbl_year.Text = "Year : ";
            // 
            // lst_books
            // 
            this.lst_books.FormattingEnabled = true;
            this.lst_books.ItemHeight = 20;
            this.lst_books.Location = new System.Drawing.Point(310, 44);
            this.lst_books.Name = "lst_books";
            this.lst_books.Size = new System.Drawing.Size(197, 104);
            this.lst_books.TabIndex = 4;
            // 
            // btn_createBook
            // 
            this.btn_createBook.Location = new System.Drawing.Point(135, 159);
            this.btn_createBook.Name = "btn_createBook";
            this.btn_createBook.Size = new System.Drawing.Size(138, 29);
            this.btn_createBook.TabIndex = 5;
            this.btn_createBook.Text = "Create Book";
            this.btn_createBook.UseVisualStyleBackColor = true;
            this.btn_createBook.Click += new System.EventHandler(this.btn_createBook_Click);
            // 
            // lbl_bookCount
            // 
            this.lbl_bookCount.AutoSize = true;
            this.lbl_bookCount.Location = new System.Drawing.Point(310, 163);
            this.lbl_bookCount.Name = "lbl_bookCount";
            this.lbl_bookCount.Size = new System.Drawing.Size(238, 20);
            this.lbl_bookCount.TabIndex = 6;
            this.lbl_bookCount.Text = "Book Count will be displayed here.";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 315);
            this.Controls.Add(this.lbl_bookCount);
            this.Controls.Add(this.btn_createBook);
            this.Controls.Add(this.lst_books);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_title);
            this.Name = "Frm_Main";
            this.Text = "Book List Form";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.ListBox lst_books;
        private System.Windows.Forms.Button btn_createBook;
        private System.Windows.Forms.Label lbl_bookCount;
    }
}

