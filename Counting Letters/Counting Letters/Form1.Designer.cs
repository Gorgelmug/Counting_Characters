namespace Counting_Letters
{
    partial class Form1
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
            this.BrowseForTexts = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtInputLetter = new System.Windows.Forms.TextBox();
            this.txtWelkeLetter = new System.Windows.Forms.TextBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.ltrsAantalLabel = new System.Windows.Forms.Label();
            this.lettersAantalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrowseForTexts
            // 
            this.BrowseForTexts.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(13, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 32);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse your texts";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(134, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(432, 371);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txtInputLetter
            // 
            this.txtInputLetter.Location = new System.Drawing.Point(13, 77);
            this.txtInputLetter.MaxLength = 1;
            this.txtInputLetter.Name = "txtInputLetter";
            this.txtInputLetter.Size = new System.Drawing.Size(114, 20);
            this.txtInputLetter.TabIndex = 2;
            // 
            // txtWelkeLetter
            // 
            this.txtWelkeLetter.Location = new System.Drawing.Point(13, 51);
            this.txtWelkeLetter.Name = "txtWelkeLetter";
            this.txtWelkeLetter.ReadOnly = true;
            this.txtWelkeLetter.Size = new System.Drawing.Size(114, 20);
            this.txtWelkeLetter.TabIndex = 3;
            this.txtWelkeLetter.Text = "Welke letter zoek je?";
            // 
            // btnZoek
            // 
            this.btnZoek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoek.Location = new System.Drawing.Point(13, 104);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(114, 28);
            this.btnZoek.TabIndex = 4;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // ltrsAantalLabel
            // 
            this.ltrsAantalLabel.AutoSize = true;
            this.ltrsAantalLabel.Location = new System.Drawing.Point(13, 139);
            this.ltrsAantalLabel.Name = "ltrsAantalLabel";
            this.ltrsAantalLabel.Size = new System.Drawing.Size(97, 13);
            this.ltrsAantalLabel.TabIndex = 5;
            this.ltrsAantalLabel.Text = "Het aantal letters is";
            // 
            // lettersAantalLabel
            // 
            this.lettersAantalLabel.AutoSize = true;
            this.lettersAantalLabel.Location = new System.Drawing.Point(13, 163);
            this.lettersAantalLabel.Name = "lettersAantalLabel";
            this.lettersAantalLabel.Size = new System.Drawing.Size(0, 13);
            this.lettersAantalLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 109);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Om een text toe te voegen klik op Browse. Selecteer de text door dubbel te kikken" +
    " en voer deletter in die je wilt weergeven. Klik dan op Zoek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 383);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lettersAantalLabel);
            this.Controls.Add(this.ltrsAantalLabel);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.txtWelkeLetter);
            this.Controls.Add(this.txtInputLetter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog BrowseForTexts;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtInputLetter;
        private System.Windows.Forms.TextBox txtWelkeLetter;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Label ltrsAantalLabel;
        private System.Windows.Forms.Label lettersAantalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

