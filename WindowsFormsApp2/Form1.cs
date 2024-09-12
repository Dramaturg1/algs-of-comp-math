using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double f(double x)
        {
            double[] array = { 1, -18, 144, -672, 2016, -4032, 5376, -4608, 2304, -512 };
            double p = array[0] * x + array[1];
            for (int i = 2; i < array.Length; i++)
            {
                p = p * x + array[i];
            }
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane pane = zedGraphControl2.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            double xmin = 1.92;
            double xmax = 2.08;

            for (double x = xmin; x <= xmax; x += 0.0001)
            {
                list.Add(x, f(x));
            }
            LineItem myCurve = pane.AddCurve("(x-2)^9", list, Color.Magenta, SymbolType.None);
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }

    }
}
