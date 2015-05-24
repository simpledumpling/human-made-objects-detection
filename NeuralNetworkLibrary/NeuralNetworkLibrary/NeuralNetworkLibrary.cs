using System;
using System.IO;
using System.Runtime.InteropServices;


namespace NeuralNetworksLibrary
{

    public class LayerNetwork //class Network Layer
    {
        double[,] Weights;
        int cX, cY;

        
        public void GenerateWeights() // Fill the weights with random numbers
        {
            Random rnd = new Random();
            for (int i = 0; i < cX; i++)
            {
                for (int j = 0; j < cY; j++)
                {
                    Weights[i, j] = rnd.NextDouble() - 0.5;
                }
            }
        }

        
        protected void AllocateMemory() //Allocate memory for weights
        {
            Weights = new double[cX, cY];
        }

        
        public LayerNetwork(int countX, int countY) //LayerNetwork constructor(input neurons, output neurons)
        {
            cX = countX;
            cY = countY;
            AllocateMemory();
        }

        public int countX //Get number of input neurons
        {
            get { return cX; }
        }

        public int countY //Get number of output neurons
        {
            get { return cY; }
        }

        public double this[int row, int col]
        {
            get { return Weights[row, col]; }
            set { Weights[row, col] = value; }
        }

    }

        public class NeuralNetwork //class Network
    {
        LayerNetwork[] Layers;
        int layersCount = 0, countX, countY;
        double[][] Netout;
        double[][] Delta;  

        public NeuralNetwork(int sizeX, int sizeY) //Set 1-layer Neural Network constructor(number of neurons in input vector, number of neurons in output vector)
        {
            layersCount = 1;
            Layers = new LayerNetwork[layersCount];
            Layers[0] = new LayerNetwork(sizeX, sizeY);
            Layers[0].GenerateWeights();
        }

        public NeuralNetwork(int sizeX, params int[] layers) //Set n-layer Neural Network constructor(number of neurons in input vector, layer array with number of neurons in current layer)
        {
            layersCount = layers.Length;
            countX = sizeX; //Number of inputs
            countY = layers[layers.Length - 1]; //Number of neurons at the last layer
            
            Netout = new double[layersCount + 1][]; //Number of outputs
            Netout[0] = new double[sizeX];
            Delta = new double[layersCount][]; //delta

            this.Layers = new LayerNetwork[layersCount];

            int countY1, countX1 = sizeX;

            // Set the dimension of the layer and fill the layer with random numbers
            for (int i = 0; i < layersCount; i++) //All layers cycle
            {
                countY1 = layers[i]; //Number of neurons at the current layer

                Netout[i + 1] = new double[countY1];
                Delta[i] = new double[countY1];

                this.Layers[i] = new LayerNetwork(countX1, countY1); //Create the layer
                this.Layers[i].GenerateWeights(); // Generate weights
                countX1 = countY1; // Outputs are inputs for the next layer
            }
        }

        [StructLayout(LayoutKind.Explicit)] //Struct to smash int and double to bytes
        internal class DataToByte
        {
            [FieldOffset(0)]
            public double vDouble;

            [FieldOffset(0)]
            public int vInt;

            [FieldOffset(0)]
            public byte b1;
            [FieldOffset(1)]
            public byte b2;
            [FieldOffset(2)]
            public byte b3;
            [FieldOffset(3)]
            public byte b4;
            [FieldOffset(4)]
            public byte b5;
            [FieldOffset(5)]
            public byte b6;
            [FieldOffset(6)]
            public byte b7;
            [FieldOffset(7)]
            public byte b8;
        }
        public NeuralNetwork(String FileName) // Open Network
        {
            OpenNW(FileName);
        }

        
        public void OpenNW(String FileName) // Open Network
        {
            byte[] binNW = File.ReadAllBytes(FileName); 

            int k = 0;
            
            layersCount = ReadFromArrayInt(binNW, ref k); //Get layer count
            Layers = new LayerNetwork[layersCount];

            
            int CountY1 = 0, CountX1 = ReadFromArrayInt(binNW, ref k); //Get size of layers
            
            countX = CountX1; //Number of input neurons
            // Allocate memory for outputs and delta
            Netout = new double[layersCount + 1][];
            Netout[0] = new double[CountX1];
            Delta = new double[layersCount][];

            for (int i = 0; i < layersCount; i++)
            {
                CountY1 = ReadFromArrayInt(binNW, ref k);
                Layers[i] = new LayerNetwork(CountX1, CountY1);
                CountX1 = CountY1;

                // Allocate memory
                Netout[i + 1] = new double[CountY1];
                Delta[i] = new double[CountY1];
            }
            
            countY = CountY1;
            // Get and write weights
            for (int r = 0; r < layersCount; r++)
                for (int p = 0; p < Layers[r].countX; p++)
                    for (int q = 0; q < Layers[r].countY; q++)
                    {
                        Layers[r][p, q] = ReadFromArrayDouble(binNW, ref k);
                    }
        }

        
        public void SaveNW(String FileName) //Save Neural Network
        {
            // Size of network in bytes
            int sizeNW = GetNetworkSize();
            byte[] binNW = new byte[sizeNW];

            int k = 0;
            // Write number of neurons on each layer to the byte array
            WriteToArray(binNW, ref k, layersCount);
            if (layersCount <= 0)
                return;

            WriteToArray(binNW, ref k, Layers[0].countX);
            for (int i = 0; i < layersCount; i++)
                WriteToArray(binNW, ref k, Layers[i].countY);

            // Write weights
            for (int r = 0; r < layersCount; r++)
                for (int p = 0; p < Layers[r].countX; p++)
                    for (int q = 0; q < Layers[r].countY; q++)
                    {
                        WriteInArray(binNW, ref k, Layers[r][p, q]);
                    }


            File.WriteAllBytes(FileName, binNW);
        }

        
        public void NetOUT(double[] inX, out double[] outY, int jLayer) //Return value of j-th layer
        {
            GetLayersValues(inX, jLayer);
            int N = Netout[jLayer].Length;

            outY = new double[N];

            for (int i = 0; i < N; i++)
            {
                outY[i] = Netout[jLayer][i];
            }

        }

        
        public void NetOUT(double[] inX, out double[] outY) //Return result
        {
            int j = layersCount;
            NetOUT(inX, out outY, j);
        }

        
        public double CalcError(double[] X, double[] Y) //Return an error 
        {
            double kErr = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                kErr += Math.Pow(Y[i] - Netout[layersCount][i], 2);
            }

