namespace UnitConverter
{
    partial class Converter
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
            this.ComboUnitType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboUnit = new System.Windows.Forms.ComboBox();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.TxtValue5 = new System.Windows.Forms.TextBox();
            this.TxtValue8 = new System.Windows.Forms.TextBox();
            this.TxtValue4 = new System.Windows.Forms.TextBox();
            this.TxtValue7 = new System.Windows.Forms.TextBox();
            this.TxtValue3 = new System.Windows.Forms.TextBox();
            this.TxtValue6 = new System.Windows.Forms.TextBox();
            this.LblUnit8 = new System.Windows.Forms.Label();
            this.LblUnit5 = new System.Windows.Forms.Label();
            this.LblUnit7 = new System.Windows.Forms.Label();
            this.LblUnit4 = new System.Windows.Forms.Label();
            this.LblUnit6 = new System.Windows.Forms.Label();
            this.LblUnit3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboUnitType
            // 
            this.ComboUnitType.FormattingEnabled = true;
            this.ComboUnitType.Items.AddRange(new object[] {
            "Length",
            "Weight",
            "Volume"});
            this.ComboUnitType.Location = new System.Drawing.Point(45, 47);
            this.ComboUnitType.Name = "ComboUnitType";
            this.ComboUnitType.Size = new System.Drawing.Size(224, 38);
            this.ComboUnitType.TabIndex = 1;
            this.ComboUnitType.SelectedIndexChanged += new System.EventHandler(this.ComboUnitType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Choose Unit Type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.BtnConvert);
            this.groupBox1.Controls.Add(this.TxtValue5);
            this.groupBox1.Controls.Add(this.TxtValue8);
            this.groupBox1.Controls.Add(this.TxtValue4);
            this.groupBox1.Controls.Add(this.TxtValue7);
            this.groupBox1.Controls.Add(this.TxtValue3);
            this.groupBox1.Controls.Add(this.TxtValue6);
            this.groupBox1.Controls.Add(this.LblUnit8);
            this.groupBox1.Controls.Add(this.LblUnit5);
            this.groupBox1.Controls.Add(this.LblUnit7);
            this.groupBox1.Controls.Add(this.LblUnit4);
            this.groupBox1.Controls.Add(this.LblUnit6);
            this.groupBox1.Controls.Add(this.LblUnit3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 402);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Converter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ComboUnit);
            this.panel1.Controls.Add(this.ComboUnitType);
            this.panel1.Controls.Add(this.TxtNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 111);
            this.panel1.TabIndex = 4;
            // 
            // ComboUnit
            // 
            this.ComboUnit.FormattingEnabled = true;
            this.ComboUnit.Location = new System.Drawing.Point(478, 48);
            this.ComboUnit.Name = "ComboUnit";
            this.ComboUnit.Size = new System.Drawing.Size(184, 38);
            this.ComboUnit.TabIndex = 3;
            this.ComboUnit.SelectedIndexChanged += new System.EventHandler(this.ComboUnit_SelectedIndexChanged);
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(302, 47);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(139, 37);
            this.TxtNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Number";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(476, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 23);
            this.label30.TabIndex = 1;
            this.label30.Text = "Choose Unit";
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.Location = new System.Drawing.Point(296, 336);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 40);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.AutoSize = true;
            this.BtnConvert.Location = new System.Drawing.Point(52, 336);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(120, 40);
            this.BtnConvert.TabIndex = 11;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // TxtValue5
            // 
            this.TxtValue5.Enabled = false;
            this.TxtValue5.Location = new System.Drawing.Point(484, 195);
            this.TxtValue5.Name = "TxtValue5";
            this.TxtValue5.Size = new System.Drawing.Size(184, 37);
            this.TxtValue5.TabIndex = 7;
            // 
            // TxtValue8
            // 
            this.TxtValue8.Enabled = false;
            this.TxtValue8.Location = new System.Drawing.Point(484, 270);
            this.TxtValue8.Name = "TxtValue8";
            this.TxtValue8.Size = new System.Drawing.Size(184, 37);
            this.TxtValue8.TabIndex = 10;
            // 
            // TxtValue4
            // 
            this.TxtValue4.Enabled = false;
            this.TxtValue4.Location = new System.Drawing.Point(268, 195);
            this.TxtValue4.Name = "TxtValue4";
            this.TxtValue4.Size = new System.Drawing.Size(184, 37);
            this.TxtValue4.TabIndex = 6;
            // 
            // TxtValue7
            // 
            this.TxtValue7.Enabled = false;
            this.TxtValue7.Location = new System.Drawing.Point(267, 270);
            this.TxtValue7.Name = "TxtValue7";
            this.TxtValue7.Size = new System.Drawing.Size(184, 37);
            this.TxtValue7.TabIndex = 9;
            // 
            // TxtValue3
            // 
            this.TxtValue3.Enabled = false;
            this.TxtValue3.Location = new System.Drawing.Point(52, 195);
            this.TxtValue3.Name = "TxtValue3";
            this.TxtValue3.Size = new System.Drawing.Size(184, 37);
            this.TxtValue3.TabIndex = 5;
            // 
            // TxtValue6
            // 
            this.TxtValue6.Enabled = false;
            this.TxtValue6.Location = new System.Drawing.Point(52, 270);
            this.TxtValue6.Name = "TxtValue6";
            this.TxtValue6.Size = new System.Drawing.Size(184, 37);
            this.TxtValue6.TabIndex = 8;
            // 
            // LblUnit8
            // 
            this.LblUnit8.AutoSize = true;
            this.LblUnit8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit8.Location = new System.Drawing.Point(480, 241);
            this.LblUnit8.Name = "LblUnit8";
            this.LblUnit8.Size = new System.Drawing.Size(85, 23);
            this.LblUnit8.TabIndex = 1;
            this.LblUnit8.Text = "Choose";
            // 
            // LblUnit5
            // 
            this.LblUnit5.AutoSize = true;
            this.LblUnit5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit5.Location = new System.Drawing.Point(479, 166);
            this.LblUnit5.Name = "LblUnit5";
            this.LblUnit5.Size = new System.Drawing.Size(85, 23);
            this.LblUnit5.TabIndex = 1;
            this.LblUnit5.Text = "Choose";
            // 
            // LblUnit7
            // 
            this.LblUnit7.AutoSize = true;
            this.LblUnit7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit7.Location = new System.Drawing.Point(262, 241);
            this.LblUnit7.Name = "LblUnit7";
            this.LblUnit7.Size = new System.Drawing.Size(85, 23);
            this.LblUnit7.TabIndex = 1;
            this.LblUnit7.Text = "Choose";
            // 
            // LblUnit4
            // 
            this.LblUnit4.AutoSize = true;
            this.LblUnit4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit4.Location = new System.Drawing.Point(263, 166);
            this.LblUnit4.Name = "LblUnit4";
            this.LblUnit4.Size = new System.Drawing.Size(85, 23);
            this.LblUnit4.TabIndex = 1;
            this.LblUnit4.Text = "Choose";
            // 
            // LblUnit6
            // 
            this.LblUnit6.AutoSize = true;
            this.LblUnit6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit6.Location = new System.Drawing.Point(47, 241);
            this.LblUnit6.Name = "LblUnit6";
            this.LblUnit6.Size = new System.Drawing.Size(85, 23);
            this.LblUnit6.TabIndex = 1;
            this.LblUnit6.Text = "Choose";
            // 
            // LblUnit3
            // 
            this.LblUnit3.AutoSize = true;
            this.LblUnit3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit3.Location = new System.Drawing.Point(47, 166);
            this.LblUnit3.Name = "LblUnit3";
            this.LblUnit3.Size = new System.Drawing.Size(85, 23);
            this.LblUnit3.TabIndex = 1;
            this.LblUnit3.Text = "Choose";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboUnitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TxtValue3;
        private System.Windows.Forms.Label LblUnit3;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.TextBox TxtValue5;
        private System.Windows.Forms.TextBox TxtValue8;
        private System.Windows.Forms.TextBox TxtValue4;
        private System.Windows.Forms.TextBox TxtValue7;
        private System.Windows.Forms.TextBox TxtValue6;
        private System.Windows.Forms.Label LblUnit8;
        private System.Windows.Forms.Label LblUnit5;
        private System.Windows.Forms.Label LblUnit7;
        private System.Windows.Forms.Label LblUnit4;
        private System.Windows.Forms.Label LblUnit6;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboUnit;
    }
}