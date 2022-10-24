namespace scrittori_visori
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
            this.scrivi = new System.Windows.Forms.Button();
            this.corsivo = new System.Windows.Forms.CheckBox();
            this.sottolineato = new System.Windows.Forms.CheckBox();
            this.grassetto = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scrivi
            // 
            this.scrivi.Location = new System.Drawing.Point(627, 102);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(62, 36);
            this.scrivi.TabIndex = 15;
            this.scrivi.Text = "Scrivi";
            this.scrivi.UseVisualStyleBackColor = true;
            // 
            // corsivo
            // 
            this.corsivo.AutoSize = true;
            this.corsivo.Location = new System.Drawing.Point(30, 285);
            this.corsivo.Name = "corsivo";
            this.corsivo.Size = new System.Drawing.Size(66, 19);
            this.corsivo.TabIndex = 14;
            this.corsivo.Text = "Corsivo";
            this.corsivo.UseVisualStyleBackColor = true;
            // 
            // sottolineato
            // 
            this.sottolineato.AutoSize = true;
            this.sottolineato.Location = new System.Drawing.Point(30, 260);
            this.sottolineato.Name = "sottolineato";
            this.sottolineato.Size = new System.Drawing.Size(90, 19);
            this.sottolineato.TabIndex = 13;
            this.sottolineato.Text = "Sottolineato";
            this.sottolineato.UseVisualStyleBackColor = true;
            // 
            // grassetto
            // 
            this.grassetto.AutoSize = true;
            this.grassetto.Location = new System.Drawing.Point(30, 235);
            this.grassetto.Name = "grassetto";
            this.grassetto.Size = new System.Drawing.Size(75, 19);
            this.grassetto.TabIndex = 12;
            this.grassetto.Text = "Grassetto";
            this.grassetto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 193);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "testo da inserire:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrivi);
            this.Controls.Add(this.corsivo);
            this.Controls.Add(this.sottolineato);
            this.Controls.Add(this.grassetto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button scrivi;
        private CheckBox corsivo;
        private CheckBox sottolineato;
        private CheckBox grassetto;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}