namespace WindowsFormApp
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
            this.showButton = new System.Windows.Forms.Button();
            this.anotherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(303, 101);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 36);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // anotherButton
            // 
            this.anotherButton.Location = new System.Drawing.Point(303, 196);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(155, 36);
            this.anotherButton.TabIndex = 0;
            this.anotherButton.Text = "Another Button";
            this.anotherButton.UseVisualStyleBackColor = true;
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anotherButton);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button anotherButton;
    }
}

