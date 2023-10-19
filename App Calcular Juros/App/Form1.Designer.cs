namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Fundo = new Panel();
            panel1 = new Panel();
            lblResultado = new Label();
            btnResultado = new Button();
            NumerodeParcelas = new TextBox();
            lblNumeroParcelas = new Label();
            txtTaxaAnualDeJuros = new TextBox();
            lblTaxaJuros = new Label();
            txtValorEmprestimo = new TextBox();
            lblValorPrincipalEmprestimo = new Label();
            Fundo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Fundo
            // 
            Fundo.BackColor = Color.Blue;
            Fundo.Controls.Add(panel1);
            Fundo.Controls.Add(btnResultado);
            Fundo.Controls.Add(NumerodeParcelas);
            Fundo.Controls.Add(lblNumeroParcelas);
            Fundo.Controls.Add(txtTaxaAnualDeJuros);
            Fundo.Controls.Add(lblTaxaJuros);
            Fundo.Controls.Add(txtValorEmprestimo);
            Fundo.Controls.Add(lblValorPrincipalEmprestimo);
            Fundo.Location = new Point(35, 33);
            Fundo.Name = "Fundo";
            Fundo.Size = new Size(1251, 621);
            Fundo.TabIndex = 0;
            Fundo.Paint += Fundo_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblResultado);
            panel1.Location = new Point(598, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 130);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(215, 51);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(118, 23);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "RESULTADO";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.DimGray;
            btnResultado.Cursor = Cursors.AppStarting;
            btnResultado.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultado.Image = (Image)resources.GetObject("btnResultado.Image");
            btnResultado.ImageAlign = ContentAlignment.TopLeft;
            btnResultado.Location = new Point(122, 427);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(335, 42);
            btnResultado.TabIndex = 6;
            btnResultado.Text = "CALCULAR";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // NumerodeParcelas
            // 
            NumerodeParcelas.BackColor = Color.Silver;
            NumerodeParcelas.Cursor = Cursors.IBeam;
            NumerodeParcelas.Location = new Point(25, 342);
            NumerodeParcelas.Name = "NumerodeParcelas";
            NumerodeParcelas.Size = new Size(314, 27);
            NumerodeParcelas.TabIndex = 5;
            NumerodeParcelas.TextChanged += NumerodeParcelas_TextChanged;
            // 
            // lblNumeroParcelas
            // 
            lblNumeroParcelas.AutoSize = true;
            lblNumeroParcelas.BackColor = Color.Silver;
            lblNumeroParcelas.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroParcelas.Location = new Point(25, 299);
            lblNumeroParcelas.Name = "lblNumeroParcelas";
            lblNumeroParcelas.Size = new Size(278, 26);
            lblNumeroParcelas.TabIndex = 4;
            lblNumeroParcelas.Text = "Número de Parcelas:";
            // 
            // txtTaxaAnualDeJuros
            // 
            txtTaxaAnualDeJuros.BackColor = Color.Silver;
            txtTaxaAnualDeJuros.Cursor = Cursors.IBeam;
            txtTaxaAnualDeJuros.Location = new Point(25, 247);
            txtTaxaAnualDeJuros.Name = "txtTaxaAnualDeJuros";
            txtTaxaAnualDeJuros.Size = new Size(314, 27);
            txtTaxaAnualDeJuros.TabIndex = 3;
            txtTaxaAnualDeJuros.TextChanged += txtTaxaAnualDeJuros_TextChanged;
            // 
            // lblTaxaJuros
            // 
            lblTaxaJuros.AutoSize = true;
            lblTaxaJuros.BackColor = Color.Silver;
            lblTaxaJuros.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaxaJuros.Location = new Point(25, 196);
            lblTaxaJuros.Name = "lblTaxaJuros";
            lblTaxaJuros.Size = new Size(348, 26);
            lblTaxaJuros.TabIndex = 2;
            lblTaxaJuros.Text = "Taxa de Juros Anual (%):";
            lblTaxaJuros.Click += lblTaxaJuros_Click;
            // 
            // txtValorEmprestimo
            // 
            txtValorEmprestimo.BackColor = Color.Silver;
            txtValorEmprestimo.Cursor = Cursors.IBeam;
            txtValorEmprestimo.Location = new Point(25, 139);
            txtValorEmprestimo.Name = "txtValorEmprestimo";
            txtValorEmprestimo.Size = new Size(314, 27);
            txtValorEmprestimo.TabIndex = 1;
            txtValorEmprestimo.TextChanged += txtValorEmprestimo_TextChanged;
            // 
            // lblValorPrincipalEmprestimo
            // 
            lblValorPrincipalEmprestimo.AutoSize = true;
            lblValorPrincipalEmprestimo.BackColor = Color.Silver;
            lblValorPrincipalEmprestimo.Font = new Font("Lucida Sans Typewriter", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorPrincipalEmprestimo.Location = new Point(25, 94);
            lblValorPrincipalEmprestimo.Name = "lblValorPrincipalEmprestimo";
            lblValorPrincipalEmprestimo.Size = new Size(432, 26);
            lblValorPrincipalEmprestimo.TabIndex = 0;
            lblValorPrincipalEmprestimo.Text = "Valor Principal do Empréstimo:";
            lblValorPrincipalEmprestimo.Click += lblValorPrincipalEmprestimo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 688);
            Controls.Add(Fundo);
            Name = "Form1";
            Text = "Form1";
            Fundo.ResumeLayout(false);
            Fundo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Fundo;
        private Label lblValorPrincipalEmprestimo;
        private Label lblTaxaJuros;
        private TextBox txtValorEmprestimo;
        private TextBox txtTaxaAnualDeJuros;
        private TextBox NumerodeParcelas;
        private Label lblNumeroParcelas;
        private Button btnResultado;
        private Panel panel1;
        private Label lblResultado;
    }
}