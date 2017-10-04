namespace Versions
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
            this.buttonSay = new System.Windows.Forms.Button();
            this.textBoxHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSay
            // 
            this.buttonSay.Location = new System.Drawing.Point(12, 12);
            this.buttonSay.Name = "buttonSay";
            this.buttonSay.Size = new System.Drawing.Size(75, 23);
            this.buttonSay.TabIndex = 0;
            this.buttonSay.Text = "&Say...";
            this.buttonSay.UseVisualStyleBackColor = true;
            this.buttonSay.Click += new System.EventHandler(this.buttonSay_Click);
            // 
            // textBoxHello
            // 
            this.textBoxHello.Location = new System.Drawing.Point(109, 14);
            this.textBoxHello.Name = "textBoxHello";
            this.textBoxHello.Size = new System.Drawing.Size(163, 20);
            this.textBoxHello.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textBoxHello);
            this.Controls.Add(this.buttonSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSay;
        private System.Windows.Forms.TextBox textBoxHello;

    }
}

