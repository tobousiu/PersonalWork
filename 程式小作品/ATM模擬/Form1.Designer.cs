namespace CSForm_ATM
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.cha = new System.Windows.Forms.Button();
            this.dep = new System.Windows.Forms.Button();
            this.wdl = new System.Windows.Forms.Button();
            this.bal = new System.Windows.Forms.Button();
            this.SCR = new System.Windows.Forms.Label();
            this.passkey = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.B00 = new System.Windows.Forms.Button();
            this.no1 = new System.Windows.Forms.Button();
            this.no2 = new System.Windows.Forms.Button();
            this.BCEL = new System.Windows.Forms.Button();
            this.BCLR = new System.Windows.Forms.Button();
            this.BENR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SCR);
            this.panel1.Controls.Add(this.passkey);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 264);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(461, 175);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(155, 58);
            this.exit.TabIndex = 22;
            this.exit.Text = "(5)取消交易";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // cha
            // 
            this.cha.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cha.Location = new System.Drawing.Point(461, 22);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(155, 58);
            this.cha.TabIndex = 21;
            this.cha.Text = "(4)更改密碼";
            this.cha.UseVisualStyleBackColor = true;
            // 
            // dep
            // 
            this.dep.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dep.Location = new System.Drawing.Point(15, 175);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(159, 58);
            this.dep.TabIndex = 20;
            this.dep.Text = "(3)存款";
            this.dep.UseVisualStyleBackColor = true;
            // 
            // wdl
            // 
            this.wdl.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wdl.Location = new System.Drawing.Point(15, 97);
            this.wdl.Name = "wdl";
            this.wdl.Size = new System.Drawing.Size(159, 58);
            this.wdl.TabIndex = 19;
            this.wdl.Text = "(2)提款";
            this.wdl.UseVisualStyleBackColor = true;
            // 
            // bal
            // 
            this.bal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bal.Location = new System.Drawing.Point(15, 22);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(159, 58);
            this.bal.TabIndex = 18;
            this.bal.Text = "(1)餘額查詢";
            this.bal.UseVisualStyleBackColor = true;
            // 
            // SCR
            // 
            this.SCR.AutoSize = true;
            this.SCR.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SCR.Location = new System.Drawing.Point(64, 31);
            this.SCR.Name = "SCR";
            this.SCR.Size = new System.Drawing.Size(461, 47);
            this.SCR.TabIndex = 1;
            this.SCR.Text = "請輸入密碼(初始密碼0000)";
            this.SCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passkey
            // 
            this.passkey.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passkey.Location = new System.Drawing.Point(72, 132);
            this.passkey.Name = "passkey";
            this.passkey.PasswordChar = '＊';
            this.passkey.Size = new System.Drawing.Size(453, 35);
            this.passkey.TabIndex = 0;
            this.passkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passkey.TextChanged += new System.EventHandler(this.passkey_TextChanged);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B1.Location = new System.Drawing.Point(146, 497);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 67);
            this.B1.TabIndex = 2;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B2.Location = new System.Drawing.Point(243, 497);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 67);
            this.B2.TabIndex = 3;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B3.Location = new System.Drawing.Point(338, 497);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 67);
            this.B3.TabIndex = 4;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B4.Location = new System.Drawing.Point(146, 398);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 67);
            this.B4.TabIndex = 5;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B5.Location = new System.Drawing.Point(243, 398);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(75, 67);
            this.B5.TabIndex = 6;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B6.Location = new System.Drawing.Point(338, 398);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(75, 67);
            this.B6.TabIndex = 7;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B7.Location = new System.Drawing.Point(146, 311);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(75, 67);
            this.B7.TabIndex = 8;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B8.Location = new System.Drawing.Point(243, 311);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(75, 67);
            this.B8.TabIndex = 9;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B9.Location = new System.Drawing.Point(338, 311);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(75, 67);
            this.B9.TabIndex = 10;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B0
            // 
            this.B0.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B0.Location = new System.Drawing.Point(243, 596);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(75, 67);
            this.B0.TabIndex = 11;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // B00
            // 
            this.B00.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.B00.Location = new System.Drawing.Point(338, 596);
            this.B00.Name = "B00";
            this.B00.Size = new System.Drawing.Size(75, 67);
            this.B00.TabIndex = 12;
            this.B00.Text = "00";
            this.B00.UseVisualStyleBackColor = true;
            this.B00.Click += new System.EventHandler(this.B00_Click);
            // 
            // no1
            // 
            this.no1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.no1.Enabled = false;
            this.no1.Location = new System.Drawing.Point(146, 596);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(75, 67);
            this.no1.TabIndex = 13;
            this.no1.UseVisualStyleBackColor = false;
            // 
            // no2
            // 
            this.no2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.no2.Enabled = false;
            this.no2.Location = new System.Drawing.Point(436, 596);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(120, 67);
            this.no2.TabIndex = 14;
            this.no2.UseVisualStyleBackColor = false;
            // 
            // BCEL
            // 
            this.BCEL.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BCEL.ForeColor = System.Drawing.Color.Red;
            this.BCEL.Location = new System.Drawing.Point(436, 311);
            this.BCEL.Name = "BCEL";
            this.BCEL.Size = new System.Drawing.Size(120, 67);
            this.BCEL.TabIndex = 15;
            this.BCEL.Text = "取消\r\nCENCEL\r\n";
            this.BCEL.UseVisualStyleBackColor = true;
            this.BCEL.Click += new System.EventHandler(this.BCEL_Click);
            // 
            // BCLR
            // 
            this.BCLR.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BCLR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BCLR.Location = new System.Drawing.Point(436, 408);
            this.BCLR.Name = "BCLR";
            this.BCLR.Size = new System.Drawing.Size(120, 67);
            this.BCLR.TabIndex = 16;
            this.BCLR.Text = "訂正\r\nCLEAR\r\n";
            this.BCLR.UseVisualStyleBackColor = true;
            this.BCLR.Click += new System.EventHandler(this.BCLR_Click);
            // 
            // BENR
            // 
            this.BENR.BackColor = System.Drawing.Color.White;
            this.BENR.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BENR.ForeColor = System.Drawing.Color.Green;
            this.BENR.Location = new System.Drawing.Point(436, 497);
            this.BENR.Name = "BENR";
            this.BENR.Size = new System.Drawing.Size(120, 67);
            this.BENR.TabIndex = 17;
            this.BENR.Text = "確認\r\nENTER";
            this.BENR.UseVisualStyleBackColor = false;
            this.BENR.Click += new System.EventHandler(this.BENR_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cha);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.bal);
            this.panel2.Controls.Add(this.wdl);
            this.panel2.Controls.Add(this.dep);
            this.panel2.Location = new System.Drawing.Point(29, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 264);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BENR);
            this.Controls.Add(this.BCLR);
            this.Controls.Add(this.BCEL);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.B00);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SCR;
        private System.Windows.Forms.TextBox passkey;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B00;
        private System.Windows.Forms.Button no1;
        private System.Windows.Forms.Button no2;
        private System.Windows.Forms.Button BCEL;
        private System.Windows.Forms.Button BCLR;
        private System.Windows.Forms.Button BENR;
        private System.Windows.Forms.Button bal;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button cha;
        private System.Windows.Forms.Button dep;
        private System.Windows.Forms.Button wdl;
        private System.Windows.Forms.Panel panel2;
    }
}

