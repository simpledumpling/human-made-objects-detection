using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    using NeuralNetworksLibrary;


    public partial class FormCreateNetwork : Form
    {
        public FormCreateNetwork()
        {
            InitializeComponent();
        }

        NumericUpDown[] nudLayers;
        Label[] layerLabels;
        int countLayers = 0;
        int[] layers;
        int sizeX;

        void NumericCreate()
        {
            for (int i = 0; i < countLayers; i++)
            {
                this.gbCreate.Controls.Remove(this.nudLayers[i]);
                this.gbCreate.Controls.Remove(this.layerLabels[i]);
            }

            countLayers = (int)numericUpDown3.Value;

            nudLayers = new NumericUpDown[countLayers];
            layerLabels = new Label[countLayers];

            for (int i = 0; i < countLayers; i++)
            {
                // Create layers counter
                nudLayers[i] = new NumericUpDown();

                nudLayers[i].Left = 111;
                nudLayers[i].Top = 185 + 65 * i;

                nudLayers[i].Maximum = 10000;
                nudLayers[i].Minimum = 1;

                this.gbCreate.Controls.Add(this.nudLayers[i]);

                // Create label of i th hidden layer
                layerLabels[i] = new Label();
                layerLabels[i].Top = 159 + 65 * i;
                layerLabels[i].Left = 85;
                layerLabels[i].Text = "Neurons in " + Convert.ToString(i + 1) + " layer: ";
                layerLabels[i].AutoSize = true;

                this.gbCreate.Controls.Add(this.layerLabels[i]);
            }
            // Move properties for exits
            //numericUpDown2.Top = 71 + 39 * countLayers;
            //lblOutput.Top = 55 + 39 * countLayers;
        }

        public int[] getLayers
        {
            get
            {
                return layers;
            }
        }

        public int getSizeX
        {
            get
            {
                return sizeX;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            layers = new int[countLayers + 1];

            sizeX = (int)numericUpDown1.Value;

            for (int i = 0; i < countLayers; i++)
                layers[i] = (int)nudLayers[i].Value;

            layers[countLayers] = (int)numericUpDown2.Value;

            Close();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
          
            try
            {
                NumericCreate();
            }
            finally
            {}
        }
        
    }
}
