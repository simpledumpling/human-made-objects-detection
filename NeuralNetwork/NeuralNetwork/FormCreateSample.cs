using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class FormCreateSample : Form
    {
        public FormCreateSample()
        {
            InitializeComponent();
        }

        int num = 0;
        void SaveBin(String path, String name, String digit, Bitmap bmp)
        {

            int W = bmp.Width;
            int H = bmp.Height;
            int N = W * H;
            double val = 0;

            String[] mas = new String[N];

            for (int j = 0, k = 0; j < H; j++)
            {
                for (int i = 0; i < W; i++)
                {
                    val = 0.3 * bmp.GetPixel(i, j).R + 0.59 * bmp.GetPixel(i, j).G + 0.11 * bmp.GetPixel(i, j).B;

                    if (val > 127)
                    {
                        mas[k++] = "-0,5";
                    }
                    else
                    {
                        mas[k++] = "0,5";
                    }
                }
            }

            File.WriteAllLines(path + "\\" + name + ".in.txt", mas);

            N = (int)nudNeuro.Value;
            if (N > 0)
            {
                String[] mas2 = new string[N];

                for (int i = 0; i < N; i++)
                    mas2[i] = txtFalse.Text;

                int num2 = Convert.ToInt32(nud1.Value - 1);
                mas2[num2] = txtTruth.Text;


                File.WriteAllLines(path + "\\" + name + ".out.txt", mas2);
            }
        }

        void StartStop(bool flag)
        {
            btnStart.Enabled = !flag;
            btnNext.Enabled = flag;
            btnPrev.Enabled = flag;
            btnRecord.Enabled = flag;
            btnStop.Enabled = flag;

            txtTruth.Enabled = !flag;
            txtFalse.Enabled = !flag;

            nudNeuro.Enabled = !flag;
            nud1.Enabled = flag;
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            nud1.Maximum = nudNeuro.Value;
            nud1.Minimum = (nudNeuro.Value == 0) ? 0 : 1;

            String strSrc = txtPath1.Text;
            FileInfo[] fInfo = new DirectoryInfo(strSrc).GetFiles("*.bmp");
            foreach (FileInfo f in fInfo)
            {
                txtAllFiles.AppendText(f.Name + "\r\n");
            }
            if (txtAllFiles.Lines.Count() == 0)
            {
                MessageBox.Show("Don't find *.bmp files");
                return;
            }

            StartStop(true);
            pbImg.ImageLocation = strSrc + "\\" + txtAllFiles.Lines[num];
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StartStop(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (num >= txtAllFiles.Lines.Count() - 1)
                return;
            String str = txtPath1.Text + "\\" + txtAllFiles.Lines[num];
            pbImg.ImageLocation = str;

            Bitmap bmp = new Bitmap(str);

            SaveBin(txtPath2.Text, txtAllFiles.Lines[num], Convert.ToString(nud1.Value), bmp);

            str = txtPath1.Text + "\\" + txtAllFiles.Lines[++num];
            pbImg.ImageLocation = str;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            num--;
            if (num < 0)
                num = 0;

            String str = txtPath1.Text + "\\" + txtAllFiles.Lines[num];
            pbImg.ImageLocation = str;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            num++;
            if (num > txtAllFiles.Lines.Count() - 2)
                num = txtAllFiles.Lines.Count() - 2;

            String str = txtPath1.Text + "\\" + txtAllFiles.Lines[num];
            pbImg.ImageLocation = str;
        }
    }
}
