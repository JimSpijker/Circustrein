namespace circustrein1
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
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.cbGrootte = new System.Windows.Forms.ComboBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.lbDieren = new System.Windows.Forms.ListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSoort
            // 
            this.cbSoort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Items.AddRange(new object[] {
            "Herbivoor",
            "Carnivoor"});
            this.cbSoort.Location = new System.Drawing.Point(248, 72);
            this.cbSoort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(160, 25);
            this.cbSoort.TabIndex = 0;
            // 
            // cbGrootte
            // 
            this.cbGrootte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrootte.FormattingEnabled = true;
            this.cbGrootte.Items.AddRange(new object[] {
            "Klein (1)",
            "Medium (3)",
            "Groot (5)"});
            this.cbGrootte.Location = new System.Drawing.Point(417, 72);
            this.cbGrootte.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrootte.Name = "cbGrootte";
            this.cbGrootte.Size = new System.Drawing.Size(160, 25);
            this.cbGrootte.TabIndex = 1;
            // 
            // tbNaam
            // 
            this.tbNaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNaam.Location = new System.Drawing.Point(107, 72);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaam.MaxLength = 15;
            this.tbNaam.Multiline = true;
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(132, 25);
            this.tbNaam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dieet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grootte";
            // 
            // btToevoegen
            // 
            this.btToevoegen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btToevoegen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btToevoegen.Location = new System.Drawing.Point(107, 106);
            this.btToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(472, 30);
            this.btToevoegen.TabIndex = 6;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = false;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // lbDieren
            // 
            this.lbDieren.BackColor = System.Drawing.SystemColors.Window;
            this.lbDieren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDieren.FormattingEnabled = true;
            this.lbDieren.ItemHeight = 17;
            this.lbDieren.Location = new System.Drawing.Point(107, 191);
            this.lbDieren.Margin = new System.Windows.Forms.Padding(4);
            this.lbDieren.Name = "lbDieren";
            this.lbDieren.ScrollAlwaysVisible = true;
            this.lbDieren.Size = new System.Drawing.Size(240, 340);
            this.lbDieren.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSave.Location = new System.Drawing.Point(453, 488);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 48);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save as .txt";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dieren:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(685, 574);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbDieren);
            this.Controls.Add(this.btToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.cbGrootte);
            this.Controls.Add(this.cbSoort);
            this.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circustrein";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.ComboBox cbGrootte;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.ListBox lbDieren;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label4;
    }
}

