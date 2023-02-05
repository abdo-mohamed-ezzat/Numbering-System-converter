
namespace numbreing
{
    partial class Numbring
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
            this.group = new System.Windows.Forms.GroupBox();
            this.fromGray = new System.Windows.Forms.RadioButton();
            this.fromBcd = new System.Windows.Forms.RadioButton();
            this.fromOctal = new System.Windows.Forms.RadioButton();
            this.fromHexa = new System.Windows.Forms.RadioButton();
            this.fromDecimal = new System.Windows.Forms.RadioButton();
            this.fromBinary = new System.Windows.Forms.RadioButton();
            this.inputScreen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toGrayCode = new System.Windows.Forms.RadioButton();
            this.toGray = new System.Windows.Forms.RadioButton();
            this.toBcd = new System.Windows.Forms.RadioButton();
            this.toOctal = new System.Windows.Forms.RadioButton();
            this.toHexa = new System.Windows.Forms.RadioButton();
            this.toDecimal = new System.Windows.Forms.RadioButton();
            this.toBinary = new System.Windows.Forms.RadioButton();
            this.resultScreen = new System.Windows.Forms.TextBox();
            this.covertButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.ansButton = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.WhiteSmoke;
            this.group.Controls.Add(this.fromGray);
            this.group.Controls.Add(this.fromBcd);
            this.group.Controls.Add(this.fromOctal);
            this.group.Controls.Add(this.fromHexa);
            this.group.Controls.Add(this.fromDecimal);
            this.group.Controls.Add(this.fromBinary);
            this.group.Controls.Add(this.inputScreen);
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(275, 296);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "from";
            this.group.Enter += new System.EventHandler(this.group_Enter);
            // 
            // fromGray
            // 
            this.fromGray.AutoSize = true;
            this.fromGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromGray.Location = new System.Drawing.Point(8, 255);
            this.fromGray.Name = "fromGray";
            this.fromGray.Size = new System.Drawing.Size(107, 24);
            this.fromGray.TabIndex = 6;
            this.fromGray.TabStop = true;
            this.fromGray.Text = "GrayCode";
            this.fromGray.UseVisualStyleBackColor = true;
            this.fromGray.CheckedChanged += new System.EventHandler(this.fromGray_CheckedChanged);
            // 
            // fromBcd
            // 
            this.fromBcd.AutoSize = true;
            this.fromBcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromBcd.Location = new System.Drawing.Point(8, 217);
            this.fromBcd.Name = "fromBcd";
            this.fromBcd.Size = new System.Drawing.Size(64, 24);
            this.fromBcd.TabIndex = 5;
            this.fromBcd.TabStop = true;
            this.fromBcd.Text = "BCD";
            this.fromBcd.UseVisualStyleBackColor = true;
            this.fromBcd.CheckedChanged += new System.EventHandler(this.fromBCD_CheckedChanged);
            // 
            // fromOctal
            // 
            this.fromOctal.AutoSize = true;
            this.fromOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromOctal.Location = new System.Drawing.Point(8, 181);
            this.fromOctal.Name = "fromOctal";
            this.fromOctal.Size = new System.Drawing.Size(69, 24);
            this.fromOctal.TabIndex = 4;
            this.fromOctal.TabStop = true;
            this.fromOctal.Text = "Octal";
            this.fromOctal.UseVisualStyleBackColor = true;
            this.fromOctal.CheckedChanged += new System.EventHandler(this.fromOctal_CheckedChanged);
            // 
            // fromHexa
            // 
            this.fromHexa.AutoSize = true;
            this.fromHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromHexa.Location = new System.Drawing.Point(6, 148);
            this.fromHexa.Name = "fromHexa";
            this.fromHexa.Size = new System.Drawing.Size(132, 24);
            this.fromHexa.TabIndex = 3;
            this.fromHexa.TabStop = true;
            this.fromHexa.Text = "HexaDecimal";
            this.fromHexa.UseVisualStyleBackColor = true;
            this.fromHexa.CheckedChanged += new System.EventHandler(this.fromHexa_CheckedChanged);
            // 
            // fromDecimal
            // 
            this.fromDecimal.AutoSize = true;
            this.fromDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDecimal.Location = new System.Drawing.Point(7, 114);
            this.fromDecimal.Name = "fromDecimal";
            this.fromDecimal.Size = new System.Drawing.Size(91, 24);
            this.fromDecimal.TabIndex = 2;
            this.fromDecimal.TabStop = true;
            this.fromDecimal.Text = "Decimal";
            this.fromDecimal.UseVisualStyleBackColor = true;
            this.fromDecimal.CheckedChanged += new System.EventHandler(this.fromDecimal_CheckedChanged);
            // 
            // fromBinary
            // 
            this.fromBinary.AutoSize = true;
            this.fromBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromBinary.Location = new System.Drawing.Point(7, 79);
            this.fromBinary.Name = "fromBinary";
            this.fromBinary.Size = new System.Drawing.Size(77, 24);
            this.fromBinary.TabIndex = 1;
            this.fromBinary.TabStop = true;
            this.fromBinary.Text = "Binary";
            this.fromBinary.UseVisualStyleBackColor = true;
            this.fromBinary.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // inputScreen
            // 
            this.inputScreen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputScreen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputScreen.Location = new System.Drawing.Point(7, 19);
            this.inputScreen.Multiline = true;
            this.inputScreen.Name = "inputScreen";
            this.inputScreen.Size = new System.Drawing.Size(262, 43);
            this.inputScreen.TabIndex = 0;
            this.inputScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.toGrayCode);
            this.groupBox2.Controls.Add(this.toGray);
            this.groupBox2.Controls.Add(this.toBcd);
            this.groupBox2.Controls.Add(this.toOctal);
            this.groupBox2.Controls.Add(this.toHexa);
            this.groupBox2.Controls.Add(this.toDecimal);
            this.groupBox2.Controls.Add(this.toBinary);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(293, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "to";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // toGrayCode
            // 
            this.toGrayCode.AutoSize = true;
            this.toGrayCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGrayCode.Location = new System.Drawing.Point(8, 206);
            this.toGrayCode.Name = "toGrayCode";
            this.toGrayCode.Size = new System.Drawing.Size(107, 24);
            this.toGrayCode.TabIndex = 11;
            this.toGrayCode.TabStop = true;
            this.toGrayCode.Text = "GrayCode";
            this.toGrayCode.UseVisualStyleBackColor = true;
            // 
            // toGray
            // 
            this.toGray.AutoSize = true;
            this.toGray.Location = new System.Drawing.Point(15, 255);
            this.toGray.Name = "toGray";
            this.toGray.Size = new System.Drawing.Size(72, 17);
            this.toGray.TabIndex = 10;
            this.toGray.TabStop = true;
            this.toGray.Text = "GrayCode";
            this.toGray.UseVisualStyleBackColor = true;
            // 
            // toBcd
            // 
            this.toBcd.AutoSize = true;
            this.toBcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBcd.Location = new System.Drawing.Point(8, 176);
            this.toBcd.Name = "toBcd";
            this.toBcd.Size = new System.Drawing.Size(64, 24);
            this.toBcd.TabIndex = 9;
            this.toBcd.TabStop = true;
            this.toBcd.Text = "BCD";
            this.toBcd.UseVisualStyleBackColor = true;
            this.toBcd.CheckedChanged += new System.EventHandler(this.toBcd_CheckedChanged);
            // 
            // toOctal
            // 
            this.toOctal.AutoSize = true;
            this.toOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toOctal.Location = new System.Drawing.Point(8, 140);
            this.toOctal.Name = "toOctal";
            this.toOctal.Size = new System.Drawing.Size(69, 24);
            this.toOctal.TabIndex = 8;
            this.toOctal.TabStop = true;
            this.toOctal.Text = "Octal";
            this.toOctal.UseVisualStyleBackColor = true;
            this.toOctal.CheckedChanged += new System.EventHandler(this.toOctal_CheckedChanged);
            // 
            // toHexa
            // 
            this.toHexa.AutoSize = true;
            this.toHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHexa.Location = new System.Drawing.Point(8, 107);
            this.toHexa.Name = "toHexa";
            this.toHexa.Size = new System.Drawing.Size(132, 24);
            this.toHexa.TabIndex = 7;
            this.toHexa.TabStop = true;
            this.toHexa.Text = "HexaDecimal";
            this.toHexa.UseVisualStyleBackColor = true;
            this.toHexa.CheckedChanged += new System.EventHandler(this.toHexa_CheckedChanged);
            // 
            // toDecimal
            // 
            this.toDecimal.AutoSize = true;
            this.toDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDecimal.Location = new System.Drawing.Point(8, 73);
            this.toDecimal.Name = "toDecimal";
            this.toDecimal.Size = new System.Drawing.Size(91, 24);
            this.toDecimal.TabIndex = 6;
            this.toDecimal.TabStop = true;
            this.toDecimal.Text = "Decimal";
            this.toDecimal.UseVisualStyleBackColor = true;
            this.toDecimal.CheckedChanged += new System.EventHandler(this.toDecimal_CheckedChanged);
            // 
            // toBinary
            // 
            this.toBinary.AutoSize = true;
            this.toBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBinary.Location = new System.Drawing.Point(8, 38);
            this.toBinary.Name = "toBinary";
            this.toBinary.Size = new System.Drawing.Size(77, 24);
            this.toBinary.TabIndex = 5;
            this.toBinary.TabStop = true;
            this.toBinary.Text = "Binary";
            this.toBinary.UseVisualStyleBackColor = true;
            this.toBinary.CheckedChanged += new System.EventHandler(this.toBinary_CheckedChanged);
            // 
            // resultScreen
            // 
            this.resultScreen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultScreen.Location = new System.Drawing.Point(67, 314);
            this.resultScreen.Multiline = true;
            this.resultScreen.Name = "resultScreen";
            this.resultScreen.Size = new System.Drawing.Size(386, 40);
            this.resultScreen.TabIndex = 1;
            // 
            // covertButton
            // 
            this.covertButton.BackColor = System.Drawing.Color.DarkOrange;
            this.covertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.covertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covertButton.Location = new System.Drawing.Point(293, 12);
            this.covertButton.Name = "covertButton";
            this.covertButton.Size = new System.Drawing.Size(79, 35);
            this.covertButton.TabIndex = 2;
            this.covertButton.Text = "Convert";
            this.covertButton.UseVisualStyleBackColor = false;
            this.covertButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Linen;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(379, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(74, 35);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ansButton
            // 
            this.ansButton.BackColor = System.Drawing.Color.OldLace;
            this.ansButton.CausesValidation = false;
            this.ansButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ansButton.Location = new System.Drawing.Point(12, 314);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(49, 40);
            this.ansButton.TabIndex = 4;
            this.ansButton.Text = "Ans";
            this.ansButton.UseVisualStyleBackColor = false;
            this.ansButton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Numbring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(469, 371);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.covertButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.group);
            this.Controls.Add(this.resultScreen);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Numbring";
            this.Text = "NUMBRING SYSYTEM";
            this.Load += new System.EventHandler(this.ConvetButton_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button covertButton;
        private System.Windows.Forms.TextBox inputScreen;
        private System.Windows.Forms.TextBox resultScreen;
        private System.Windows.Forms.RadioButton fromOctal;
        private System.Windows.Forms.RadioButton fromHexa;
        private System.Windows.Forms.RadioButton fromDecimal;
        private System.Windows.Forms.RadioButton fromBinary;
        private System.Windows.Forms.RadioButton toOctal;
        private System.Windows.Forms.RadioButton toHexa;
        private System.Windows.Forms.RadioButton toDecimal;
        private System.Windows.Forms.RadioButton toBinary;
        private System.Windows.Forms.RadioButton fromGray;
        private System.Windows.Forms.RadioButton fromBcd;
        private System.Windows.Forms.RadioButton toGray;
        private System.Windows.Forms.RadioButton toBcd;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.RadioButton toGrayCode;
        private System.Windows.Forms.Button ansButton;
    }
}

