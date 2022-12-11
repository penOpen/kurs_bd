using System;
using System.Windows.Forms;

namespace Dbkurs
{
    public partial class FormCONST : Form
    {
        public FormCONST()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //from Form1
            double z1 = System.Convert.ToDouble(Program.f1.z1.Text);
            double u = System.Convert.ToDouble(Program.f1.u.Text);
            double Kd = System.Convert.ToDouble(Program.f1.Kd.Text);
            double a = System.Convert.ToDouble(Program.f1.a.Text);
            double n1 = System.Convert.ToDouble(Program.f1.n1.Text);
            double N = System.Convert.ToDouble(Program.f1.N.Text);
            double y = System.Convert.ToDouble(Program.f1.y.Text);
            double S = System.Convert.ToDouble(Program.f1.S.Text);
            double h = System.Convert.ToDouble(Program.f1.h.Text);
            double b = System.Convert.ToDouble(Program.f1.b.Text);
            double sigmaB = System.Convert.ToDouble(Program.f1.sigmaB.Text);
            double F = System.Convert.ToDouble(Program.f1.F.Text);
            double zp = System.Convert.ToDouble(Program.f1.zp.Text);
            //
            double _tch = System.Convert.ToDouble(tch.Text);
            double _Rc = System.Convert.ToDouble(Rc.Text);
            double _Ws = System.Convert.ToDouble(Ws.Text);
            //

            double fi_t = Math.Pow(n1/1000, 1/6);
            double fi_c = 0;
            if (_Ws == 2)
                fi_c = 1.07;
            else
                fi_c = 1.15;
            double fi_p = 0;
            if (_Rc == 1)
                fi_p = 1.1;
            else
                fi_p = 1.25;

            double FI = fi_t * fi_c * fi_p;

            double Nc = 60 * (z1 / zp) * _tch * n1;

            double Kp = FI * Math.Pow(Nc, 1 / 6);

            double sigmacd_ = 0.8 * sigmaB;

            double sigmacd_p = sigmacd_ / Kp;

            double K = 2.65;
            double S1 = 0.5 * (S + 2 * h * Math.Tan(y));
            double z2 = z1 * u;
            double m = 35 * Math.Pow(N / n1, 1 / 3);
            double a1 = 180 - Math.Abs((m * (z2 - z1) / a)) * 57.3;
            double z0 = z1 * a1 / 360;

            double sigma_cd = F * Kd / z0 * S1 * b * K;

            label6.Text = System.Convert.ToString(sigma_cd);
            label7.Text = System.Convert.ToString(sigmacd_p);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
