
namespace numbering_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.input = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultScreen = new System.Windows.Forms.TextBox();
            this.screenType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "to";
            // 
            // fromBox
            // 
            this.fromBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexa Decimal",
            "Octal"});
            this.fromBox.Location = new System.Drawing.Point(76, 104);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(121, 21);
            this.fromBox.TabIndex = 2;
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // toBox
            // 
            this.toBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toBox.FormattingEnabled = true;
            this.toBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexa Decimal",
            "Octal"});
            this.toBox.Location = new System.Drawing.Point(76, 159);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(121, 21);
            this.toBox.TabIndex = 3;
            this.toBox.SelectedIndexChanged += new System.EventHandler(this.toBox_SelectedIndexChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(25, 27);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(327, 39);
            this.input.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(25, 265);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(121, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            // 
            // resultScreen
            // 
            this.resultScreen.Location = new System.Drawing.Point(25, 294);
            this.resultScreen.Multiline = true;
            this.resultScreen.Name = "resultScreen";
            this.resultScreen.Size = new System.Drawing.Size(327, 38);
            this.resultScreen.TabIndex = 6;
            // 
            // screenType
            // 
            this.screenType.Location = new System.Drawing.Point(420, 294);
            this.screenType.Multiline = true;
            this.screenType.Name = "screenType";
            this.screenType.Size = new System.Drawing.Size(121, 38);
            this.screenType.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screenType);
            this.Controls.Add(this.resultScreen);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.input);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox resultScreen;
        private System.Windows.Forms.TextBox screenType;
    }
}

