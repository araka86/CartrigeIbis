using CartrigeAltstar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartrigeAltstar
{
    public partial class DispatchConfig : Form
    {
        public DispatchConfig()
        {
            InitializeComponent();


        }



        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if (e.KeyChar == (char)Keys.Enter) // Обработка только по нажатию клавиши Enter
            //   {
            ContexAltstarContext db = new ContexAltstarContext();

            string searchText = tb_search.Text;



            if (!string.IsNullOrEmpty(searchText))
            {
                List<Article> articles = db.Articles
                    .Where(article => article.Name.StartsWith(searchText))
                    .ToList();

                if (articles.Any())
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(articles[0].Name.ToString());
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("None");

                }

            }


            //// }
        }









    }
}
