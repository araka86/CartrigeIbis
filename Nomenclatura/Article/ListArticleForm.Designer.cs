namespace CartrigeAltstar
{
    partial class ListArticleForm
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
            this.dataGridViewListArticle = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add_article = new System.Windows.Forms.Button();
            this.btn_del_article = new System.Windows.Forms.Button();
            this.btn_update_article = new System.Windows.Forms.Button();
            this.btn_export_article = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListArticle)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListArticle
            // 
            this.dataGridViewListArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListArticle.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListArticle.Name = "dataGridViewListArticle";
            this.dataGridViewListArticle.RowHeadersVisible = false;
            this.dataGridViewListArticle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListArticle.Size = new System.Drawing.Size(800, 419);
            this.dataGridViewListArticle.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_add_article);
            this.flowLayoutPanel1.Controls.Add(this.btn_del_article);
            this.flowLayoutPanel1.Controls.Add(this.btn_update_article);
            this.flowLayoutPanel1.Controls.Add(this.btn_export_article);
            this.flowLayoutPanel1.Controls.Add(this.btn_close);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 419);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 31);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // btn_add_article
            // 
            this.btn_add_article.Location = new System.Drawing.Point(3, 3);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(112, 23);
            this.btn_add_article.TabIndex = 25;
            this.btn_add_article.Text = "Добавить";
            this.btn_add_article.UseVisualStyleBackColor = true;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // btn_del_article
            // 
            this.btn_del_article.Location = new System.Drawing.Point(121, 3);
            this.btn_del_article.Name = "btn_del_article";
            this.btn_del_article.Size = new System.Drawing.Size(112, 23);
            this.btn_del_article.TabIndex = 26;
            this.btn_del_article.Text = "Удалить";
            this.btn_del_article.UseVisualStyleBackColor = true;
            this.btn_del_article.Click += new System.EventHandler(this.btn_del_article_Click);
            // 
            // btn_update_article
            // 
            this.btn_update_article.Location = new System.Drawing.Point(239, 3);
            this.btn_update_article.Name = "btn_update_article";
            this.btn_update_article.Size = new System.Drawing.Size(112, 23);
            this.btn_update_article.TabIndex = 27;
            this.btn_update_article.Text = "Обновить";
            this.btn_update_article.UseVisualStyleBackColor = true;
            this.btn_update_article.Click += new System.EventHandler(this.btn_update_article_Click);
            // 
            // btn_export_article
            // 
            this.btn_export_article.Location = new System.Drawing.Point(357, 3);
            this.btn_export_article.Name = "btn_export_article";
            this.btn_export_article.Size = new System.Drawing.Size(112, 23);
            this.btn_export_article.TabIndex = 47;
            this.btn_export_article.Text = "Export Exel";
            this.btn_export_article.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(475, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 23);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ListArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListArticle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ListArticleForm";
            this.Text = "ListArticleForm";
            this.Load += new System.EventHandler(this.ListArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListArticle)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewListArticle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_add_article;
        private System.Windows.Forms.Button btn_del_article;
        private System.Windows.Forms.Button btn_update_article;
        public System.Windows.Forms.Button btn_export_article;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}