namespace BatteryStatus
{
    partial class MainFrm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.batteryCaption = new System.Windows.Forms.Label();
            this.batteryCharge = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.batteryRuntime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batteryInstalled = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.batteryVoltage = new System.Windows.Forms.Label();
            this.batteryCapacity = new System.Windows.Forms.Label();
            this.batteryStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.batteryMaxRecharge = new System.Windows.Forms.Label();
            this.batteryFCharge = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.batteryExpectedLife = new System.Windows.Forms.Label();
            this.batteryExpectedBLife = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.batteryTimeToFull = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.batteryCaption);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 68);
            this.panel1.TabIndex = 0;
            // 
            // batteryCaption
            // 
            this.batteryCaption.AutoSize = true;
            this.batteryCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryCaption.ForeColor = System.Drawing.Color.White;
            this.batteryCaption.Location = new System.Drawing.Point(12, 19);
            this.batteryCaption.Name = "batteryCaption";
            this.batteryCaption.Size = new System.Drawing.Size(230, 30);
            this.batteryCaption.TabIndex = 0;
            this.batteryCaption.Text = "Win32_Battery[Caption]";
            // 
            // batteryCharge
            // 
            this.batteryCharge.BackColor = System.Drawing.Color.White;
            this.batteryCharge.Location = new System.Drawing.Point(12, 392);
            this.batteryCharge.Name = "batteryCharge";
            this.batteryCharge.Size = new System.Drawing.Size(400, 23);
            this.batteryCharge.TabIndex = 8;
            this.batteryCharge.Value = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Charge Remaining:";
            // 
            // batteryRuntime
            // 
            this.batteryRuntime.AutoSize = true;
            this.batteryRuntime.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryRuntime.ForeColor = System.Drawing.Color.Black;
            this.batteryRuntime.Location = new System.Drawing.Point(33, 318);
            this.batteryRuntime.Name = "batteryRuntime";
            this.batteryRuntime.Size = new System.Drawing.Size(330, 30);
            this.batteryRuntime.TabIndex = 1;
            this.batteryRuntime.Text = "Win32_Battery[EstimatedRunTime]";
            this.batteryRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Full Charge Capacity:";
            this.label6.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max Recharge Time:";
            this.label8.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.batteryInstalled);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.batteryVoltage);
            this.groupBox1.Controls.Add(this.batteryCapacity);
            this.groupBox1.Controls.Add(this.batteryStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battery Informations";
            // 
            // batteryInstalled
            // 
            this.batteryInstalled.AutoSize = true;
            this.batteryInstalled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryInstalled.Location = new System.Drawing.Point(148, 57);
            this.batteryInstalled.Name = "batteryInstalled";
            this.batteryInstalled.Size = new System.Drawing.Size(142, 13);
            this.batteryInstalled.TabIndex = 16;
            this.batteryInstalled.Text = "Win32_Battery[InstallDate]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Install Date:";
            this.label7.UseMnemonic = false;
            // 
            // batteryVoltage
            // 
            this.batteryVoltage.AutoSize = true;
            this.batteryVoltage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryVoltage.Location = new System.Drawing.Point(148, 44);
            this.batteryVoltage.Name = "batteryVoltage";
            this.batteryVoltage.Size = new System.Drawing.Size(165, 13);
            this.batteryVoltage.TabIndex = 14;
            this.batteryVoltage.Text = "Win32_Battery[Design Voltage]";
            // 
            // batteryCapacity
            // 
            this.batteryCapacity.AutoSize = true;
            this.batteryCapacity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryCapacity.Location = new System.Drawing.Point(148, 31);
            this.batteryCapacity.Name = "batteryCapacity";
            this.batteryCapacity.Size = new System.Drawing.Size(169, 13);
            this.batteryCapacity.TabIndex = 13;
            this.batteryCapacity.Text = "Win32_Battery[Design Capacity]";
            // 
            // batteryStatus
            // 
            this.batteryStatus.AutoSize = true;
            this.batteryStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryStatus.Location = new System.Drawing.Point(148, 18);
            this.batteryStatus.Name = "batteryStatus";
            this.batteryStatus.Size = new System.Drawing.Size(119, 13);
            this.batteryStatus.TabIndex = 12;
            this.batteryStatus.Text = "Win32_Battery[Status]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Design Voltage:";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Design Capacity:";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.batteryTimeToFull);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.batteryMaxRecharge);
            this.groupBox2.Controls.Add(this.batteryFCharge);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(11, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 69);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charging Informations";
            // 
            // batteryMaxRecharge
            // 
            this.batteryMaxRecharge.AutoSize = true;
            this.batteryMaxRecharge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryMaxRecharge.Location = new System.Drawing.Point(149, 31);
            this.batteryMaxRecharge.Name = "batteryMaxRecharge";
            this.batteryMaxRecharge.Size = new System.Drawing.Size(179, 13);
            this.batteryMaxRecharge.TabIndex = 18;
            this.batteryMaxRecharge.Text = "Win32_Battery[MaxRechargeTime]";
            // 
            // batteryFCharge
            // 
            this.batteryFCharge.AutoSize = true;
            this.batteryFCharge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryFCharge.Location = new System.Drawing.Point(149, 18);
            this.batteryFCharge.Name = "batteryFCharge";
            this.batteryFCharge.Size = new System.Drawing.Size(186, 13);
            this.batteryFCharge.TabIndex = 17;
            this.batteryFCharge.Text = "Win32_Battery[FullChargeCapacity]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.batteryExpectedLife);
            this.groupBox3.Controls.Add(this.batteryExpectedBLife);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 57);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Battery Life Data";
            // 
            // batteryExpectedLife
            // 
            this.batteryExpectedLife.AutoSize = true;
            this.batteryExpectedLife.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryExpectedLife.Location = new System.Drawing.Point(148, 31);
            this.batteryExpectedLife.Name = "batteryExpectedLife";
            this.batteryExpectedLife.Size = new System.Drawing.Size(151, 13);
            this.batteryExpectedLife.TabIndex = 20;
            this.batteryExpectedLife.Text = "Win32_Battery[ExpectedLife]";
            // 
            // batteryExpectedBLife
            // 
            this.batteryExpectedBLife.AutoSize = true;
            this.batteryExpectedBLife.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryExpectedBLife.Location = new System.Drawing.Point(148, 18);
            this.batteryExpectedBLife.Name = "batteryExpectedBLife";
            this.batteryExpectedBLife.Size = new System.Drawing.Size(187, 13);
            this.batteryExpectedBLife.TabIndex = 19;
            this.batteryExpectedBLife.Text = "Win32_Battery[ExpectedBatteryLife]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Expected Battery Life: ";
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Expected Life:";
            this.label10.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(337, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Time to Full Charge:";
            this.label11.UseMnemonic = false;
            // 
            // batteryTimeToFull
            // 
            this.batteryTimeToFull.AutoSize = true;
            this.batteryTimeToFull.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryTimeToFull.Location = new System.Drawing.Point(149, 44);
            this.batteryTimeToFull.Name = "batteryTimeToFull";
            this.batteryTimeToFull.Size = new System.Drawing.Size(177, 13);
            this.batteryTimeToFull.TabIndex = 20;
            this.batteryTimeToFull.Text = "Win32_Battery[TimeToFullCharge]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Estimated Battery Runtime:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 465);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batteryRuntime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.batteryCharge);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Battery Status ver. 0.1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label batteryCaption;
        private System.Windows.Forms.ProgressBar batteryCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batteryRuntime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label batteryInstalled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label batteryVoltage;
        private System.Windows.Forms.Label batteryCapacity;
        private System.Windows.Forms.Label batteryStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label batteryFCharge;
        private System.Windows.Forms.Label batteryMaxRecharge;
        private System.Windows.Forms.Label batteryExpectedLife;
        private System.Windows.Forms.Label batteryExpectedBLife;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label batteryTimeToFull;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

