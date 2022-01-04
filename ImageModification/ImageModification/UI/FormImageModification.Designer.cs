
namespace ImageModification
{
    partial class FormImageModification
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonMiamiFilter = new System.Windows.Forms.Button();
            this.buttonBlackWhiteFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSwapFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPrewitt3x3Horizontal = new System.Windows.Forms.Button();
            this.buttonSobel3x3Vertical = new System.Windows.Forms.Button();
            this.buttonLaplacian3x3 = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(412, 473);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset Filter";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(31, 473);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 36;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Image";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(31, 98);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(456, 355);
            this.pictureBoxPreview.TabIndex = 37;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonMiamiFilter
            // 
            this.buttonMiamiFilter.Location = new System.Drawing.Point(50, 89);
            this.buttonMiamiFilter.Name = "buttonMiamiFilter";
            this.buttonMiamiFilter.Size = new System.Drawing.Size(121, 30);
            this.buttonMiamiFilter.TabIndex = 34;
            this.buttonMiamiFilter.Text = "Miami Filter";
            this.buttonMiamiFilter.UseVisualStyleBackColor = true;
            this.buttonMiamiFilter.Click += new System.EventHandler(this.buttonMiamiFilter_Click);
            // 
            // buttonBlackWhiteFilter
            // 
            this.buttonBlackWhiteFilter.Location = new System.Drawing.Point(50, 41);
            this.buttonBlackWhiteFilter.Name = "buttonBlackWhiteFilter";
            this.buttonBlackWhiteFilter.Size = new System.Drawing.Size(121, 30);
            this.buttonBlackWhiteFilter.TabIndex = 33;
            this.buttonBlackWhiteFilter.Text = "Black and White";
            this.buttonBlackWhiteFilter.UseVisualStyleBackColor = true;
            this.buttonBlackWhiteFilter.Click += new System.EventHandler(this.buttonBlackWhiteFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSwapFilter);
            this.groupBox1.Controls.Add(this.buttonMiamiFilter);
            this.groupBox1.Controls.Add(this.buttonBlackWhiteFilter);
            this.groupBox1.Location = new System.Drawing.Point(528, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 190);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Filters";
            // 
            // buttonSwapFilter
            // 
            this.buttonSwapFilter.Location = new System.Drawing.Point(50, 138);
            this.buttonSwapFilter.Name = "buttonSwapFilter";
            this.buttonSwapFilter.Size = new System.Drawing.Size(121, 30);
            this.buttonSwapFilter.TabIndex = 35;
            this.buttonSwapFilter.Text = "Filter Swap";
            this.buttonSwapFilter.UseVisualStyleBackColor = true;
            this.buttonSwapFilter.Click += new System.EventHandler(this.buttonSwapFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPrewitt3x3Horizontal);
            this.groupBox2.Controls.Add(this.buttonSobel3x3Vertical);
            this.groupBox2.Controls.Add(this.buttonLaplacian3x3);
            this.groupBox2.Location = new System.Drawing.Point(528, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 190);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Detection";
            // 
            // buttonPrewitt3x3Horizontal
            // 
            this.buttonPrewitt3x3Horizontal.Location = new System.Drawing.Point(50, 138);
            this.buttonPrewitt3x3Horizontal.Name = "buttonPrewitt3x3Horizontal";
            this.buttonPrewitt3x3Horizontal.Size = new System.Drawing.Size(121, 30);
            this.buttonPrewitt3x3Horizontal.TabIndex = 35;
            this.buttonPrewitt3x3Horizontal.Text = "Prewitt3x3Horizontal";
            this.buttonPrewitt3x3Horizontal.UseVisualStyleBackColor = true;
            this.buttonPrewitt3x3Horizontal.Click += new System.EventHandler(this.buttonPrewitt3x3Horizontal_Click);
            // 
            // buttonSobel3x3Vertical
            // 
            this.buttonSobel3x3Vertical.Location = new System.Drawing.Point(50, 89);
            this.buttonSobel3x3Vertical.Name = "buttonSobel3x3Vertical";
            this.buttonSobel3x3Vertical.Size = new System.Drawing.Size(121, 30);
            this.buttonSobel3x3Vertical.TabIndex = 34;
            this.buttonSobel3x3Vertical.Text = "Sobel3x3Vertical";
            this.buttonSobel3x3Vertical.UseVisualStyleBackColor = true;
            this.buttonSobel3x3Vertical.Click += new System.EventHandler(this.buttonSobel3x3Vertical_Click);
            // 
            // buttonLaplacian3x3
            // 
            this.buttonLaplacian3x3.Location = new System.Drawing.Point(50, 41);
            this.buttonLaplacian3x3.Name = "buttonLaplacian3x3";
            this.buttonLaplacian3x3.Size = new System.Drawing.Size(121, 30);
            this.buttonLaplacian3x3.TabIndex = 33;
            this.buttonLaplacian3x3.Text = "Laplacian3x3";
            this.buttonLaplacian3x3.UseVisualStyleBackColor = true;
            this.buttonLaplacian3x3.Click += new System.EventHandler(this.buttonLaplacian3x3_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(124, 473);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveImage.TabIndex = 42;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Click on the image filters or edge detection buttons to apply the corresponding f" +
    "ilters to the image";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(29, 534);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 44;
            // 
            // FormImageModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "FormImageModification";
            this.Text = "Form Image Modification";
            this.Load += new System.EventHandler(this.FormImageModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonMiamiFilter;
        private System.Windows.Forms.Button buttonBlackWhiteFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSwapFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPrewitt3x3Horizontal;
        private System.Windows.Forms.Button buttonSobel3x3Vertical;
        private System.Windows.Forms.Button buttonLaplacian3x3;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}

