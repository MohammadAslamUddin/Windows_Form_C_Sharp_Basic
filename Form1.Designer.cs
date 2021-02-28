namespace WindowsFormApp
{
    partial class MainUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.anotherButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.work2 = new System.Windows.Forms.GroupBox();
            this.work1 = new System.Windows.Forms.GroupBox();
            this.work3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.work2.SuspendLayout();
            this.work1.SuspendLayout();
            this.work3.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(27, 29);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 41);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // anotherButton
            // 
            this.anotherButton.Location = new System.Drawing.Point(27, 91);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(155, 41);
            this.anotherButton.TabIndex = 0;
            this.anotherButton.Text = "Another Button";
            this.anotherButton.UseVisualStyleBackColor = true;
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(73, 89);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(114, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(178, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // work2
            // 
            this.work2.Controls.Add(this.nameTextBox);
            this.work2.Controls.Add(this.label1);
            this.work2.Controls.Add(this.displayButton);
            this.work2.Location = new System.Drawing.Point(298, 12);
            this.work2.Name = "work2";
            this.work2.Size = new System.Drawing.Size(281, 193);
            this.work2.TabIndex = 4;
            this.work2.TabStop = false;
            this.work2.Text = "Work-2";
            // 
            // work1
            // 
            this.work1.Controls.Add(this.showButton);
            this.work1.Controls.Add(this.anotherButton);
            this.work1.Location = new System.Drawing.Point(30, 12);
            this.work1.Name = "work1";
            this.work1.Size = new System.Drawing.Size(253, 193);
            this.work1.TabIndex = 5;
            this.work1.TabStop = false;
            this.work1.Text = "Work-1";
            // 
            // work3
            // 
            this.work3.Controls.Add(this.divisionButton);
            this.work3.Controls.Add(this.multipleButton);
            this.work3.Controls.Add(this.subButton);
            this.work3.Controls.Add(this.addButton);
            this.work3.Controls.Add(this.resultTextBox);
            this.work3.Controls.Add(this.label5);
            this.work3.Controls.Add(this.secondNumberTextBox);
            this.work3.Controls.Add(this.label6);
            this.work3.Controls.Add(this.firstNumberTextBox);
            this.work3.Controls.Add(this.label7);
            this.work3.Location = new System.Drawing.Point(595, 12);
            this.work3.Name = "work3";
            this.work3.Size = new System.Drawing.Size(302, 193);
            this.work3.TabIndex = 6;
            this.work3.TabStop = false;
            this.work3.Text = "Work-3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(110, 26);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Second Number";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(110, 62);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(110, 139);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(163, 20);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(233, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(177, 100);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(50, 23);
            this.subButton.TabIndex = 2;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multipleButton
            // 
            this.multipleButton.Location = new System.Drawing.Point(121, 100);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(50, 23);
            this.multipleButton.TabIndex = 2;
            this.multipleButton.Text = "*";
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(65, 100);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(50, 23);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 646);
            this.Controls.Add(this.work3);
            this.Controls.Add(this.work1);
            this.Controls.Add(this.work2);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.work2.ResumeLayout(false);
            this.work2.PerformLayout();
            this.work1.ResumeLayout(false);
            this.work3.ResumeLayout(false);
            this.work3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button anotherButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox work2;
        private System.Windows.Forms.GroupBox work1;
        private System.Windows.Forms.GroupBox work3;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label7;
    }
}

