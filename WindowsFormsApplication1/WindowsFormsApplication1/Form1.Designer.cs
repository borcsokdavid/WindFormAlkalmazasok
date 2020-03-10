namespace WindowsFormsApplication1
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
            this.tanulo1 = new System.Windows.Forms.Label();
            this.igazolt1 = new System.Windows.Forms.Label();
            this.igazolatlan1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nev1 = new System.Windows.Forms.TextBox();
            this.igazolthianyzas1 = new System.Windows.Forms.TextBox();
            this.igazolatlanhianyzas1 = new System.Windows.Forms.TextBox();
            this.tanulo2 = new System.Windows.Forms.Label();
            this.igazolt2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.igazolatlan2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tanulo1
            // 
            this.tanulo1.AutoSize = true;
            this.tanulo1.Location = new System.Drawing.Point(44, 13);
            this.tanulo1.Name = "tanulo1";
            this.tanulo1.Size = new System.Drawing.Size(67, 13);
            this.tanulo1.TabIndex = 0;
            this.tanulo1.Text = "Tanuló neve";
            // 
            // igazolt1
            // 
            this.igazolt1.AutoSize = true;
            this.igazolt1.Location = new System.Drawing.Point(47, 47);
            this.igazolt1.Name = "igazolt1";
            this.igazolt1.Size = new System.Drawing.Size(79, 13);
            this.igazolt1.TabIndex = 1;
            this.igazolt1.Text = "Igazol hiányzás";
            // 
            // igazolatlan1
            // 
            this.igazolatlan1.AutoSize = true;
            this.igazolatlan1.Location = new System.Drawing.Point(44, 77);
            this.igazolatlan1.Name = "igazolatlan1";
            this.igazolatlan1.Size = new System.Drawing.Size(102, 13);
            this.igazolatlan1.TabIndex = 2;
            this.igazolatlan1.Text = "Igazolatlan hiányzás";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Feltöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nev1
            // 
            this.nev1.Location = new System.Drawing.Point(148, 13);
            this.nev1.Name = "nev1";
            this.nev1.Size = new System.Drawing.Size(100, 20);
            this.nev1.TabIndex = 4;
            // 
            // igazolthianyzas1
            // 
            this.igazolthianyzas1.Location = new System.Drawing.Point(148, 47);
            this.igazolthianyzas1.Name = "igazolthianyzas1";
            this.igazolthianyzas1.Size = new System.Drawing.Size(100, 20);
            this.igazolthianyzas1.TabIndex = 5;
            // 
            // igazolatlanhianyzas1
            // 
            this.igazolatlanhianyzas1.Location = new System.Drawing.Point(148, 77);
            this.igazolatlanhianyzas1.Name = "igazolatlanhianyzas1";
            this.igazolatlanhianyzas1.Size = new System.Drawing.Size(100, 20);
            this.igazolatlanhianyzas1.TabIndex = 6;
            // 
            // tanulo2
            // 
            this.tanulo2.AutoSize = true;
            this.tanulo2.Location = new System.Drawing.Point(44, 158);
            this.tanulo2.Name = "tanulo2";
            this.tanulo2.Size = new System.Drawing.Size(67, 13);
            this.tanulo2.TabIndex = 7;
            this.tanulo2.Text = "Tanuló neve";
            // 
            // igazolt2
            // 
            this.igazolt2.AutoSize = true;
            this.igazolt2.Location = new System.Drawing.Point(44, 182);
            this.igazolt2.Name = "igazolt2";
            this.igazolt2.Size = new System.Drawing.Size(82, 13);
            this.igazolt2.TabIndex = 8;
            this.igazolt2.Text = "Igazolt hiányzás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // igazolatlan2
            // 
            this.igazolatlan2.AutoSize = true;
            this.igazolatlan2.Location = new System.Drawing.Point(44, 214);
            this.igazolatlan2.Name = "igazolatlan2";
            this.igazolatlan2.Size = new System.Drawing.Size(102, 13);
            this.igazolatlan2.TabIndex = 10;
            this.igazolatlan2.Text = "Igazolatlan hiányzás";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Lekérés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 325);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.igazolatlan2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.igazolt2);
            this.Controls.Add(this.tanulo2);
            this.Controls.Add(this.igazolatlanhianyzas1);
            this.Controls.Add(this.igazolthianyzas1);
            this.Controls.Add(this.nev1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.igazolatlan1);
            this.Controls.Add(this.igazolt1);
            this.Controls.Add(this.tanulo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tanulo1;
        private System.Windows.Forms.Label igazolt1;
        private System.Windows.Forms.Label igazolatlan1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nev1;
        private System.Windows.Forms.TextBox igazolthianyzas1;
        private System.Windows.Forms.TextBox igazolatlanhianyzas1;
        private System.Windows.Forms.Label tanulo2;
        private System.Windows.Forms.Label igazolt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label igazolatlan2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

