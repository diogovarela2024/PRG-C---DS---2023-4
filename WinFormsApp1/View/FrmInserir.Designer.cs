namespace WinFormsApp1
{
    partial class FrmInserir
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
            this.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nome = new TextBox();
            label2 = new Label();
            idade = new TextBox();
            label3 = new Label();
            nif = new TextBox();
            label4 = new Label();
            num = new TextBox();
            Adicionar = new Button();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 169);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // nome
            // 
            nome.Location = new Point(454, 169);
            nome.Name = "nome";
            nome.Size = new Size(986, 39);
            nome.TabIndex = 1;
            nome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 239);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            // 
            // idade
            // 
            idade.Location = new Point(454, 232);
            idade.Name = "idade";
            idade.Size = new Size(58, 39);
            idade.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 292);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 4;
            label3.Text = "NIF:";
            // 
            // nif
            // 
            nif.Location = new Point(444, 292);
            nif.Name = "nif";
            nif.Size = new Size(270, 39);
            nif.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 358);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 6;
            label4.Text = "Num";
            // 
            // num
            // 
            num.Location = new Point(444, 358);
            num.Name = "num";
            num.Size = new Size(270, 39);
            num.TabIndex = 7;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(564, 462);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(150, 46);
            Adicionar.TabIndex = 8;
            Adicionar.Text = "Inserir";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(831, 34);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 9;
            label5.Text = "CLIENTE";
            // 
            // button1
            // 
            button1.Location = new Point(1084, 462);
            button1.Name = "button1";
            button1.Size = new Size(271, 46);
            button1.TabIndex = 10;
            button1.Text = "Consultar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FrmInserir
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 587);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(Adicionar);
            Controls.Add(num);
            Controls.Add(label4);
            Controls.Add(nif);
            Controls.Add(label3);
            Controls.Add(idade);
            Controls.Add(label2);
            Controls.Add(nome);
            Controls.Add(label1);
            Name = "FrmInserir";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nome;
        private Label label2;
        private TextBox idade;
        private Label label3;
        private TextBox nif;
        private Label label4;
        private TextBox num;
        private Button Adicionar;
        private Label label5;
        private Button button1;
    }
}
