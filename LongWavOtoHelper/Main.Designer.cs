namespace LongWavOtoHelper
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWavDirectory = new System.Windows.Forms.Label();
            this.textBoxWavDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonSelectWavDirectory = new System.Windows.Forms.Button();
            this.buttonSelectDivisionInputOtoFile = new System.Windows.Forms.Button();
            this.textBoxDivisionInputOtoFilePath = new System.Windows.Forms.TextBox();
            this.labelDivisionInputOtoFile = new System.Windows.Forms.Label();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.groupBoxDivision = new System.Windows.Forms.GroupBox();
            this.groupBoxJoining = new System.Windows.Forms.GroupBox();
            this.textBoxLongWavName = new System.Windows.Forms.TextBox();
            this.labelLongWavName = new System.Windows.Forms.Label();
            this.buttonSelectJoiningInputOtoFile = new System.Windows.Forms.Button();
            this.textBoxJoiningInputOtoFilePath = new System.Windows.Forms.TextBox();
            this.labelJoiningOtoFilePath = new System.Windows.Forms.Label();
            this.groupBoxDivision.SuspendLayout();
            this.groupBoxJoining.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWavDirectory
            // 
            this.labelWavDirectory.AutoSize = true;
            this.labelWavDirectory.Location = new System.Drawing.Point(12, 31);
            this.labelWavDirectory.Name = "labelWavDirectory";
            this.labelWavDirectory.Size = new System.Drawing.Size(156, 12);
            this.labelWavDirectory.TabIndex = 2;
            this.labelWavDirectory.Text = "Directory of divided wav files";
            // 
            // textBoxWavDirectoryPath
            // 
            this.textBoxWavDirectoryPath.Location = new System.Drawing.Point(195, 28);
            this.textBoxWavDirectoryPath.Name = "textBoxWavDirectoryPath";
            this.textBoxWavDirectoryPath.Size = new System.Drawing.Size(286, 19);
            this.textBoxWavDirectoryPath.TabIndex = 3;
            this.textBoxWavDirectoryPath.TextChanged += new System.EventHandler(this.textBoxResultFilePath_TextChanged);
            // 
            // buttonSelectWavDirectory
            // 
            this.buttonSelectWavDirectory.Location = new System.Drawing.Point(497, 26);
            this.buttonSelectWavDirectory.Name = "buttonSelectWavDirectory";
            this.buttonSelectWavDirectory.Size = new System.Drawing.Size(39, 23);
            this.buttonSelectWavDirectory.TabIndex = 4;
            this.buttonSelectWavDirectory.Text = "…";
            this.buttonSelectWavDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectWavDirectory.Click += new System.EventHandler(this.buttonLoadResultFile_Click);
            // 
            // buttonSelectDivisionInputOtoFile
            // 
            this.buttonSelectDivisionInputOtoFile.Location = new System.Drawing.Point(485, 21);
            this.buttonSelectDivisionInputOtoFile.Name = "buttonSelectDivisionInputOtoFile";
            this.buttonSelectDivisionInputOtoFile.Size = new System.Drawing.Size(39, 23);
            this.buttonSelectDivisionInputOtoFile.TabIndex = 7;
            this.buttonSelectDivisionInputOtoFile.Text = "…";
            this.buttonSelectDivisionInputOtoFile.UseVisualStyleBackColor = true;
            this.buttonSelectDivisionInputOtoFile.Click += new System.EventHandler(this.buttonLoadInputOtoFile_Click);
            // 
            // textBoxDivisionInputOtoFilePath
            // 
            this.textBoxDivisionInputOtoFilePath.Location = new System.Drawing.Point(183, 23);
            this.textBoxDivisionInputOtoFilePath.Name = "textBoxDivisionInputOtoFilePath";
            this.textBoxDivisionInputOtoFilePath.Size = new System.Drawing.Size(286, 19);
            this.textBoxDivisionInputOtoFilePath.TabIndex = 6;
            this.textBoxDivisionInputOtoFilePath.TextChanged += new System.EventHandler(this.textBoxInputOtoFilePath_TextChanged);
            // 
            // labelDivisionInputOtoFile
            // 
            this.labelDivisionInputOtoFile.AutoSize = true;
            this.labelDivisionInputOtoFile.Location = new System.Drawing.Point(11, 26);
            this.labelDivisionInputOtoFile.Name = "labelDivisionInputOtoFile";
            this.labelDivisionInputOtoFile.Size = new System.Drawing.Size(70, 12);
            this.labelDivisionInputOtoFile.TabIndex = 5;
            this.labelDivisionInputOtoFile.Text = "Input oto file";
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(13, 59);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(201, 26);
            this.buttonDivide.TabIndex = 8;
            this.buttonDivide.Text = "Process for Division";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(15, 101);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(201, 27);
            this.buttonJoin.TabIndex = 9;
            this.buttonJoin.Text = "Process for Restoring";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // groupBoxDivision
            // 
            this.groupBoxDivision.Controls.Add(this.buttonSelectDivisionInputOtoFile);
            this.groupBoxDivision.Controls.Add(this.buttonDivide);
            this.groupBoxDivision.Controls.Add(this.textBoxDivisionInputOtoFilePath);
            this.groupBoxDivision.Controls.Add(this.labelDivisionInputOtoFile);
            this.groupBoxDivision.Location = new System.Drawing.Point(12, 75);
            this.groupBoxDivision.Name = "groupBoxDivision";
            this.groupBoxDivision.Size = new System.Drawing.Size(547, 97);
            this.groupBoxDivision.TabIndex = 10;
            this.groupBoxDivision.TabStop = false;
            this.groupBoxDivision.Text = "Division";
            // 
            // groupBoxJoining
            // 
            this.groupBoxJoining.Controls.Add(this.textBoxLongWavName);
            this.groupBoxJoining.Controls.Add(this.labelLongWavName);
            this.groupBoxJoining.Controls.Add(this.buttonJoin);
            this.groupBoxJoining.Controls.Add(this.buttonSelectJoiningInputOtoFile);
            this.groupBoxJoining.Controls.Add(this.textBoxJoiningInputOtoFilePath);
            this.groupBoxJoining.Controls.Add(this.labelJoiningOtoFilePath);
            this.groupBoxJoining.Location = new System.Drawing.Point(12, 199);
            this.groupBoxJoining.Name = "groupBoxJoining";
            this.groupBoxJoining.Size = new System.Drawing.Size(547, 154);
            this.groupBoxJoining.TabIndex = 11;
            this.groupBoxJoining.TabStop = false;
            this.groupBoxJoining.Text = "Restoring";
            // 
            // textBoxLongWavName
            // 
            this.textBoxLongWavName.Location = new System.Drawing.Point(185, 29);
            this.textBoxLongWavName.Name = "textBoxLongWavName";
            this.textBoxLongWavName.Size = new System.Drawing.Size(121, 19);
            this.textBoxLongWavName.TabIndex = 3;
            // 
            // labelLongWavName
            // 
            this.labelLongWavName.AutoSize = true;
            this.labelLongWavName.Location = new System.Drawing.Point(13, 32);
            this.labelLongWavName.Name = "labelLongWavName";
            this.labelLongWavName.Size = new System.Drawing.Size(154, 12);
            this.labelLongWavName.TabIndex = 2;
            this.labelLongWavName.Text = "File name of the original wav";
            // 
            // buttonSelectJoiningInputOtoFile
            // 
            this.buttonSelectJoiningInputOtoFile.Location = new System.Drawing.Point(487, 59);
            this.buttonSelectJoiningInputOtoFile.Name = "buttonSelectJoiningInputOtoFile";
            this.buttonSelectJoiningInputOtoFile.Size = new System.Drawing.Size(39, 23);
            this.buttonSelectJoiningInputOtoFile.TabIndex = 7;
            this.buttonSelectJoiningInputOtoFile.Text = "…";
            this.buttonSelectJoiningInputOtoFile.UseVisualStyleBackColor = true;
            this.buttonSelectJoiningInputOtoFile.Click += new System.EventHandler(this.buttonSelectJoiningInputOtoFile_Click);
            // 
            // textBoxJoiningInputOtoFilePath
            // 
            this.textBoxJoiningInputOtoFilePath.Location = new System.Drawing.Point(185, 61);
            this.textBoxJoiningInputOtoFilePath.Name = "textBoxJoiningInputOtoFilePath";
            this.textBoxJoiningInputOtoFilePath.Size = new System.Drawing.Size(286, 19);
            this.textBoxJoiningInputOtoFilePath.TabIndex = 6;
            this.textBoxJoiningInputOtoFilePath.TextChanged += new System.EventHandler(this.textBoxJoiningInputOtoFilePath_TextChanged);
            // 
            // labelJoiningOtoFilePath
            // 
            this.labelJoiningOtoFilePath.AutoSize = true;
            this.labelJoiningOtoFilePath.Location = new System.Drawing.Point(13, 64);
            this.labelJoiningOtoFilePath.Name = "labelJoiningOtoFilePath";
            this.labelJoiningOtoFilePath.Size = new System.Drawing.Size(70, 12);
            this.labelJoiningOtoFilePath.TabIndex = 5;
            this.labelJoiningOtoFilePath.Text = "Input oto file";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 369);
            this.Controls.Add(this.textBoxWavDirectoryPath);
            this.Controls.Add(this.groupBoxJoining);
            this.Controls.Add(this.labelWavDirectory);
            this.Controls.Add(this.groupBoxDivision);
            this.Controls.Add(this.buttonSelectWavDirectory);
            this.Name = "Main";
            this.Text = "LongWavOtoHelper";
            this.groupBoxDivision.ResumeLayout(false);
            this.groupBoxDivision.PerformLayout();
            this.groupBoxJoining.ResumeLayout(false);
            this.groupBoxJoining.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWavDirectory;
        private System.Windows.Forms.TextBox textBoxWavDirectoryPath;
        private System.Windows.Forms.Button buttonSelectWavDirectory;
        private System.Windows.Forms.Button buttonSelectDivisionInputOtoFile;
        private System.Windows.Forms.TextBox textBoxDivisionInputOtoFilePath;
        private System.Windows.Forms.Label labelDivisionInputOtoFile;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.GroupBox groupBoxDivision;
        private System.Windows.Forms.GroupBox groupBoxJoining;
        private System.Windows.Forms.TextBox textBoxLongWavName;
        private System.Windows.Forms.Label labelLongWavName;
        private System.Windows.Forms.Button buttonSelectJoiningInputOtoFile;
        private System.Windows.Forms.TextBox textBoxJoiningInputOtoFilePath;
        private System.Windows.Forms.Label labelJoiningOtoFilePath;
    }
}

