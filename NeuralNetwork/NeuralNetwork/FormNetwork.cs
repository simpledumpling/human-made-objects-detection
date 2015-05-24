using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NeuralNetwork
{
    using NeuralNetworksLibrary;
   
    public partial class FormNetwork : Form
    {
        public FormNetwork()
        {
            InitializeComponent();
        }

        NeuralNetwork NET;
        String pathToNetwork = "";
        bool runTraining = false;

        public void CreateNetwork(int SizeX, int[] Layers)
        {
            NET = new NeuralNetwork(SizeX, Layers);
            pathToNetwork = "";
            txtMessage.AppendText("Neural Network was created\r\n");
            txtMessage.AppendText("Number of inputs: " + Convert.ToString(SizeX) + "\r\n");
            txtMessage.AppendText("Number of outputs: " + Convert.ToString(Layers[Layers.Count() - 1]) + "\r\n");
            txtMessage.AppendText("Number of hidden layers: " + Convert.ToString(Layers.Count() - 1) + "\r\n");
            
            for (int i = 0; i < Layers.Count() - 1; i++)
            {
                txtMessage.AppendText("Number of neurons in " + Convert.ToString(i + 1) + " hidden layer: "
                                                    + Convert.ToString(Layers[i]) + "\r\n");

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (NET == null)
            {
                txtMessage.AppendText("Network is not create!\r\n");
                return;
            }
            txtMessage.AppendText("Training process launched\r\n");

            String strFileIn, strFileOut, strFile;

            // Clean list in training sample
            txtLearnFiles.Text = "";
            FileInfo[] fInfo = new DirectoryInfo(tbPath.Text).GetFiles("*.in.txt");
            foreach (FileInfo f in fInfo)
            {
                // Load list of files
                strFileIn = f.FullName;
                strFile = strFileIn.Remove(strFileIn.Length - 7);
                strFileOut = strFile + ".out.txt";

                if (File.Exists(strFileOut) && File.Exists(strFileIn))
                {
                    txtLearnFiles.AppendText(strFile + "\r\n");
                }
            }
            if (txtLearnFiles.Lines.Count() > 0)
                txtMessage.AppendText("Training sample loaded\r\n");
            else
            {
                txtMessage.AppendText("Training sample not found\r\n");
                return;
            }

            int currPos = 0;
            double kErr = 1E256;
            double kErrNorm = Convert.ToDouble(txtStop.Text);
            double kLern = Convert.ToDouble(txtSpeed.Text);

            double[] X = new double[NET.GetX];
            double[] Y = new double[NET.GetY];
            String[] currFile;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            runTraining = true;
            while (kErr > kErrNorm)
            {
                kErr = 0;
                for (currPos = 0; currPos < txtLearnFiles.Lines.Count() - 1; currPos++)
                {
                    // Load training pair
                    try
                    {
                        // Load current input file
                        currFile = File.ReadAllLines(txtLearnFiles.Lines[currPos] + ".in.txt");

                        for (int i = 0; i < NET.GetX; i++)
                            X[i] = Convert.ToDouble(currFile[i]);

                        // Load current output file
                        currFile = File.ReadAllLines(txtLearnFiles.Lines[currPos] + ".out.txt");

                        for (int i = 0; i < NET.GetY; i++)
                            Y[i] = Convert.ToDouble(currFile[i]);
                    }
                    finally
                    { }

                    // Training current pair
                    kErr += NET.LernNW(X, Y, kLern);

                    Application.DoEvents();

                    if (!runTraining)
                        return;
                }
                txtMessage.AppendText("Current mistake: " + Convert.ToString(kErr) + "\r\n");
            }
            txtMessage.AppendText("Training is over!\r\n");

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            runTraining = false;
        }

        private void neuralNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateNetwork f = new FormCreateNetwork();
            if (f.ShowDialog() != DialogResult.OK)
            {
                CreateNetwork(f.getSizeX, f.getLayers);
            }
        }

        private void trainingtestingSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateSample f = new FormCreateSample();
            f.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathToNetwork = openFileDialog1.FileName;
            if (File.Exists(pathToNetwork))
            {
                try
                {
                    NET = new NeuralNetwork(pathToNetwork);
                }
                finally
                { }

                txtMessage.AppendText("Network loaded:\r\n" + pathToNetwork + "\r\n");

                txtMessage.AppendText("Number of inputs: " + Convert.ToString(NET.GetX) + "\r\n");
                txtMessage.AppendText("Number of outputs: " + Convert.ToString(NET.GetY) + "\r\n");
                txtMessage.AppendText("Number of hidden layers: " + Convert.ToString(NET.CountLayers - 1) + "\r\n");

                for (int i = 0; i < NET.CountLayers - 1; i++)
                {
                    txtMessage.AppendText("Neurons in " + Convert.ToString(i + 1) + " hidden layer: "
                                                        + Convert.ToString(NET.Layer(i).countY) + "\r\n");
                }
            }
            else
            {
                if (pathToNetwork != "")
                {
                    txtMessage.AppendText("Error! File does not exist!\r\n" + pathToNetwork + "\r\n");
                    pathToNetwork = "";
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (NET == null)
            {
                txtMessage.AppendText("Error! Network is not create!\r\n");
            }
            else
            {
                if (pathToNetwork == "")
                {
                    saveFileDialog1.ShowDialog();
                    pathToNetwork = saveFileDialog1.FileName;
                }
                try
                {
                    NET.SaveNW(pathToNetwork);
                }
                finally
                { }
                txtMessage.AppendText("Network saved:\r\n" + pathToNetwork + "\r\n");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NET == null)
            {
                txtMessage.AppendText("Error! Network is not create!\r\n");
            }
            else
            {
                saveFileDialog1.ShowDialog();
                pathToNetwork = saveFileDialog1.FileName;
                try
                {
                    NET.SaveNW(pathToNetwork);
                }
                finally
                { }
                txtMessage.AppendText("Network saved:\r\n" + pathToNetwork + "\r\n");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            runTraining = false;
            txtMessage.AppendText("Training stopped by user\r\n");
        }

        private void btnOpenTest_Click(object sender, EventArgs e)
        {
            if (NET == null)
            {
                txtMessage.AppendText("Network is not create!\r\n");
                return;
            }
            openFileDialog2.ShowDialog();

            String strFile = openFileDialog2.FileName;

            if (!File.Exists(strFile))
                return;

            double[] X = new double[NET.GetX];
            double[] Y;
            String[] currFile;

            txtInp.Text = "";
            txtOutput.Text = "";

            // Load current input
            currFile = File.ReadAllLines(strFile);
            txtInp.Lines = currFile;
            txtMessage.AppendText("File loaded:\r\n" + Convert.ToString(strFile) + "\r\n");

            for (int i = 0; i < NET.GetX; i++)
            {
                X[i] = Convert.ToDouble(currFile[i]);
            }

            NET.NetOUT(X, out Y);

            for (int i = 0; i < NET.GetY; i++)
            {
                txtOutput.AppendText(string.Format("{0:F4}\r\n", Y[i]));
                //textBox2.AppendText(Convert.ToString(Y[i]) + "\r\n");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (NET == null)
            {
                txtMessage.AppendText("Network is not create!\r\n");
                return;
            }

            double[] X = new double[NET.GetX];
            double[] Y;

            txtOutput.Text = "";

            // Загружаем текущий входной файл

            for (int i = 0; i < NET.GetX; i++)
            {
                X[i] = Convert.ToDouble(txtInp.Lines[i]);
            }

            NET.NetOUT(X, out Y);

            for (int i = 0; i < NET.GetY; i++)
            {
                txtOutput.AppendText(string.Format("{0:F4}\r\n", Y[i]));
                //textBox2.AppendText(Convert.ToString(Y[i]) + "\r\n");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show();
        }

    }
}
