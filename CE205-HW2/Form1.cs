using CE205_HW3.libs;

namespace CE205_HW3
{
    public partial class Form1 : Form
    {

        private Microsoft.Msagl.Drawing.Graph _graphObject;

        private const int _MAX_RANDOM = 10;
        private const int _MIN_RANDOM = 5;

        Point[] dugumler;
        int[,] _graphArray;

        int baslangic = -1;
        int bitis = -1;

        private List<string> listDugumler = new List<string>();
        private List<string> kisaYol = new List<string>();


        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public void RandomDugum(int count)
        {
            string harfler = "ABCDEFGHIJKLMNOPRSTUVYZ";
            while (listDugumler.Count < count)
            {
                char rasgeleUretilen = harfler[_random.Next(0, harfler.Length)];
                //daha önce üretilmemiþ ise ekle
                if (!listDugumler.Any(l => l == rasgeleUretilen.ToString()))
                    listDugumler.Add(rasgeleUretilen.ToString());
            }
        }

        private void ArrayToGraph(int[,] graphArray, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            for (int i = 0; i < graphArray.GetLength(0); i++)
            {
                for (int j = 0; j < graphArray.GetLength(1); j++)
                {

                    if (graphArray[i, j] > 0)
                    {
                        string fromNode = Util.GetNodeLetter(i);
                        string toNode = Util.GetNodeLetter(j);
                        string weight = graphArray[i, j].ToString();
                        graphObject.AddEdge(fromNode, weight, toNode).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
            }
        }

        private void ResetGraph()
        {
            _graphObject = new Microsoft.Msagl.Drawing.Graph("graph");

            ArrayToGraph(_graphArray, ref _graphObject);

            gViewer1.Graph = _graphObject;

            gViewer1.Refresh();
        }

        private void RandomGraphGenerate()
        {
            //int[][] a = new int[2][4];  // Two rows and four columns.

            //a[0][0] a[0][1] a[0][2] a[0][3]
            //a[1][0] a[1][1] a[1][2] a[1][3]

            int vertexSize = RandomNumber(_MIN_RANDOM, _MAX_RANDOM);

            _graphArray = new int[vertexSize, vertexSize];

            //rows
            for (int i = 0; i < _graphArray.GetLength(0); i++)
            {
                //columns
                for (int j = i; j < _graphArray.GetLength(1) - i; j++)
                {

                    if (i == j)
                        continue;

                    int weight = RandomNumber(0, 10);

                    _graphArray[i, j] = weight;
                    _graphArray[j, i] = weight;
                }
            }

            //_graphArray = new int[,] { { 0, 2, 0, 6, 0 },
            //                          { 2, 0, 3, 8, 5 },
            //                          { 0, 3, 0, 0, 7 },
            //                          { 6, 8, 0, 0, 9 },
            //                          { 0, 5, 7, 9, 0 } };

            int diziUzunluk = (int)Math.Sqrt(_graphArray.Length);
            RandomDugum(diziUzunluk);
            dugumler = new Point[diziUzunluk];
            DrawMatris(_graphArray, panel1);
            DrawGraphNode(_graphArray, panel1);
            DrawGraphLines(_graphArray, dugumler, panel1, kisaYol);
            ResetGraph();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //_graphObject.AddEdge("A", "B");
            //_graphObject.AddEdge("B", "C");
            //_graphObject.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //_graphObject.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            //_graphObject.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            //Microsoft.Msagl.Drawing.Node c = _graphObject.FindNode("C");
            //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            ////bind the graph to the viewer 
            //gViewer1.Graph = _graphObject;

            //gViewer1.Refresh();
        }

        private void YolBul(int[,] diziS)
        {
            int durum = -1;
            int oncekiDurum = -1;

            kisaYol.Clear();

            durum = baslangic;


            int sayi = listDugumler.Count;

            kisaYol.Add(listDugumler[durum].ToString());


            while (durum != bitis)
            {
                int[] dizi = new int[sayi];
                int[] index = new int[sayi];
                for (int i = 0; i < sayi; i++)
                {
                    index[i] = i;
                    dizi[i] = diziS[durum, i];
                }

                BubbleSortIndex(dizi, index);

                oncekiDurum = durum;
                durum = index[sayi - 1];


                kisaYol.Add(listDugumler[durum].ToString());
            }
        }

        private void btnRandomGraphGenerate_Click(object sender, EventArgs e)
        {
            RandomGraphGenerate();

        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (rdBtnMstAlgorithm.Checked)
            {

                ResetGraph();

                //MST Algorithm
                MST mst = new MST();

                mst.primMST(_graphArray, chkBoxClearNodes.Checked, ref _graphObject);

                gViewer1.Graph = _graphObject;

                gViewer1.Refresh();

            }
            else if (rdBtnBfsAlgorithm.Checked)
            {
                ResetGraph();
                BFS bfs = new BFS(1);
                bfs.printBFS(_graphArray, true, ref _graphObject);
                gViewer1.Graph = _graphObject;
                gViewer1.Refresh();

            }
            else if (rdBtnDfsAlgorithm.Checked)
            {
                ResetGraph();
                DFS dfs = new DFS(1);
                dfs.printDFS(_graphArray, true, ref _graphObject);
                gViewer1.Graph = _graphObject;
                gViewer1.Refresh();
            }
            else if (rdBtnSccAlgorithm.Checked)
            {
                ResetGraph();
                SCC scc = new SCC(0);
                scc.printSCC(_graphArray, true, ref _graphObject);
                gViewer1.Graph = _graphObject;
                gViewer1.Refresh();
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraph();
            panel1.Refresh();
        }


        public void DrawMatris(int[,] diziS, Panel panelS)
        {
            if (diziS == null)
                return;

            panelS.Refresh();

            SolidBrush br = new SolidBrush(SystemColors.ControlText);

            Graphics g = panelS.CreateGraphics();

            int diziUzunluk = (int)Math.Sqrt(diziS.Length);

            for (int i = 0; i < diziUzunluk; i++)
            {
                for (int j = 0; j < diziUzunluk; j++)
                {
                    g.DrawString(diziS[i, j].ToString(), this.Font, br, i * 20 + 30, j * 20 + 30);
                }
            }

            for (int i = 0; i < listDugumler.Count; i++)
            {
                g.DrawString(listDugumler[i].ToString(), this.Font, br, i * 20 + 30, 15);
            }

            for (int i = 0; i < listDugumler.Count; i++)
            {
                g.DrawString(listDugumler[i].ToString(), this.Font, br, 15, i * 20 + 30);
            }

        }

        public void DrawGraphNode(int[,] diziS, Panel panelS)
        {
            if (diziS == null)
                return;

            panelS.Refresh();

            SolidBrush br = new SolidBrush(System.Drawing.SystemColors.ControlText);

            Graphics g = panelS.CreateGraphics();

            int diziUzunluk = (int)Math.Sqrt(diziS.Length);

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < diziUzunluk; i++)
            {

                Point p = new Point();

                p.X = rand.Next(300);
                p.Y = rand.Next(300);

                dugumler[i] = p;

                g.DrawString(listDugumler[i].ToString(), this.Font, br, p);
                g.DrawEllipse(Pens.Blue, p.X - 3, p.Y - 3, 20, 20);


            }

        }

        public void DrawGraphLines(int[,] diziS, Point[] dugumler, Panel panelS, List<string> kisayol)
        {
            if (diziS == null)
                return;

            SolidBrush br = new SolidBrush(System.Drawing.SystemColors.ControlText);

            Graphics g = panelS.CreateGraphics();

            int diziUzunluk = (int)Math.Sqrt(diziS.Length);

            StreamWriter yazici = new StreamWriter("koord.txt");

            string koordinatInfo = null;

            for (int i = 0; i < diziUzunluk; i++)
            {
                for (int j = 0; j < diziUzunluk; j++)
                {

                    if (diziS[i, j] == 0)
                    {
                        g.DrawLine(Pens.Black, dugumler[i], dugumler[j]);

                        koordinatInfo = koordinatInfo + "0." + dugumler[i].X.ToString() + "," + "0." + dugumler[i].Y.ToString() + ",0.0,";
                        koordinatInfo = koordinatInfo + "0." + dugumler[j].X.ToString() + "," + "0." + dugumler[j].Y.ToString() + ",0.0,";
                        koordinatInfo = koordinatInfo + "1,1,1";

                        yazici.WriteLine(koordinatInfo);

                        koordinatInfo = null;
                    }

                }
            }

            if (kisayol != null)
            {
                for (int i = 0; i < kisayol.Count - 1; i++)
                {
                    g.DrawLine(Pens.Red, dugumler[listDugumler.IndexOf(kisayol[i])].X + 3, dugumler[listDugumler.IndexOf(kisayol[i])].Y + 3, dugumler[listDugumler.IndexOf(kisayol[i + 1])].X + 3, dugumler[listDugumler.IndexOf(kisayol[i + 1])].Y + 3);

                    koordinatInfo = koordinatInfo + "0." + dugumler[listDugumler.IndexOf(kisayol[i])].X.ToString() + "," + "0." + dugumler[listDugumler.IndexOf(kisayol[i])].Y.ToString() + ",0.03,";
                    koordinatInfo = koordinatInfo + "0." + dugumler[listDugumler.IndexOf(kisayol[i + 1])].X.ToString() + "," + "0." + dugumler[listDugumler.IndexOf(kisayol[i + 1])].Y.ToString() + ",0.03,";
                    koordinatInfo = koordinatInfo + "1,1,0";

                    yazici.WriteLine(koordinatInfo);

                    koordinatInfo = null;

                }
            }

            yazici.Close();

        }


        public void BubbleSortIndex(int[] dizi, int[] index)
        {
            int gecici;
            int temp;

            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        temp = index[j - 1];
                        dizi[j - 1] = dizi[j];
                        index[j - 1] = index[j];
                        dizi[j] = gecici;
                        index[j] = temp;


                    }
                }
            }
        }


    }
}