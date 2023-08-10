using CartrigeAltstar.Model;
using CartrigeAltstar.Nomenclatura.Article;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CartrigeAltstar
{
    public partial class ListArticleForm : Form
    {
        ContexAltstarContext db;
        public ListArticleForm()
        {

            InitializeComponent();
            db = new ContexAltstarContext();
            db.Articles.Load();
        }


        private void ListArticleForm_Load(object sender, EventArgs e) => PrintArticle();


        public void PrintArticle()
        {

            var data = db.Articles.Local.ToBindingList();
            dataGridViewListArticle.DataSource = data;
            dataGridViewListArticle.Columns[0].Width = 15;
            dataGridViewListArticle.Columns[1].Width = 25;
            //dataGridViewListArticle.Columns["Name"].Visible

            dataGridViewListArticle.Columns["Cartriges"].Visible = false;
            //dataGridViewListPrinter.Columns["CartrigePK"].Visible = false;
            //dataGridViewListPrinter.Columns["SubdivisioPK"].Visible = false;


        }



        private void btn_add_article_Click(object sender, EventArgs e)
        {
            AddArticle articleDiagForm = new AddArticle();
            DialogResult result = articleDiagForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;


            Article articleModel = new Article();
            articleModel.Name = articleDiagForm.textBoxArticle.Text;
            db.Articles.Add(articleModel);
            db.SaveChanges();
        }

        private void btn_del_article_Click(object sender, EventArgs e)
        {


            if (dataGridViewListArticle.SelectedRows.Count > 0)
            {
                int index = dataGridViewListArticle.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dataGridViewListArticle[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;




                Article articleModel = db.Articles.Find(id);
                db.Articles.Remove(articleModel);
                db.SaveChanges();
                MessageBox.Show("Артикль Удаленн!!! ");
                dataGridViewListArticle.Refresh();
            }

        }

        private void btn_update_article_Click(object sender, EventArgs e)
        {
            if (dataGridViewListArticle.SelectedRows.Count > 0)
            {

                int index = dataGridViewListArticle.SelectedRows[0].Index;
                int id = 0;
                bool converted = int.TryParse(dataGridViewListArticle[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                AddArticle articleDiagForm = new AddArticle();
                Article articleModel = db.Articles.Find(id);
                articleDiagForm.textBoxArticle.Text = articleModel.Name;

                DialogResult result = articleDiagForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;


                articleModel.Name = articleDiagForm.textBoxArticle.Text;

                db.Entry(articleModel).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Артикль Обновлен!! ");

                dataGridViewListArticle.Refresh();


            }

        }
    }
}
