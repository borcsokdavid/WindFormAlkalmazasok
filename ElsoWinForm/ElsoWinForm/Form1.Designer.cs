namespace ElsoWinForm
{
    partial class urlap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urlap));
            this.szoveg = new System.Windows.Forms.Label();
            this.beviteliMezo = new System.Windows.Forms.TextBox();
            this.modositoGomb = new System.Windows.Forms.Button();
            this.kimenoSzoveg = new System.Windows.Forms.TextBox();
            this.gomb2 = new System.Windows.Forms.Button();
            this.elso = new System.Windows.Forms.Button();
            this.masodik = new System.Windows.Forms.Button();
            this.harmadik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // szoveg
            // 
            this.szoveg.AutoSize = true;
            this.szoveg.BackColor = System.Drawing.Color.White;
            this.szoveg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg.ForeColor = System.Drawing.Color.DarkOrange;
            this.szoveg.Location = new System.Drawing.Point(29, 23);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(70, 22);
            this.szoveg.TabIndex = 0;
            this.szoveg.Text = "Szöveg";
            // 
            // beviteliMezo
            // 
            this.beviteliMezo.Location = new System.Drawing.Point(122, 23);
            this.beviteliMezo.Multiline = true;
            this.beviteliMezo.Name = "beviteliMezo";
            this.beviteliMezo.Size = new System.Drawing.Size(100, 20);
            this.beviteliMezo.TabIndex = 1;
            this.beviteliMezo.TextChanged += new System.EventHandler(this.beviteliMezo_TextChanged);
            // 
            // modositoGomb
            // 
            this.modositoGomb.BackColor = System.Drawing.Color.Transparent;
            this.modositoGomb.ForeColor = System.Drawing.Color.Black;
            this.modositoGomb.Location = new System.Drawing.Point(24, 87);
            this.modositoGomb.Name = "modositoGomb";
            this.modositoGomb.Size = new System.Drawing.Size(92, 23);
            this.modositoGomb.TabIndex = 2;
            this.modositoGomb.Text = "Módosító gomb";
            this.modositoGomb.UseVisualStyleBackColor = false;
            this.modositoGomb.Click += new System.EventHandler(this.modositoGomb_Click);
            // 
            // kimenoSzoveg
            // 
            this.kimenoSzoveg.Location = new System.Drawing.Point(122, 49);
            this.kimenoSzoveg.Name = "kimenoSzoveg";
            this.kimenoSzoveg.Size = new System.Drawing.Size(100, 20);
            this.kimenoSzoveg.TabIndex = 3;
            // 
            // gomb2
            // 
            this.gomb2.Location = new System.Drawing.Point(24, 125);
            this.gomb2.Name = "gomb2";
            this.gomb2.Size = new System.Drawing.Size(75, 23);
            this.gomb2.TabIndex = 4;
            this.gomb2.Text = "gomb";
            this.gomb2.UseVisualStyleBackColor = true;
            this.gomb2.MouseEnter += new System.EventHandler(this.gomb2_MouseEnter);
            this.gomb2.MouseLeave += new System.EventHandler(this.gomb2_MouseLeave);
            // 
            // elso
            // 
            this.elso.Location = new System.Drawing.Point(24, 176);
            this.elso.Name = "elso";
            this.elso.Size = new System.Drawing.Size(75, 23);
            this.elso.TabIndex = 5;
            this.elso.Text = "Első";
            this.elso.UseVisualStyleBackColor = true;
            this.elso.Click += new System.EventHandler(this.elso_Click);
            // 
            // masodik
            // 
            this.masodik.Location = new System.Drawing.Point(105, 176);
            this.masodik.Name = "masodik";
            this.masodik.Size = new System.Drawing.Size(75, 23);
            this.masodik.TabIndex = 6;
            this.masodik.Text = "Második";
            this.masodik.UseVisualStyleBackColor = true;
            this.masodik.Click += new System.EventHandler(this.masodik_Click);
            // 
            // harmadik
            // 
            this.harmadik.Location = new System.Drawing.Point(186, 176);
            this.harmadik.Name = "harmadik";
            this.harmadik.Size = new System.Drawing.Size(75, 23);
            this.harmadik.TabIndex = 7;
            this.harmadik.Text = "Harmadik";
            this.harmadik.UseVisualStyleBackColor = true;
            this.harmadik.Click += new System.EventHandler(this.harmadik_Click);
            this.harmadik.MouseEnter += new System.EventHandler(this.harmadik_MouseEnter);
            // 
            // urlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 265);
            this.Controls.Add(this.harmadik);
            this.Controls.Add(this.masodik);
            this.Controls.Add(this.elso);
            this.Controls.Add(this.gomb2);
            this.Controls.Add(this.kimenoSzoveg);
            this.Controls.Add(this.modositoGomb);
            this.Controls.Add(this.beviteliMezo);
            this.Controls.Add(this.szoveg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 300);
            this.Name = "urlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Űrlap";
            this.Load += new System.EventHandler(this.urlap_Load);
            this.MouseEnter += new System.EventHandler(this.urlap_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.urlap_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.urlap_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label szoveg;
        private System.Windows.Forms.TextBox beviteliMezo;
        private System.Windows.Forms.Button modositoGomb;
        private System.Windows.Forms.TextBox kimenoSzoveg;
        private System.Windows.Forms.Button gomb2;
        private System.Windows.Forms.Button elso;
        private System.Windows.Forms.Button masodik;
        private System.Windows.Forms.Button harmadik;
    }
}

