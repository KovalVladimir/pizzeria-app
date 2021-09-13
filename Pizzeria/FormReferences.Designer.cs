
namespace TextAnalyzer2
{
    partial class FormReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReference));
            this.lblReferences = new System.Windows.Forms.Label();
            this.pbPizza3 = new System.Windows.Forms.PictureBox();
            this.pbPizza2 = new System.Windows.Forms.PictureBox();
            this.pbPizza1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblReferences.Location = new System.Drawing.Point(0, 0);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(922, 276);
            this.lblReferences.TabIndex = 0;
            this.lblReferences.Text = resources.GetString("lblReferences.Text");
            // 
            // pbPizza3
            // 
            this.pbPizza3.Image = ((System.Drawing.Image)(resources.GetObject("pbPizza3.Image")));
            this.pbPizza3.Location = new System.Drawing.Point(12, 292);
            this.pbPizza3.Name = "pbPizza3";
            this.pbPizza3.Size = new System.Drawing.Size(227, 137);
            this.pbPizza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza3.TabIndex = 1;
            this.pbPizza3.TabStop = false;
            // 
            // pbPizza2
            // 
            this.pbPizza2.Image = ((System.Drawing.Image)(resources.GetObject("pbPizza2.Image")));
            this.pbPizza2.Location = new System.Drawing.Point(336, 292);
            this.pbPizza2.Name = "pbPizza2";
            this.pbPizza2.Size = new System.Drawing.Size(227, 137);
            this.pbPizza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza2.TabIndex = 2;
            this.pbPizza2.TabStop = false;
            // 
            // pbPizza1
            // 
            this.pbPizza1.Image = ((System.Drawing.Image)(resources.GetObject("pbPizza1.Image")));
            this.pbPizza1.Location = new System.Drawing.Point(645, 292);
            this.pbPizza1.MaximumSize = new System.Drawing.Size(227, 137);
            this.pbPizza1.MinimumSize = new System.Drawing.Size(227, 137);
            this.pbPizza1.Name = "pbPizza1";
            this.pbPizza1.Size = new System.Drawing.Size(227, 137);
            this.pbPizza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza1.TabIndex = 3;
            this.pbPizza1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(361, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 64);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(925, 534);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbPizza1);
            this.Controls.Add(this.pbPizza2);
            this.Controls.Add(this.pbPizza3);
            this.Controls.Add(this.lblReferences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReference";
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.PictureBox pbPizza3;
        private System.Windows.Forms.PictureBox pbPizza2;
        private System.Windows.Forms.PictureBox pbPizza1;
        private System.Windows.Forms.Button btnClose;
    }
}