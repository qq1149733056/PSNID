namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wifiname = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wifipwd = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pinid = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.psnidname = new System.Windows.Forms.Label();
            this.getID = new System.Windows.Forms.Button();
            this.device = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click here to set up your PSN account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "WIFI account 2.4G";
            // 
            // wifiname
            // 
            this.wifiname.Location = new System.Drawing.Point(132, 351);
            this.wifiname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wifiname.Name = "wifiname";
            this.wifiname.Size = new System.Drawing.Size(406, 23);
            this.wifiname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "WIFI password 2.4G";
            // 
            // wifipwd
            // 
            this.wifipwd.Location = new System.Drawing.Point(132, 387);
            this.wifipwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wifipwd.Name = "wifipwd";
            this.wifipwd.Size = new System.Drawing.Size(406, 23);
            this.wifipwd.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pinid
            // 
            this.pinid.Location = new System.Drawing.Point(51, 455);
            this.pinid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pinid.Name = "pinid";
            this.pinid.Size = new System.Drawing.Size(468, 23);
            this.pinid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(46, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please input the wifi account and password of the same network adapter as the PS5" +
    " console";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox2.Location = new System.Drawing.Point(48, 201);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(471, 23);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(393, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "PSNID:";
            // 
            // psnidname
            // 
            this.psnidname.AutoSize = true;
            this.psnidname.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psnidname.Location = new System.Drawing.Point(486, 266);
            this.psnidname.Name = "psnidname";
            this.psnidname.Size = new System.Drawing.Size(52, 28);
            this.psnidname.TabIndex = 11;
            this.psnidname.Text = "null";
            this.psnidname.Click += new System.EventHandler(this.psnidname_Click);
            // 
            // getID
            // 
            this.getID.Location = new System.Drawing.Point(49, 262);
            this.getID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(338, 34);
            this.getID.TabIndex = 12;
            this.getID.Text = "Click here after pasting successfully";
            this.getID.UseVisualStyleBackColor = true;
            this.getID.Click += new System.EventHandler(this.getID_Click);
            // 
            // device
            // 
            this.device.AutoSize = true;
            this.device.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.device.ForeColor = System.Drawing.Color.Red;
            this.device.Location = new System.Drawing.Point(404, 24);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(63, 28);
            this.device.TabIndex = 13;
            this.device.Text = "none";
            this.device.Click += new System.EventHandler(this.device_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Please connect PS5 via WIFI or cable network";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "To avoid PS5 network instability";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(494, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "We strongly recommend that PS5 consoles have a wired  connection to the Internet";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(46, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(557, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "First, connect joypad with the USB port of Windows PC, it will enter the configur" +
    "ation mode ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(9, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(9, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(10, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "4";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(49, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(375, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Website style is \"https://remoteplay.dl.playstation.net/ * * * * *\" ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(10, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "3";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(45, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(551, 35);
            this.label14.TabIndex = 23;
            this.label14.Text = "Input the same PSN account and password you used to log into PS5, After loginning" +
    " successfully, copy and paste the \"Full URL\" in the bottom. CTRL+V";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(10, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 30);
            this.label15.TabIndex = 24;
            this.label15.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(9, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 30);
            this.label16.TabIndex = 25;
            this.label16.Text = "6";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(49, 414);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "PS5 console eight-digit matching code ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(49, 482);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(371, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Please fill in the eight digits displayed, the format is: 12345678";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(9, 506);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 30);
            this.label19.TabIndex = 28;
            this.label19.Text = "7";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.device);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pinid);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.wifipwd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wifiname);
            this.groupBox1.Controls.Add(this.psnidname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.getID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(643, 558);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "config";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(47, 433);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(590, 18);
            this.label22.TabIndex = 29;
            this.label22.Text = "Choose from the ps5 system (Settings > System> Remote Play (Enable Remote Play) >" +
    " Link Device)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(675, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(364, 704);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "updata";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(59, 558);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "更新进度";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 551);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 33);
            this.progressBar1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 358);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 103);
            this.button4.TabIndex = 2;
            this.button4.Text = "恢复出厂";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 101);
            this.button3.TabIndex = 1;
            this.button3.Text = "升级";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(134, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "升级/还原";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "JOYPAD CONFIG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox wifiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox wifipwd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox pinid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label psnidname;
        private System.Windows.Forms.Button getID;
        private System.Windows.Forms.Label device;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

