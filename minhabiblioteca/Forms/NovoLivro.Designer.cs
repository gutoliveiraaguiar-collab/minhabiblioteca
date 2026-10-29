namespace minhabiblioteca.Forms
{
    partial class NovoLivro
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
            label1 = new Label();
            label2 = new Label();
            lblISBN = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtISBN = new TextBox();
            label4 = new Label();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAno = new Label();
            lblEditora = new TextBox();
            label3 = new Label();
            numAno = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Artifakt Element Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 10);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de livros";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Artifakt Element", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 290);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(53, 195);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(37, 17);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN";
            lblISBN.Click += label3_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(154, 116);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(379, 25);
            txtTitulo.TabIndex = 3;
            txtTitulo.TextChanged += textBox1_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(154, 263);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(386, 25);
            txtAutor.TabIndex = 4;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(154, 193);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(386, 25);
            txtISBN.TabIndex = 5;
            txtISBN.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Artifakt Element", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 294);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 6;
            label4.Click += label4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(57, 119);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(45, 17);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(55, 263);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(43, 17);
            lblAutor.TabIndex = 8;
            lblAutor.Text = "Autor";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(55, 338);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(33, 17);
            lblAno.TabIndex = 9;
            lblAno.Text = "Ano";
            // 
            // lblEditora
            // 
            lblEditora.Location = new Point(154, 407);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(163, 25);
            lblEditora.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 411);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 12;
            label3.Text = "Editora";
            // 
            // numAno
            // 
            numAno.Location = new Point(154, 336);
            numAno.Name = "numAno";
            numAno.Size = new Size(128, 25);
            numAno.TabIndex = 13;
            numAno.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // NovoLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 648);
            Controls.Add(numAno);
            Controls.Add(label3);
            Controls.Add(lblEditora);
            Controls.Add(lblAno);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(label4);
            Controls.Add(txtISBN);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblISBN);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "NovoLivro";
            Text = "NovoLivro";
            Load += NovoLivro_Load;
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblISBN;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtISBN;
        private Label label4;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAno;
        private TextBox lblEditora;
        private Label label3;
        private NumericUpDown numAno;
    }
}