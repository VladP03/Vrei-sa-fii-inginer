﻿
namespace InterfataQuestions
{
    partial class FormFinish
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPuncte = new System.Windows.Forms.TextBox();
            this.buttonMain = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUseremail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(301, 328);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPuncte
            // 
            this.textBoxPuncte.Location = new System.Drawing.Point(276, 41);
            this.textBoxPuncte.Name = "textBoxPuncte";
            this.textBoxPuncte.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuncte.TabIndex = 1;
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(301, 231);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(75, 23);
            this.buttonMain.TabIndex = 2;
            this.buttonMain.Text = "Main";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(248, 86);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(165, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxUseremail
            // 
            this.textBoxUseremail.Location = new System.Drawing.Point(248, 143);
            this.textBoxUseremail.Name = "textBoxUseremail";
            this.textBoxUseremail.Size = new System.Drawing.Size(165, 20);
            this.textBoxUseremail.TabIndex = 4;
            // 
            // FormFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUseremail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.textBoxPuncte);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinish";
            this.Text = "FormFinish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPuncte;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUseremail;
    }
}