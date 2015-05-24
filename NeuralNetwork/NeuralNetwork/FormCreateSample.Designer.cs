namespace NeuralNetwork
{
    partial class FormCreateSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateSample));
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.lblPathTo = new System.Windows.Forms.Label();
            this.lblPathFrom = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.txtAllFiles = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtFalse = new System.Windows.Forms.TextBox();
            this.txtTruth = new System.Windows.Forms.TextBox();
            this.lblFalse = new System.Windows.Forms.Label();
            this.lblTruth = new System.Windows.Forms.Label();
            this.lblNeuroCount = new System.Windows.Forms.Label();
            this.nudNeuro = new System.Windows.Forms.NumericUpDown();
            this.gbTrain = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbPaths.SuspendLayout();
            this.gbParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).BeginInit();
            this.gbTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.btnTo);
            this.gbPaths.Controls.Add(this.btnFrom);
            this.gbPaths.Controls.Add(this.lblPathTo);
            this.gbPaths.Controls.Add(this.lblPathFrom);
            this.gbPaths.Controls.Add(this.txtPath2);
            this.gbPaths.Controls.Add(this.txtPath1);
            this.gbPaths.Location = new System.Drawing.Point(17, 26);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(512, 147);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(391, 100);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(75, 20);
            this.btnTo.TabIndex = 5;
            this.btnTo.Text = "...";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrom.Location = new System.Drawing.Point(391, 43);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(75, 20);
            this.btnFrom.TabIndex = 4;
            this.btnFrom.Text = "...";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // lblPathTo
            // 
            this.lblPathTo.AutoSize = true;
            this.lblPathTo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathTo.Location = new System.Drawing.Point(20, 73);
            this.lblPathTo.Name = "lblPathTo";
            this.lblPathTo.Size = new System.Drawing.Size(175, 17);
            this.lblPathTo.TabIndex = 3;
            this.lblPathTo.Text = "Path to save the sample";
            // 
            // lblPathFrom
            // 
            this.lblPathFrom.AutoSize = true;
            this.lblPathFrom.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFrom.Location = new System.Drawing.Point(20, 19);
            this.lblPathFrom.Name = "lblPathFrom";
            this.lblPathFrom.Size = new System.Drawing.Size(139, 17);
            this.lblPathFrom.TabIndex = 2;
            this.lblPathFrom.Text = "Path to the images";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(23, 100);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(344, 20);
            this.txtPath2.TabIndex = 1;
            this.txtPath2.Text = "C:\\";
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(23, 43);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(344, 20);
            this.txtPath1.TabIndex = 0;
            this.txtPath1.Text = "C:\\";
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.txtAllFiles);
            this.gbParams.Controls.Add(this.btnStart);
            this.gbParams.Controls.Add(this.txtFalse);
            this.gbParams.Controls.Add(this.txtTruth);
            this.gbParams.Controls.Add(this.lblFalse);
            this.gbParams.Controls.Add(this.lblTruth);
            this.gbParams.Controls.Add(this.lblNeuroCount);
            this.gbParams.Controls.Add(this.nudNeuro);
            this.gbParams.Location = new System.Drawing.Point(17, 191);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(512, 149);
            this.gbParams.TabIndex = 1;
            this.gbParams.TabStop = false;
            // 
            // txtAllFiles
            // 
            this.txtAllFiles.Location = new System.Drawing.Point(35, 107);
            this.txtAllFiles.Name = "txtAllFiles";
            this.txtAllFiles.Size = new System.Drawing.Size(97, 20);
            this.txtAllFiles.TabIndex = 7;
            this.txtAllFiles.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(183, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtFalse
            // 
            this.txtFalse.Location = new System.Drawing.Point(390, 53);
            this.txtFalse.Name = "txtFalse";
            this.txtFalse.Size = new System.Drawing.Size(70, 20);
            this.txtFalse.TabIndex = 5;
            // 
            // txtTruth
            // 
            this.txtTruth.Location = new System.Drawing.Point(283, 53);
            this.txtTruth.Name = "txtTruth";
            this.txtTruth.Size = new System.Drawing.Size(70, 20);
            this.txtTruth.TabIndex = 4;
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalse.Location = new System.Drawing.Point(401, 21);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(45, 17);
            this.lblFalse.TabIndex = 3;
            this.lblFalse.Text = "False";
            // 
            // lblTruth
            // 
            this.lblTruth.AutoSize = true;
            this.lblTruth.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruth.Location = new System.Drawing.Point(295, 21);
            this.lblTruth.Name = "lblTruth";
            this.lblTruth.Size = new System.Drawing.Size(46, 17);
            this.lblTruth.TabIndex = 2;
            this.lblTruth.Text = "Truth";
            // 
            // lblNeuroCount
            // 
            this.lblNeuroCount.AutoSize = true;
            this.lblNeuroCount.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeuroCount.Location = new System.Drawing.Point(19, 21);
            this.lblNeuroCount.Name = "lblNeuroCount";
            this.lblNeuroCount.Size = new System.Drawing.Size(195, 17);
            this.lblNeuroCount.TabIndex = 1;
            this.lblNeuroCount.Text = "Number of output neurons";
            // 
            // nudNeuro
            // 
            this.nudNeuro.Location = new System.Drawing.Point(38, 54);
            this.nudNeuro.Name = "nudNeuro";
            this.nudNeuro.Size = new System.Drawing.Size(151, 20);
            this.nudNeuro.TabIndex = 0;
            // 
            // gbTrain
            // 
            this.gbTrain.Controls.Add(this.btnNext);
            this.gbTrain.Controls.Add(this.btnPrev);
            this.gbTrain.Controls.Add(this.btnExit);
            this.gbTrain.Controls.Add(this.btnStop);
            this.gbTrain.Controls.Add(this.btnRecord);
            this.gbTrain.Controls.Add(this.nud1);
            this.gbTrain.Controls.Add(this.pbImg);
            this.gbTrain.Location = new System.Drawing.Point(17, 359);
            this.gbTrain.Name = "gbTrain";
            this.gbTrain.Size = new System.Drawing.Size(511, 186);
            this.gbTrain.TabIndex = 2;
            this.gbTrain.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(341, 78);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(228, 78);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(88, 30);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(399, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(285, 134);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(168, 134);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(88, 30);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(168, 31);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(319, 20);
            this.nud1.TabIndex = 1;
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(11, 31);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(133, 133);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // FormCreateSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 549);
            this.Controls.Add(this.gbTrain);
            this.Controls.Add(this.gbParams);
            this.Controls.Add(this.gbPaths);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 588);
            this.MinimumSize = new System.Drawing.Size(565, 588);
            this.Name = "FormCreateSample";
            this.Text = "Creating training/ testing sample";
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).EndInit();
            this.gbTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Label lblPathTo;
        private System.Windows.Forms.Label lblPathFrom;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Label lblNeuroCount;
        private System.Windows.Forms.NumericUpDown nudNeuro;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtFalse;
        private System.Windows.Forms.TextBox txtTruth;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label lblTruth;
        private System.Windows.Forms.GroupBox gbTrain;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtAllFiles;
    }
}