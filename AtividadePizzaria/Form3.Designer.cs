
namespace AtividadePizzaria
{
    partial class Form3
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
            this.dataGridTabelaPedido = new System.Windows.Forms.DataGridView();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaIDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabelaPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTabelaPedido
            // 
            this.dataGridTabelaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTabelaPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaTelefone,
            this.ColunaIDPedido,
            this.ColunaPedido,
            this.ColunaBebida,
            this.ColunaValor});
            this.dataGridTabelaPedido.Location = new System.Drawing.Point(12, 12);
            this.dataGridTabelaPedido.Name = "dataGridTabelaPedido";
            this.dataGridTabelaPedido.RowTemplate.Height = 25;
            this.dataGridTabelaPedido.Size = new System.Drawing.Size(764, 371);
            this.dataGridTabelaPedido.TabIndex = 0;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(330, 405);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(176, 23);
            this.buttonRemover.TabIndex = 1;
            this.buttonRemover.Text = "Remover Pedido";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // ColunaID
            // 
            this.ColunaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.Width = 43;
            // 
            // ColunaNome
            // 
            this.ColunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 65;
            // 
            // ColunaTelefone
            // 
            this.ColunaTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaTelefone.HeaderText = "Telefone";
            this.ColunaTelefone.Name = "ColunaTelefone";
            this.ColunaTelefone.Width = 76;
            // 
            // ColunaIDPedido
            // 
            this.ColunaIDPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaIDPedido.HeaderText = "ID Pedido";
            this.ColunaIDPedido.Name = "ColunaIDPedido";
            this.ColunaIDPedido.Width = 83;
            // 
            // ColunaPedido
            // 
            this.ColunaPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaPedido.HeaderText = "Pedido";
            this.ColunaPedido.Name = "ColunaPedido";
            this.ColunaPedido.Width = 69;
            // 
            // ColunaBebida
            // 
            this.ColunaBebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaBebida.HeaderText = "Bebida";
            this.ColunaBebida.Name = "ColunaBebida";
            this.ColunaBebida.Width = 68;
            // 
            // ColunaValor
            // 
            this.ColunaValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColunaValor.HeaderText = "Valor";
            this.ColunaValor.Name = "ColunaValor";
            this.ColunaValor.Width = 58;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.dataGridTabelaPedido);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabelaPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTabelaPedido;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaIDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValor;
    }
}