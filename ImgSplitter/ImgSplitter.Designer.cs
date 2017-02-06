namespace ImgSplitter
{
    partial class ImgSplitter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_fichier = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.bt_choosePath = new System.Windows.Forms.Button();
            this.bt_split = new System.Windows.Forms.Button();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.tb_Width = new System.Windows.Forms.TextBox();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_fichier
            // 
            this.lbl_fichier.AutoSize = true;
            this.lbl_fichier.Location = new System.Drawing.Point(9, 13);
            this.lbl_fichier.Name = "lbl_fichier";
            this.lbl_fichier.Size = new System.Drawing.Size(44, 13);
            this.lbl_fichier.TabIndex = 0;
            this.lbl_fichier.Text = "Fichier :";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(13, 38);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(41, 13);
            this.lbl_width.TabIndex = 1;
            this.lbl_width.Text = "Width :";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(226, 38);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(44, 13);
            this.lbl_height.TabIndex = 2;
            this.lbl_height.Text = "Height :";
            // 
            // bt_choosePath
            // 
            this.bt_choosePath.Location = new System.Drawing.Point(284, 7);
            this.bt_choosePath.Name = "bt_choosePath";
            this.bt_choosePath.Size = new System.Drawing.Size(95, 23);
            this.bt_choosePath.TabIndex = 3;
            this.bt_choosePath.Text = "Choose";
            this.bt_choosePath.UseVisualStyleBackColor = true;
            this.bt_choosePath.Click += new System.EventHandler(this.bt_choosePath_Click);
            // 
            // bt_split
            // 
            this.bt_split.Location = new System.Drawing.Point(12, 61);
            this.bt_split.Name = "bt_split";
            this.bt_split.Size = new System.Drawing.Size(367, 23);
            this.bt_split.TabIndex = 4;
            this.bt_split.Text = "Split";
            this.bt_split.UseVisualStyleBackColor = true;
            this.bt_split.Click += new System.EventHandler(this.bt_split_Click);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(63, 10);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(207, 20);
            this.tb_filePath.TabIndex = 5;
            // 
            // tb_Width
            // 
            this.tb_Width.Location = new System.Drawing.Point(63, 35);
            this.tb_Width.Name = "tb_Width";
            this.tb_Width.Size = new System.Drawing.Size(100, 20);
            this.tb_Width.TabIndex = 6;
            this.tb_Width.Text = "32";
            // 
            // tb_Height
            // 
            this.tb_Height.Location = new System.Drawing.Point(279, 35);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(100, 20);
            this.tb_Height.TabIndex = 7;
            this.tb_Height.Text = "32";
            // 
            // ImgSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 98);
            this.Controls.Add(this.tb_Height);
            this.Controls.Add(this.tb_Width);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.bt_split);
            this.Controls.Add(this.bt_choosePath);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.lbl_fichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImgSplitter";
            this.Text = "Img Splitter";
            this.Load += new System.EventHandler(this.ImgSplitter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fichier;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button bt_choosePath;
        private System.Windows.Forms.Button bt_split;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.TextBox tb_Width;
        private System.Windows.Forms.TextBox tb_Height;
    }
}

