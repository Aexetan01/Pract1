using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract1_Ivan
{
    public class Tab
    {
		private double a;

		public double A
		{
			get { return a; }
			set { a = value; }
		}

		private double xN;

		public double Xn
		{
			get { return xN; }
			set { xN = value; }
		}

		private double xK;

		public double Xk
		{
			get { return xK; }
			set { xK = value; }
		}

		private double h;

		public double H
		{
			get { return h; }
			set { h = value; }
		}

		public Tab()
		{
			a = 0;
			xN = 0;
			xK = 0;
			h = 0;
		}

		public Tab(double a, double xN, double xK, double h)
		{
			this.a = a;
			this.xN = xN;
			this.xK = xK;
			this.h = h;
		}


		public double GetFuncResult(double x)
		{
			if(x <= 0)
			{
				return Math.Pow(x, 5) * (1d / Math.Tan(2 * Math.Pow(x, 3)));
			}
            else if (x <= a)
			{
				return 5d / (Math.Tan(2d * x + 3d) + 1d);
			}

			return Math.Tan(Math.Pow(x, 2) + 1d) * Math.Exp(-x);
        }

		public List<(double, double)> GetTab()
		{
            List<(double, double)> result = new List<(double, double)>();

            for (double x = Xn; x <= Xk; x += h)
            {
                double y = GetFuncResult(x);
                result.Add((x, y));
            }
            return result;
        }
	}
}