            return 0.5 * kErr;
        }

        public double LernNW(double[] X, double[] Y, double learnSpeed) //X, Y - training pair, result - error
        {
            double O;  // Neuron input
            double s;

            // Calculate output
            GetAllValues(X);

            // Fill delta from last layer
            for (int j = 0; j < Layers[layersCount - 1].countY; j++)
            {
                O = Netout[layersCount][j];
                Delta[layersCount - 1][j] = (Y[j] - O) * O * (1 - O);
            }

            
            //Change weights and calculate delta fo the hidden layer
            for (int k = layersCount - 1; k >= 0; k--)
            {
                // Change weights for the output layer
                for (int j = 0; j < Layers[k].countY; j++)
                {
                    for (int i = 0; i < Layers[k].countX; i++)
                    {
                        Layers[k][i, j] += learnSpeed * Delta[k][j] * Netout[k][i];
                    }
                }
                if (k > 0)
                {

                    // Calculate delta (к - 1) th layer
                    for (int j = 0; j < Layers[k - 1].countY; j++)
                    {

                        s = 0;
                        for (int i = 0; i < Layers[k].countY; i++)
                        {
                            s += Layers[k][j, i] * Delta[k][i];
                        }

                        Delta[k - 1][j] = Netout[k][j] * (1 - Netout[k][j]) * s;
                    }
                }
            }

            return CalcError(X, Y);
        }

        
        public int GetX //Return number of inputs
        {
            get { return countX; }
        }

        public int GetY //Return number of outputs
        {
            get { return countY; }
        }

        public int CountLayers //Return number of layers
        {
            get { return layersCount; }
        }

        
        // Return all neuron values before last layer
        void GetLayersValues(double[] inX, int lastLayer)
        {
            double s;

            for (int j = 0; j < Layers[0].countX; j++)
                Netout[0][j] = inX[j];

            for (int i = 0; i < lastLayer; i++)
            {
                for (int j = 0; j < Layers[i].countY; j++)
                {
                    s = 0;
                    for (int k = 0; k < Layers[i].countX; k++)
                    {
                        s += Layers[i][k, j] * Netout[i][k];
                    }

                    // Calculate the value of activation function (sigmoid)
                    s = 1.0 / (1 + Math.Exp(-s));
                    Netout[i + 1][j] = 0.998 * s + 0.001;

                }
            }

        }

        //Return all values of neurons for all layers
        void GetAllValues(double[] inX)
        {
            GetLayersValues(inX, layersCount);
        }


        int GetNetworkSize() //Return Network size in bytes
        {
            int networkSize = sizeof(int) * (layersCount + 2);
            for (int i = 0; i < layersCount; i++)
            {
                networkSize += sizeof(double) * Layers[i].countX * Layers[i].countY;
            }
            return networkSize;
        }

        
        public LayerNetwork Layer(int num) //Return num-th layer of Network
        {
            return Layers[num];
        }

        
        void WriteToArray(byte[] mas, ref int pos, int value) //Split int on bytes
        {
            DataToByte DTB = new DataToByte();
            DTB.vInt = value;
            mas[pos++] = DTB.b1;
            mas[pos++] = DTB.b2;
            mas[pos++] = DTB.b3;
            mas[pos++] = DTB.b4;
        }

        void WriteInArray(byte[] mas, ref int pos, double value) //Split double on bytes
        {
            DataToByte DTB = new DataToByte();
            DTB.vDouble = value;
            mas[pos++] = DTB.b1;
            mas[pos++] = DTB.b2;
            mas[pos++] = DTB.b3;
            mas[pos++] = DTB.b4;
            mas[pos++] = DTB.b5;
            mas[pos++] = DTB.b6;
            mas[pos++] = DTB.b7;
            mas[pos++] = DTB.b8;
        }

       
        int ReadFromArrayInt(byte[] mas, ref int pos) //Merge 4 bytes to int
        {
            DataToByte DTB = new DataToByte();
            DTB.b1 = mas[pos++];
            DTB.b2 = mas[pos++];
            DTB.b3 = mas[pos++];
            DTB.b4 = mas[pos++];

            return DTB.vInt;
        }

        
        double ReadFromArrayDouble(byte[] mas, ref int pos) //Merge 8 bytes to double
        {
            DataToByte DTB = new DataToByte();
            DTB.b1 = mas[pos++];
            DTB.b2 = mas[pos++];
            DTB.b3 = mas[pos++];
            DTB.b4 = mas[pos++];
            DTB.b5 = mas[pos++];
            DTB.b6 = mas[pos++];
            DTB.b7 = mas[pos++];
            DTB.b8 = mas[pos++];

            return DTB.vDouble;
        }

    }
}
