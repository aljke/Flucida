namespace CreateMltVolumeFiles
{
    partial class CreateMltVolumeFilesForm
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnCreateMltVolumeFiles = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.radioSecondLevel = new System.Windows.Forms.RadioButton();
            this.radioFirstLevel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(12, 12);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(584, 20);
            this.txtFolderPath.TabIndex = 0;
            // 
            // btnCreateMltVolumeFiles
            // 
            this.btnCreateMltVolumeFiles.Location = new System.Drawing.Point(615, 10);
            this.btnCreateMltVolumeFiles.Name = "btnCreateMltVolumeFiles";
            this.btnCreateMltVolumeFiles.Size = new System.Drawing.Size(141, 23);
            this.btnCreateMltVolumeFiles.TabIndex = 1;
            this.btnCreateMltVolumeFiles.Text = "Create _mlt.volume";
            this.btnCreateMltVolumeFiles.UseVisualStyleBackColor = true;
            this.btnCreateMltVolumeFiles.Click += new System.EventHandler(this.btnCreateMltVolumeFiles_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(12, 87);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(744, 290);
            this.lstResult.TabIndex = 2;
            // 
            // radioSecondLevel
            // 
            this.radioSecondLevel.AutoSize = true;
            this.radioSecondLevel.Location = new System.Drawing.Point(13, 39);
            this.radioSecondLevel.Name = "radioSecondLevel";
            this.radioSecondLevel.Size = new System.Drawing.Size(91, 17);
            this.radioSecondLevel.TabIndex = 3;
            this.radioSecondLevel.Text = "Second Level";
            this.radioSecondLevel.UseVisualStyleBackColor = true;
            // 
            // radioFirstLevel
            // 
            this.radioFirstLevel.AutoSize = true;
            this.radioFirstLevel.Checked = true;
            this.radioFirstLevel.Location = new System.Drawing.Point(143, 39);
            this.radioFirstLevel.Name = "radioFirstLevel";
            this.radioFirstLevel.Size = new System.Drawing.Size(73, 17);
            this.radioFirstLevel.TabIndex = 4;
            this.radioFirstLevel.TabStop = true;
            this.radioFirstLevel.Text = "First Level";
            this.radioFirstLevel.UseVisualStyleBackColor = true;
            // 
            // CreateMltVolumeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 390);
            this.Controls.Add(this.radioFirstLevel);
            this.Controls.Add(this.radioSecondLevel);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnCreateMltVolumeFiles);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "CreateMltVolumeFilesForm";
            this.Text = "CreateMltVolumeFilesForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnCreateMltVolumeFiles;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.RadioButton radioSecondLevel;
        private System.Windows.Forms.RadioButton radioFirstLevel;
    }
}

