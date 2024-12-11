using MarvelFilmek.MovieModels;
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
    public partial class GridView : UserControl
    {
        MarvelContext ctx = new();

        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            var data = (from hero in ctx.Characters
                        join connection in ctx.Appearances on hero.CharacterId equals connection.CharacterId
                        join movie in ctx.Movies on connection.MovieId equals movie.MovieId
                        group new { hero.Alias, hero.Name, movie.BoxOfficeInMillions } by new { hero.Alias, hero.Name } into heroGroup
                        orderby heroGroup.Sum(x => x.BoxOfficeInMillions) descending
                        select new heroRevenue
                        {
                            Hero = heroGroup.Key.Name,
                            TotalRevenue = heroGroup.Sum(x => x.BoxOfficeInMillions),
                            Name = heroGroup.Key.Alias
                        }).ToList();

            heroRevenueBindingSource.DataSource = data;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (heroRevenueBindingSource.Current != null)
            {
                var selected = heroRevenueBindingSource.Current as heroRevenue;
                textBox1.Text = selected.Name;
            }
        }

    }
}
