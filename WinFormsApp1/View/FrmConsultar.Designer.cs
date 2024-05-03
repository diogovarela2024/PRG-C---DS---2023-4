namespace WinFormsApp1
{
    partial class FrmConsultar
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
            consultar = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // consultar
            // 
            consultar.Location = new Point(12, 70);
            consultar.Multiline = true;
            consultar.Name = "consultar";
            consultar.ScrollBars = ScrollBars.Both;
            consultar.Size = new Size(1377, 564);
            consultar.TabIndex = 18;
            consultar.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 19;
            label1.Text = "Dados";
            label1.Click += label1_Click;
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 750);
            Controls.Add(label1);
            Controls.Add(consultar);
            Name = "FrmConsultar";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox consultar;
        private Label label1;
    }
}