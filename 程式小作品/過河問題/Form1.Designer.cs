namespace CSForm_river
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Boat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.target = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.S4 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.TextBox();
            this.S5 = new System.Windows.Forms.Button();
            this.S6 = new System.Windows.Forms.Button();
            this.S1 = new System.Windows.Forms.Button();
            this.S3 = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Button();
            this.rule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.S2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Boat
            // 
            this.Boat.BackColor = System.Drawing.Color.Chocolate;
            this.Boat.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Boat.ForeColor = System.Drawing.Color.Navy;
            this.Boat.Location = new System.Drawing.Point(487, 250);
            this.Boat.Name = "Boat";
            this.Boat.Size = new System.Drawing.Size(171, 107);
            this.Boat.TabIndex = 1;
            this.Boat.Text = "船\r\n(選完對象按此即可渡河)";
            this.toolTip1.SetToolTip(this.Boat, "船");
            this.Boat.UseVisualStyleBackColor = false;
            this.Boat.Click += new System.EventHandler(this.Boat_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(311, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(527, 597);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "河");
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.LightYellow;
            this.target.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.target.ForeColor = System.Drawing.Color.Silver;
            this.target.Location = new System.Drawing.Point(472, 65);
            this.target.Multiline = true;
            this.target.Name = "target";
            this.target.ReadOnly = true;
            this.target.Size = new System.Drawing.Size(201, 47);
            this.target.TabIndex = 2;
            this.target.Text = "無";
            this.target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.target, "對象");
            // 
            // p2
            // 
            this.p2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2.ForeColor = System.Drawing.Color.DarkRed;
            this.p2.Location = new System.Drawing.Point(65, 53);
            this.p2.Multiline = true;
            this.p2.Name = "p2";
            this.p2.ReadOnly = true;
            this.p2.Size = new System.Drawing.Size(146, 47);
            this.p2.TabIndex = 4;
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.p2, "玩家位置");
            // 
            // S4
            // 
            this.S4.BackColor = System.Drawing.Color.White;
            this.S4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S4.ForeColor = System.Drawing.Color.DarkGreen;
            this.S4.Location = new System.Drawing.Point(88, 164);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(113, 55);
            this.S4.TabIndex = 6;
            this.toolTip1.SetToolTip(this.S4, "位置");
            this.S4.UseVisualStyleBackColor = false;
            this.S4.Click += new System.EventHandler(this.S4_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Yellow;
            this.p1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1.ForeColor = System.Drawing.Color.DarkRed;
            this.p1.Location = new System.Drawing.Point(929, 53);
            this.p1.Multiline = true;
            this.p1.Name = "p1";
            this.p1.ReadOnly = true;
            this.p1.Size = new System.Drawing.Size(146, 47);
            this.p1.TabIndex = 7;
            this.p1.Text = "獵人";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.p1, "玩家位置");
            // 
            // S5
            // 
            this.S5.BackColor = System.Drawing.Color.White;
            this.S5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S5.ForeColor = System.Drawing.Color.Black;
            this.S5.Location = new System.Drawing.Point(88, 275);
            this.S5.Name = "S5";
            this.S5.Size = new System.Drawing.Size(113, 55);
            this.S5.TabIndex = 11;
            this.toolTip1.SetToolTip(this.S5, "位置");
            this.S5.UseVisualStyleBackColor = false;
            this.S5.Click += new System.EventHandler(this.S5_Click);
            // 
            // S6
            // 
            this.S6.BackColor = System.Drawing.Color.White;
            this.S6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S6.ForeColor = System.Drawing.Color.Chocolate;
            this.S6.Location = new System.Drawing.Point(88, 395);
            this.S6.Name = "S6";
            this.S6.Size = new System.Drawing.Size(113, 55);
            this.S6.TabIndex = 12;
            this.toolTip1.SetToolTip(this.S6, "位置");
            this.S6.UseVisualStyleBackColor = false;
            this.S6.Click += new System.EventHandler(this.S6_Click);
            // 
            // S1
            // 
            this.S1.BackColor = System.Drawing.Color.LightGreen;
            this.S1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S1.ForeColor = System.Drawing.Color.DarkGreen;
            this.S1.Location = new System.Drawing.Point(943, 164);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(113, 55);
            this.S1.TabIndex = 13;
            this.S1.Text = "捲心菜";
            this.toolTip1.SetToolTip(this.S1, "位置");
            this.S1.UseVisualStyleBackColor = false;
            this.S1.Click += new System.EventHandler(this.S1_Click);
            // 
            // S3
            // 
            this.S3.BackColor = System.Drawing.Color.Snow;
            this.S3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S3.ForeColor = System.Drawing.Color.Chocolate;
            this.S3.Location = new System.Drawing.Point(943, 395);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(113, 55);
            this.S3.TabIndex = 15;
            this.S3.Text = "羊";
            this.toolTip1.SetToolTip(this.S3, "位置");
            this.S3.UseVisualStyleBackColor = false;
            this.S3.Click += new System.EventHandler(this.S3_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.LightGreen;
            this.game.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.game.ForeColor = System.Drawing.Color.Red;
            this.game.Location = new System.Drawing.Point(500, 475);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(158, 54);
            this.game.TabIndex = 16;
            this.game.Text = "遊戲開始";
            this.toolTip1.SetToolTip(this.game, "開始/取消");
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // rule
            // 
            this.rule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rule.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rule.ForeColor = System.Drawing.Color.DarkBlue;
            this.rule.Location = new System.Drawing.Point(523, 535);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(111, 41);
            this.rule.TabIndex = 17;
            this.rule.Text = "規則";
            this.toolTip1.SetToolTip(this.rule, "規則");
            this.rule.UseVisualStyleBackColor = false;
            this.rule.Click += new System.EventHandler(this.rule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(481, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "您選擇的對象是";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "當前位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(946, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "當前位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(99, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "對岸";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(964, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "本岸";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // S2
            // 
            this.S2.BackColor = System.Drawing.Color.LightGray;
            this.S2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S2.ForeColor = System.Drawing.Color.Black;
            this.S2.Location = new System.Drawing.Point(943, 275);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(113, 55);
            this.S2.TabIndex = 18;
            this.S2.Text = "狼";
            this.toolTip1.SetToolTip(this.S2, "位置");
            this.S2.UseVisualStyleBackColor = false;
            this.S2.Click += new System.EventHandler(this.S2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 609);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.rule);
            this.Controls.Add(this.game);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.S6);
            this.Controls.Add(this.S5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.target);
            this.Controls.Add(this.Boat);
            this.Controls.Add(this.textBox1);
            this.Name = "Form";
            this.Text = "渡河遊戲";
            this.toolTip1.SetToolTip(this, "渡河遊戲");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Boat;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Button S4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button S5;
        private System.Windows.Forms.Button S6;
        private System.Windows.Forms.Button S1;
        private System.Windows.Forms.Button S3;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Button rule;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button S2;
    }
}

