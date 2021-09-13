
namespace TextAnalyzer2
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.pbPizza5 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbPizza4 = new System.Windows.Forms.PictureBox();
            this.pbFootHunter = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFootHunter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPizza5
            // 
            this.pbPizza5.Image = ((System.Drawing.Image)(resources.GetObject("pbPizza5.Image")));
            this.pbPizza5.Location = new System.Drawing.Point(531, -3);
            this.pbPizza5.Name = "pbPizza5";
            this.pbPizza5.Size = new System.Drawing.Size(227, 137);
            this.pbPizza5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza5.TabIndex = 0;
            this.pbPizza5.TabStop = false;
            this.pbPizza5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(12, 137);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(746, 234);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // pbPizza4
            // 
            this.pbPizza4.Image = ((System.Drawing.Image)(resources.GetObject("pbPizza4.Image")));
            this.pbPizza4.Location = new System.Drawing.Point(12, -3);
            this.pbPizza4.Name = "pbPizza4";
            this.pbPizza4.Size = new System.Drawing.Size(208, 137);
            this.pbPizza4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza4.TabIndex = 2;
            this.pbPizza4.TabStop = false;
            // 
            // pbFootHunter
            // 
            this.pbFootHunter.Image = ((System.Drawing.Image)(resources.GetObject("pbFootHunter.Image")));
            this.pbFootHunter.Location = new System.Drawing.Point(226, -3);
            this.pbFootHunter.Name = "pbFootHunter";
            this.pbFootHunter.Size = new System.Drawing.Size(287, 137);
            this.pbFootHunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFootHunter.TabIndex = 3;
            this.pbFootHunter.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(284, 374);
            this.btnClose.MaximumSize = new System.Drawing.Size(177, 64);
            this.btnClose.MinimumSize = new System.Drawing.Size(177, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 64);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbFootHunter);
            this.Controls.Add(this.pbPizza4);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbPizza5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormInfo";
            this.Text = "О нас";
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFootHunter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPizza5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPizza4;
        private System.Windows.Forms.PictureBox pbFootHunter;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;
    }
}