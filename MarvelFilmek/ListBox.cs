using MarvelFilmek.MovieModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelFilmek
{
    public partial class ListBox : UserControl
    {
        MarvelContext ctx = new();
        public ListBox()
        {
            InitializeComponent();
            ctx.Movies.Load();
            movieBindingSource.DataSource = ctx.Movies.Local.ToList();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = movieBindingSource;
        }

        private void textBoxDir_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void textBoxRat_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            var dir = textBoxDir.Text;
            int rate;
            bool isRateValid = int.TryParse(textBoxRat.Text, out rate);
            var data = (from x in ctx.Movies
                        where (string.IsNullOrEmpty(dir) || x.Director.Contains(dir)) &&
                       (!isRateValid || x.Rating >= rate)
                        select x).ToList();
            movieBindingSource.DataSource = data;
        }
    }
}
