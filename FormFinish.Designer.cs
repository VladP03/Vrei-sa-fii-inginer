
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinish));
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPuncte = new System.Windows.Forms.TextBox();
            this.buttonMain = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPuncte = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonExit.Location = new System.Drawing.Point(367, 329);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 32);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPuncte
            // 
            this.textBoxPuncte.BackColor = System.Drawing.Color.White;
            this.textBoxPuncte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPuncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuncte.ForeColor = System.Drawing.Color.DeepPink;
            this.textBoxPuncte.Location = new System.Drawing.Point(344, 103);
            this.textBoxPuncte.Name = "textBoxPuncte";
            this.textBoxPuncte.Size = new System.Drawing.Size(117, 28);
            this.textBoxPuncte.TabIndex = 1;
            this.textBoxPuncte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPuncte.TextChanged += new System.EventHandler(this.textBoxPuncte_TextChanged);
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.Transparent;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonMain.Location = new System.Drawing.Point(338, 260);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(133, 34);
            this.buttonMain.TabIndex = 2;
            this.buttonMain.Text = "Main";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.DeepPink;
            this.textBoxUsername.Location = new System.Drawing.Point(294, 194);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(217, 28);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPuncte
            // 
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.BackColor = System.Drawing.Color.Transparent;
            this.labelPuncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuncte.ForeColor = System.Drawing.Color.DeepPink;
            this.labelPuncte.Location = new System.Drawing.Point(358, 74);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(80, 26);
            this.labelPuncte.TabIndex = 5;
            this.labelPuncte.Text = "Puncte";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DeepPink;
            this.labelUsername.Location = new System.Drawing.Point(370, 165);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 29);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "User";
            // 
            // FormFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.textBoxPuncte);
            this.Controls.Add(this.buttonExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFinish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPuncte;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPuncte;
        private System.Windows.Forms.Label labelUsername;
    }
}