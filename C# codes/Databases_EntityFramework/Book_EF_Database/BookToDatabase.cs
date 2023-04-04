using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksToDatabase.Model;

namespace BooksToDatabase
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            BindBooks();
        }

        public void BindBooks()
        {
            BookDbContext _db = new BookDbContext();

            lst_books.DataSource = _db.Books.ToList();
            lst_books.ValueMember = "Id";
            lst_books.DisplayMember = "Title";

            lbl_bookCount.Text = _db.Books.Count(b => b.Year > 1950).ToString();
        }
        private void btn_createBook_Click(object sender, EventArgs e)
        {
            Book mybook = new Book();
            mybook.Title = txt_title.Text;
            mybook.Year = int.Parse(txt_year.Text);

            BookDbContext _db = new BookDbContext();
            _db.Books.Add(mybook);

            _db.SaveChanges();

            BindBooks();
        }
    }
}
