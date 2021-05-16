using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Random rand;
        public int param;
        public int N;
        public Form1()
        {
            rand = new Random();
           
            InitializeComponent();
        }

        public int Puas()
        {
            double S = 0;
            int m = 0;
            do
            {
                double alpha = rand.NextDouble();
                S += Math.Log(alpha);
                m++;
            } while (S >= -param);
            return m - 1;
        }
                
        public double Chi(List<Event> events, List<Event> probs, int n)
        {
            double ans = 0;
            double up = 0;
            double down = 0;

            for (int i = 0; i < probs.Count; i++)
            {
                up += (i + 1)/3 * (int)events[i].val;
                down += (int)events[i].val;
            }

            return up / down;
        }

        public double AbsAvg(List<Event> probs)
        {
            double ans = 0;

            for (int i = 0; i < probs.Count; i++)
            {
                ans += (i + 1) * probs[i].val;
            }

            return (double)ans;
        }

        public double Avg(List<Event> events)
        {
            int up = 0;
            int down = 0;

            for (int i = 0; i < events.Count; i++)
            {
                up += (i + 2) * (int)events[i].val;
                down += (int)events[i].val;
            }

            return (double)up / down;
        }

        public double Var(List<Event> events, double avg)
        {
            double up = 0;
            int down = 0;

            for (int i = 0; i < events.Count; i++)
            {
                up += Math.Pow((i + 1 - avg), 2) * (int)events[i].val;
                down += (int)events[i].val;
            }

            return (double)up / down;
        }

        public double AbsVar(List<Event> values, double absAvg)
        {
            double ans = 0;

            for (int i = 0; i < values.Count; i++)
            {
                ans += Math.Pow((i + 1 - absAvg), 2) * values[i].val;
            }

            return (double)ans;
        }

        public bool CheckChi(double chi)
        {
            double alpha = 11.07;

            if (chi < alpha)
                return true;
            else
                return false;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            param = (int)numericP1.Value;
            N = (int)numericN.Value;

            List<Event> events = new List<Event>();

            for (int i = 0; i < N; i++)
            {
                int x = Puas();
                bool flag = false;
                foreach (var item in events)
                {
                    if (item.x == x)
                    {
                        item.val++;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    var ev = new Event(x);
                    events.Add(ev);
                }
            }

            var probs = Event.MakeACopy(events);

            foreach (var item in probs)
            {
                item.val = item.val / N;
                chart1.Series[0].Points.AddXY(item.x, item.val);
            }

            double avg = Avg(events);
            double absAvg = AbsAvg(probs);
            double var = Math.Round(Var(events, avg), 5);
            double absVar = AbsVar(probs, absAvg);
            double chi = Math.Round(Chi(events, probs, N), 5);

            double error1 = Math.Round(((Math.Abs(avg - absAvg) / Math.Abs(absAvg))) * 100, 2);
            double error2 = Math.Round(((Math.Abs(var - absVar) / Math.Abs(absVar))) * 100, 2);

            label2.Text = avg.ToString() + " (" + error1 + "% error )";
            label7.Text = var.ToString() + " (" + error2 + "% error )";
            label8.Text = chi.ToString() + " < 11.07 " + "is " + CheckChi(chi).ToString();
        }
    }
}
