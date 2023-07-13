namespace Componentes_aula2WF
{
    partial class F_ListView
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "0", "Mouse", "120", "19,99" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "Teclado", "25", "39,99" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "2", "Gabinete", "25", "199,99" }, -1);
            lv_Produtos = new ListView();
            col_Id = new ColumnHeader();
            col_produto = new ColumnHeader();
            col_qtd = new ColumnHeader();
            col_preco = new ColumnHeader();
            tb_Id = new TextBox();
            tb_produto = new TextBox();
            tb_qtd = new TextBox();
            tb_preco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_obter = new Button();
            btn_remover = new Button();
            btn_adicionar = new Button();
            SuspendLayout();
            // 
            // lv_Produtos
            // 
            lv_Produtos.Columns.AddRange(new ColumnHeader[] { col_Id, col_produto, col_qtd, col_preco });
            lv_Produtos.FullRowSelect = true;
            lv_Produtos.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lv_Produtos.Location = new Point(12, 31);
            lv_Produtos.MultiSelect = false;
            lv_Produtos.Name = "lv_Produtos";
            lv_Produtos.Size = new Size(776, 121);
            lv_Produtos.TabIndex = 0;
            lv_Produtos.UseCompatibleStateImageBehavior = false;
            lv_Produtos.View = View.Details;
            lv_Produtos.SelectedIndexChanged += lv_Produtos_SelectedIndexChanged;
            // 
            // col_Id
            // 
            col_Id.Text = "Id";
            col_Id.Width = 40;
            // 
            // col_produto
            // 
            col_produto.Text = "Produto";
            col_produto.Width = 250;
            // 
            // col_qtd
            // 
            col_qtd.Text = "Quantidade";
            col_qtd.TextAlign = HorizontalAlignment.Center;
            col_qtd.Width = 100;
            // 
            // col_preco
            // 
            col_preco.Text = "Preço";
            col_preco.Width = 120;
            // 
            // tb_Id
            // 
            tb_Id.BorderStyle = BorderStyle.FixedSingle;
            tb_Id.Location = new Point(26, 256);
            tb_Id.Name = "tb_Id";
            tb_Id.Size = new Size(79, 27);
            tb_Id.TabIndex = 1;
            // 
            // tb_produto
            // 
            tb_produto.BorderStyle = BorderStyle.FixedSingle;
            tb_produto.Location = new Point(127, 256);
            tb_produto.Name = "tb_produto";
            tb_produto.Size = new Size(168, 27);
            tb_produto.TabIndex = 2;
            // 
            // tb_qtd
            // 
            tb_qtd.BorderStyle = BorderStyle.FixedSingle;
            tb_qtd.Location = new Point(319, 256);
            tb_qtd.Name = "tb_qtd";
            tb_qtd.Size = new Size(81, 27);
            tb_qtd.TabIndex = 3;
            // 
            // tb_preco
            // 
            tb_preco.BorderStyle = BorderStyle.FixedSingle;
            tb_preco.Location = new Point(433, 256);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(125, 27);
            tb_preco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 213);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 213);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 213);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 213);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Preço";
            // 
            // btn_obter
            // 
            btn_obter.Location = new Point(26, 348);
            btn_obter.Name = "btn_obter";
            btn_obter.Size = new Size(133, 29);
            btn_obter.TabIndex = 9;
            btn_obter.Text = "Obter";
            btn_obter.UseVisualStyleBackColor = true;
            btn_obter.Click += btn_obter_Click;
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(26, 395);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(133, 29);
            btn_remover.TabIndex = 10;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(26, 304);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(133, 27);
            btn_adicionar.TabIndex = 11;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // F_ListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_remover);
            Controls.Add(btn_obter);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_preco);
            Controls.Add(tb_qtd);
            Controls.Add(tb_produto);
            Controls.Add(tb_Id);
            Controls.Add(lv_Produtos);
            Name = "F_ListView";
            Text = "F_ListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Produtos;
        private ColumnHeader col_Id;
        private ColumnHeader col_produto;
        private ColumnHeader col_qtd;
        private ColumnHeader col_preco;
        private TextBox tb_Id;
        private TextBox tb_produto;
        private TextBox tb_qtd;
        private TextBox tb_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_obter;
        private Button btn_remover;
        private Button btn_adicionar;
    }
}