using System;
using System.Collections.Generic;
using System.Linq;

namespace MathStatClass
{
    public class Calculations
    {
        private string _outputString = "";
        private List<double> _sp1;
        private List<double> _sp2;
        private string _inputNumb ;


        public Calculations(string inputNumb)
        {
            _inputNumb = inputNumb;
        }

        double M(List<double> t) //general average
        {
            return t.Average();
        }
        double D(List<double> t) //adjusted variance
        {
            double m = M(t);
            return t.Sum(a => (a - m) * (a - m)) / (t.Count - 1);
        }
        double G(List<double> t) //standard deviation
        {
            return Math.Sqrt(D(t));
        }
        public void MainCalculationMethod()
        {
            int N = Convert.ToInt16(_inputNumb);
            if (int.TryParse(_inputNumb, out N))
            {
                Random rand = new Random();
                _sp1 = new List<double>(N);
                _sp2 = new List<double>(N);
                for (int i = 0; i < N; i++)
                {
                    _sp1.Add(rand.Next(0, 10));
                    _sp2.Add(rand.Next(0, 10));
                }
                double M_X = M(_sp1);
                double D_X = D(_sp1);
                double G_X = G(_sp1);
              
                _outputString += (String.Format("first \r\n {0}\r\n {1}\r\n {2}\r\n", M_X, D_X, G_X));
                double Kxy = K(_sp1, _sp2);
                M_X = M(_sp2);
                D_X = D(_sp2);
                G_X = G(_sp2);
                _outputString += (String.Format("second \r\n {0}\r\n {1}\r\n {2}\r\n", M_X, D_X, G_X));
                _outputString += ("K(x,y):" + Kxy);
                
              
            }
            else Console.WriteLine("The number of elements must be an integer");
        }
        double K(List<double> x, List<double> y)
        {
            double mx = M(x);
            double my = M(y);
            return M(x.Select((a, b) => (a - mx) * (y[b] - my)).ToList()) / (G(x) * G(y));
        }

        public override string ToString()
        {
            return _outputString + "\n" + String.Join(" ", _sp1) + "\n" + String.Join(" ", _sp2);
        }
    }
}