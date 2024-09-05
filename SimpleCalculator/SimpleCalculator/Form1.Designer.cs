namespace SimpleCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.naytto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.rresult = new System.Windows.Forms.Button();
            this.cclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naytto
            // 
            this.naytto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naytto.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naytto.Location = new System.Drawing.Point(57, 28);
            this.naytto.Multiline = true;
            this.naytto.Name = "naytto";
            this.naytto.Size = new System.Drawing.Size(214, 126);
            this.naytto.TabIndex = 0;
            this.naytto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.number_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.number_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(167, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.number_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 309);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.number_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 309);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 41);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.number_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(167, 309);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 41);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.number_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(112, 356);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 41);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.number_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(222, 215);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(49, 41);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operator_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(222, 262);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(49, 41);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operator_Click);
            // 
            // multiple
            // 
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple.Location = new System.Drawing.Point(222, 309);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(49, 41);
            this.multiple.TabIndex = 13;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.operator_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(222, 356);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(49, 41);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // rresult
            // 
            this.rresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rresult.Location = new System.Drawing.Point(167, 403);
            this.rresult.Name = "rresult";
            this.rresult.Size = new System.Drawing.Size(104, 41);
            this.rresult.TabIndex = 15;
            this.rresult.Text = "=";
            this.rresult.UseVisualStyleBackColor = true;
            this.rresult.Click += new System.EventHandler(this.rresult_Click);
            // 
            // cclear
            // 
            this.cclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cclear.Location = new System.Drawing.Point(57, 403);
            this.cclear.Name = "cclear";
            this.cclear.Size = new System.Drawing.Size(104, 41);
            this.cclear.TabIndex = 16;
            this.cclear.Text = "C";
            this.cclear.UseVisualStyleBackColor = true;
            this.cclear.Click += new System.EventHandler(this.cclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 474);
            this.Controls.Add(this.cclear);
            this.Controls.Add(this.rresult);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.naytto);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox naytto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button rresult;
        private System.Windows.Forms.Button cclear;
    }
}
