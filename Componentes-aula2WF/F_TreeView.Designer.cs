namespace Componentes_aula2WF
{
    partial class F_TreeView
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
            TreeNode treeNode1 = new TreeNode("HRV");
            TreeNode treeNode2 = new TreeNode("Fit");
            TreeNode treeNode3 = new TreeNode("Honda", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Golf");
            TreeNode treeNode5 = new TreeNode("Nó5");
            TreeNode treeNode6 = new TreeNode("Volkswagen", new TreeNode[] { treeNode4, treeNode5 });
            treeView1 = new TreeView();
            btn_adicionar = new Button();
            btn_remover = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_removerSelecionado = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 25);
            treeView1.Name = "treeView1";
            treeNode1.Name = "hrv";
            treeNode1.Tag = "http://youtube.com";
            treeNode1.Text = "HRV";
            treeNode2.Name = "fit";
            treeNode2.Text = "Fit";
            treeNode3.Name = "honda";
            treeNode3.Text = "Honda";
            treeNode4.Name = "golf";
            treeNode4.Text = "Golf";
            treeNode5.Name = "Nó5";
            treeNode5.Text = "Nó5";
            treeNode6.Name = "polo";
            treeNode6.Text = "Volkswagen";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            treeView1.Size = new Size(151, 373);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(188, 41);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(248, 29);
            btn_adicionar.TabIndex = 1;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(188, 85);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(248, 29);
            btn_remover.TabIndex = 2;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(188, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(188, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 4;
            // 
            // btn_removerSelecionado
            // 
            btn_removerSelecionado.Location = new Point(485, 85);
            btn_removerSelecionado.Name = "btn_removerSelecionado";
            btn_removerSelecionado.Size = new Size(222, 29);
            btn_removerSelecionado.TabIndex = 5;
            btn_removerSelecionado.Text = "Remover Selecionado";
            btn_removerSelecionado.UseVisualStyleBackColor = true;
            btn_removerSelecionado.Click += btn_removerSelecionado_Click;
            // 
            // F_TreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_removerSelecionado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_remover);
            Controls.Add(btn_adicionar);
            Controls.Add(treeView1);
            Name = "F_TreeView";
            Text = "F_TreeView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button btn_adicionar;
        private Button btn_remover;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_removerSelecionado;
    }
}