
namespace AtividadePizzaria
{
    partial class Form2
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
            this.labelFPedido = new System.Windows.Forms.Label();
            this.cboTPSalgado = new System.Windows.Forms.ComboBox();
            this.labelPizzaS = new System.Windows.Forms.Label();
            this.labelTamanhoPS = new System.Windows.Forms.Label();
            this.cboSBebidas = new System.Windows.Forms.ComboBox();
            this.labelBebida = new System.Windows.Forms.Label();
            this.labelQBebida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSPSalgado = new System.Windows.Forms.ComboBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTBebidas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFPedido
            // 
            this.labelFPedido.AutoSize = true;
            this.labelFPedido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFPedido.Location = new System.Drawing.Point(363, 32);
            this.labelFPedido.Name = "labelFPedido";
            this.labelFPedido.Size = new System.Drawing.Size(70, 25);
            this.labelFPedido.TabIndex = 0;
            this.labelFPedido.Text = "Pedido";
            // 
            // cboTPSalgado
            // 
            this.cboTPSalgado.FormattingEnabled = true;
            this.cboTPSalgado.Items.AddRange(new object[] {
            "Broto R$ 26,00",
            "Média R$ 30,00",
            "Grande R$ 36,00"});
            this.cboTPSalgado.Location = new System.Drawing.Point(175, 175);
            this.cboTPSalgado.Name = "cboTPSalgado";
            this.cboTPSalgado.Size = new System.Drawing.Size(121, 23);
            this.cboTPSalgado.TabIndex = 1;
            // 
            // labelPizzaS
            // 
            this.labelPizzaS.AutoSize = true;
            this.labelPizzaS.Location = new System.Drawing.Point(192, 108);
            this.labelPizzaS.Name = "labelPizzaS";
            this.labelPizzaS.Size = new System.Drawing.Size(77, 15);
            this.labelPizzaS.TabIndex = 2;
            this.labelPizzaS.Text = "Pizza Salgada";
            // 
            // labelTamanhoPS
            // 
            this.labelTamanhoPS.AutoSize = true;
            this.labelTamanhoPS.Location = new System.Drawing.Point(202, 157);
            this.labelTamanhoPS.Name = "labelTamanhoPS";
            this.labelTamanhoPS.Size = new System.Drawing.Size(56, 15);
            this.labelTamanhoPS.TabIndex = 3;
            this.labelTamanhoPS.Text = "Tamanho";
            // 
            // cboSBebidas
            // 
            this.cboSBebidas.FormattingEnabled = true;
            this.cboSBebidas.Items.AddRange(new object[] {
            "Guaraná",
            "Fanta Uva",
            "Fanta Laranja",
            "Coca-Cola",
            "Sprite",
            "Sem Bebida"});
            this.cboSBebidas.Location = new System.Drawing.Point(495, 248);
            this.cboSBebidas.Name = "cboSBebidas";
            this.cboSBebidas.Size = new System.Drawing.Size(121, 23);
            this.cboSBebidas.TabIndex = 7;
            // 
            // labelBebida
            // 
            this.labelBebida.AutoSize = true;
            this.labelBebida.Location = new System.Drawing.Point(535, 108);
            this.labelBebida.Name = "labelBebida";
            this.labelBebida.Size = new System.Drawing.Size(43, 15);
            this.labelBebida.TabIndex = 8;
            this.labelBebida.Text = "Bebida";
            // 
            // labelQBebida
            // 
            this.labelQBebida.AutoSize = true;
            this.labelQBebida.Location = new System.Drawing.Point(530, 230);
            this.labelQBebida.Name = "labelQBebida";
            this.labelQBebida.Size = new System.Drawing.Size(48, 15);
            this.labelQBebida.TabIndex = 9;
            this.labelQBebida.Text = "Sabores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sabores";
            // 
            // cboSPSalgado
            // 
            this.cboSPSalgado.FormattingEnabled = true;
            this.cboSPSalgado.Items.AddRange(new object[] {
            "Frango com Catupiry",
            "Portuguesa",
            "Calabresa",
            "Brócolis"});
            this.cboSPSalgado.Location = new System.Drawing.Point(175, 248);
            this.cboSPSalgado.Name = "cboSPSalgado";
            this.cboSPSalgado.Size = new System.Drawing.Size(121, 23);
            this.cboSPSalgado.TabIndex = 11;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(639, 399);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 14;
            this.buttonFinalizar.Text = "Salvar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tamanho";
            // 
            // cboTBebidas
            // 
            this.cboTBebidas.FormattingEnabled = true;
            this.cboTBebidas.Items.AddRange(new object[] {
            "Lata (350 ml) R$ 4,00",
            "Garrafa (600 ml) R$ 6,00",
            "Garrafa (1,5 L) R$ 8,00",
            "Garrafa (2,0L) R$ 10,00",
            "Sem Bebida"});
            this.cboTBebidas.Location = new System.Drawing.Point(495, 175);
            this.cboTBebidas.Name = "cboTBebidas";
            this.cboTBebidas.Size = new System.Drawing.Size(121, 23);
            this.cboTBebidas.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTBebidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.cboSPSalgado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelQBebida);
            this.Controls.Add(this.labelBebida);
            this.Controls.Add(this.cboSBebidas);
            this.Controls.Add(this.labelTamanhoPS);
            this.Controls.Add(this.labelPizzaS);
            this.Controls.Add(this.cboTPSalgado);
            this.Controls.Add(this.labelFPedido);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFPedido;
        private System.Windows.Forms.ComboBox cboTPSalgado;
        private System.Windows.Forms.Label labelPizzaS;
        private System.Windows.Forms.Label labelTamanhoPS;
        private System.Windows.Forms.ComboBox cboSBebidas;
        private System.Windows.Forms.Label labelBebida;
        private System.Windows.Forms.Label labelQBebida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSPSalgado;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTBebidas;
    }
}