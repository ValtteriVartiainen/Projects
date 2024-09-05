namespace Matikkapeli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huipputuloksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miinusPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kertoPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kayttajaNimi = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.huipputuloksetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // huipputuloksetToolStripMenuItem
            // 
            this.huipputuloksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plusPeliToolStripMenuItem,
            this.miinusPeliToolStripMenuItem,
            this.kertoPeliToolStripMenuItem});
            this.huipputuloksetToolStripMenuItem.Name = "huipputuloksetToolStripMenuItem";
            this.huipputuloksetToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.huipputuloksetToolStripMenuItem.Text = "Huipputulokset";
            // 
            // plusPeliToolStripMenuItem
            // 
            this.plusPeliToolStripMenuItem.Name = "plusPeliToolStripMenuItem";
            this.plusPeliToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.plusPeliToolStripMenuItem.Text = "Plus peli";
            this.plusPeliToolStripMenuItem.Click += new System.EventHandler(this.plusPeliToolStripMenuItem_Click_1);
            // 
            // miinusPeliToolStripMenuItem
            // 
            this.miinusPeliToolStripMenuItem.Name = "miinusPeliToolStripMenuItem";
            this.miinusPeliToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.miinusPeliToolStripMenuItem.Text = "Miinus peli";
            this.miinusPeliToolStripMenuItem.Click += new System.EventHandler(this.miinusPeliToolStripMenuItem_Click);
            // 
            // kertoPeliToolStripMenuItem
            // 
            this.kertoPeliToolStripMenuItem.Name = "kertoPeliToolStripMenuItem";
            this.kertoPeliToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kertoPeliToolStripMenuItem.Text = "Kerto peli";
            this.kertoPeliToolStripMenuItem.Click += new System.EventHandler(this.kertoPeliToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Plus laskut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(82, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Miinus laskut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(82, 272);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kerto laskut";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Syötä käyttäjänimi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kayttajaNimi
            // 
            this.kayttajaNimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kayttajaNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaNimi.Location = new System.Drawing.Point(69, 79);
            this.kayttajaNimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kayttajaNimi.Multiline = true;
            this.kayttajaNimi.Name = "kayttajaNimi";
            this.kayttajaNimi.Size = new System.Drawing.Size(157, 27);
            this.kayttajaNimi.TabIndex = 5;
            this.kayttajaNimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kayttajaNimi.TextChanged += new System.EventHandler(this.kayttajaNimi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 414);
            this.Controls.Add(this.kayttajaNimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Matikkapeli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kayttajaNimi;
        private System.Windows.Forms.ToolStripMenuItem huipputuloksetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miinusPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kertoPeliToolStripMenuItem;
    }
}

