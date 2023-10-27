using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Ivan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbXn.Text, out double Xn) &&
                double.TryParse(tbXk.Text, out double Xk) &&
                double.TryParse(tbH.Text, out double H) &&
                double.TryParse(tbA.Text, out double A))
            {

                Tab tabulation = new Tab(A, Xn, Xk, H);
                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();


                List<(double, double)> xy = tabulation.GetTab();

                for (int i = 0; i < xy.Count; i++)
                {
                    dataGridView1.Rows.Add(xy[i].Item1, xy[i].Item2);
                    chart1.Series[0].Points.AddXY(xy[i].Item1, xy[i].Item2);
                }

            }
            else
            {
                MessageBox.Show("Enter correct data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
