namespace SearchApp
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTextInFile = new System.Windows.Forms.TextBox();
            this.lbxFilesList = new System.Windows.Forms.ListBox();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.txtSelectedFolderPath = new System.Windows.Forms.TextBox();
            this.lblNumberOfRepetitions = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(6, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(3, 67);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(81, 13);
            this.lblSearchText.TabIndex = 1;
            this.lblSearchText.Text = "Text for search:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(90, 64);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(117, 20);
            this.txtSearchText.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Start search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTextInFile
            // 
            this.txtTextInFile.Location = new System.Drawing.Point(160, 104);
            this.txtTextInFile.Multiline = true;
            this.txtTextInFile.Name = "txtTextInFile";
            this.txtTextInFile.ReadOnly = true;
            this.txtTextInFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextInFile.Size = new System.Drawing.Size(130, 186);
            this.txtTextInFile.TabIndex = 5;
            // 
            // lbxFilesList
            // 
            this.lbxFilesList.FormattingEnabled = true;
            this.lbxFilesList.Location = new System.Drawing.Point(12, 104);
            this.lbxFilesList.Name = "lbxFilesList";
            this.lbxFilesList.Size = new System.Drawing.Size(131, 186);
            this.lbxFilesList.TabIndex = 6;
            this.lbxFilesList.SelectedIndexChanged += new System.EventHandler(this.lbxFilesList_SelectedIndexChanged);
            this.lbxFilesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxFilesList_MouseDoubleClick);
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Location = new System.Drawing.Point(94, 12);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(84, 13);
            this.lblSelectedFolder.TabIndex = 7;
            this.lblSelectedFolder.Text = "Selected folder: ";
            // 
            // txtSelectedFolderPath
            // 
            this.txtSelectedFolderPath.Location = new System.Drawing.Point(190, 9);
            this.txtSelectedFolderPath.Multiline = true;
            this.txtSelectedFolderPath.Name = "txtSelectedFolderPath";
            this.txtSelectedFolderPath.ReadOnly = true;
            this.txtSelectedFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelectedFolderPath.Size = new System.Drawing.Size(100, 45);
            this.txtSelectedFolderPath.TabIndex = 8;
            // 
            // lblNumberOfRepetitions
            // 
            this.lblNumberOfRepetitions.AutoSize = true;
            this.lblNumberOfRepetitions.Location = new System.Drawing.Point(12, 304);
            this.lblNumberOfRepetitions.Name = "lblNumberOfRepetitions";
            this.lblNumberOfRepetitions.Size = new System.Drawing.Size(110, 13);
            this.lblNumberOfRepetitions.TabIndex = 9;
            this.lblNumberOfRepetitions.Text = "Number of repetitions:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(143, 304);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 340);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblNumberOfRepetitions);
            this.Controls.Add(this.txtSelectedFolderPath);
            this.Controls.Add(this.lblSelectedFolder);
            this.Controls.Add(this.lbxFilesList);
            this.Controls.Add(this.txtTextInFile);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTextInFile;
        private System.Windows.Forms.ListBox lbxFilesList;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.TextBox txtSelectedFolderPath;
        private System.Windows.Forms.Label lblNumberOfRepetitions;
        private System.Windows.Forms.Label lblNumber;
    }
}

