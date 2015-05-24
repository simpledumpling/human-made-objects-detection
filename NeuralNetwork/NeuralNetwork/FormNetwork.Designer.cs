namespace NeuralNetwork
{
    partial class FormNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNetwork));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuralNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingtestingSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.gbTrain = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.gbMess = new System.Windows.Forms.GroupBox();
            this.txtLearnFiles = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.gbTrain.SuspendLayout();
            this.gbMess.SuspendLayout();
            this.gbTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuralNetworkToolStripMenuItem,
            this.trainingtestingSampleToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // neuralNetworkToolStripMenuItem
            // 
            this.neuralNetworkToolStripMenuItem.Name = "neuralNetworkToolStripMenuItem";
            this.neuralNetworkToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.neuralNetworkToolStripMenuItem.Text = "Neural Network";
            this.neuralNetworkToolStripMenuItem.Click += new System.EventHandler(this.neuralNetworkToolStripMenuItem_Click);
            // 
            // trainingtestingSampleToolStripMenuItem
            // 
            this.trainingtestingSampleToolStripMenuItem.Name = "trainingtestingSampleToolStripMenuItem";
            this.trainingtestingSampleToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.trainingtestingSampleToolStripMenuItem.Text = "Training/testing sample";
            this.trainingtestingSampleToolStripMenuItem.Click += new System.EventHandler(this.trainingtestingSampleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.btnPath);
            this.groupBoxPath.Controls.Add(this.tbPath);
            this.groupBoxPath.Controls.Add(this.labelPath);
            this.groupBoxPath.Location = new System.Drawing.Point(11, 42);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(355, 106);
            this.groupBoxPath.TabIndex = 5;
            this.groupBoxPath.TabStop = false;
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(301, 51);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 20);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(19, 51);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(260, 20);
            this.tbPath.TabIndex = 1;
            this.tbPath.Text = "C:\\";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(16, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(172, 17);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path to training sample";
            // 
            // gbTrain
            // 
            this.gbTrain.Controls.Add(this.btnStop);
            this.gbTrain.Controls.Add(this.btnStart);
            this.gbTrain.Controls.Add(this.txtStop);
            this.gbTrain.Controls.Add(this.txtSpeed);
            this.gbTrain.Controls.Add(this.lblStop);
            this.gbTrain.Controls.Add(this.lblSpeed);
            this.gbTrain.Location = new System.Drawing.Point(11, 165);
            this.gbTrain.Name = "gbTrain";
            this.gbTrain.Size = new System.Drawing.Size(355, 131);
            this.gbTrain.TabIndex = 6;
            this.gbTrain.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(204, 82);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 31);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(19, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 31);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(217, 51);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(84, 20);
            this.txtStop.TabIndex = 3;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(31, 51);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(84, 20);
            this.txtSpeed.TabIndex = 2;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(191, 16);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(137, 17);
            this.lblStop.TabIndex = 1;
            this.lblStop.Text = "Stopping criterion";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(16, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(115, 17);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Training speed";
            // 
            // gbMess
            // 
            this.gbMess.Controls.Add(this.txtLearnFiles);
            this.gbMess.Controls.Add(this.txtMessage);
            this.gbMess.Controls.Add(this.lblMess);
            this.gbMess.Location = new System.Drawing.Point(11, 306);
            this.gbMess.Name = "gbMess";
            this.gbMess.Size = new System.Drawing.Size(753, 231);
            this.gbMess.TabIndex = 7;
            this.gbMess.TabStop = false;
            // 
            // txtLearnFiles
            // 
            this.txtLearnFiles.Location = new System.Drawing.Point(124, 16);
            this.txtLearnFiles.Name = "txtLearnFiles";
            this.txtLearnFiles.Size = new System.Drawing.Size(134, 20);
            this.txtLearnFiles.TabIndex = 3;
            this.txtLearnFiles.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(19, 48);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(706, 165);
            this.txtMessage.TabIndex = 2;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.Location = new System.Drawing.Point(16, 16);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(77, 17);
            this.lblMess.TabIndex = 1;
            this.lblMess.Text = "Messages";
            // 
            // gbTest
            // 
            this.gbTest.BackColor = System.Drawing.SystemColors.Control;
            this.gbTest.Controls.Add(this.btnTest);
            this.gbTest.Controls.Add(this.txtOutput);
            this.gbTest.Controls.Add(this.txtInp);
            this.gbTest.Controls.Add(this.label2);
            this.gbTest.Controls.Add(this.label1);
            this.gbTest.Controls.Add(this.btnOpenTest);
            this.gbTest.Location = new System.Drawing.Point(397, 42);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(366, 254);
            this.gbTest.TabIndex = 8;
            this.gbTest.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(92, 219);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(160, 26);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(210, 79);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(123, 126);
            this.txtOutput.TabIndex = 4;
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(19, 79);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(123, 126);
            this.txtInp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output vector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input vector";
            // 
            // btnOpenTest
            // 
            this.btnOpenTest.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTest.Location = new System.Drawing.Point(88, 21);
            this.btnOpenTest.Name = "btnOpenTest";
            this.btnOpenTest.Size = new System.Drawing.Size(160, 26);
            this.btnOpenTest.TabIndex = 0;
            this.btnOpenTest.Text = "Open test file";
            this.btnOpenTest.UseVisualStyleBackColor = true;
            this.btnOpenTest.Click += new System.EventHandler(this.btnOpenTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FormNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 549);
            this.Controls.Add(this.gbTest);
            this.Controls.Add(this.gbMess);
            this.Controls.Add(this.gbTrain);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(802, 588);
            this.MinimumSize = new System.Drawing.Size(802, 588);
            this.Name = "FormNetwork";
            this.Text = "Maps Recognition 2.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.gbTrain.ResumeLayout(false);
            this.gbTrain.PerformLayout();
            this.gbMess.ResumeLayout(false);
            this.gbMess.PerformLayout();
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuralNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingtestingSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.GroupBox gbTrain;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.GroupBox gbMess;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtLearnFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

