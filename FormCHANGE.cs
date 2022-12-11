using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbkurs
{
    public partial class FormCHANGE : Form
    {
        public FormCHANGE()
        {
            InitializeComponent();
        }

        private void Ws_TextChanged(object sender, EventArgs e)
        {
            int? condition = System.Convert.ToInt32(Ws.Text);

            if (condition >= 2)
            {
                lbx1.Visible = true;
                lbx2.Visible = true;
                lbx3.Visible = true;
                lby1.Visible = true;
                lby2.Visible = true;
                lby3.Visible = true;

                tbx1.Visible = true;
                tbx2.Visible = true;
                tbx3.Visible = true;
                tby1.Visible = true;
                tby2.Visible = true;
                tby3.Visible = true;
            }
            
            if (condition == 3)
            {
                lbz1.Visible = true;
                lbz2.Visible = true;
                lbz3.Visible = true;
                tbz1.Visible = true;
                tbz2.Visible = true;
                tbz3.Visible = true;
            }
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
            int _Ws = System.Convert.ToInt32(Ws.Text);
            int _Rc = System.Convert.ToInt32(Rc.Text);
            double _tch = System.Convert.ToDouble(tch.Text);
            double _f1 = System.Convert.ToDouble(F1.Text);

            double K = 2.65; 

            double Ws_ = 0;
            double Rc_ = 0;

            if (_Ws == 2)
            {
                Ws_ = 1.07;
            }
            else
            {
                Ws_ = 1.15;
            }

            if (_Rc == 1)
            {
                Rc_ = 1.1;
            }
            else
            {
                Rc_ = 1.25;
            }

            double fx = 0, fy = 0, fz = 0;

            double tchx = 0, tchy = 0, tchz = 0;

            double n1x = 0 , n1y = 0, n1z = 0;

            if (_Ws >= 2)
            {
                fx = System.Convert.ToDouble(tbx1.Text);
                fy = System.Convert.ToDouble(tby1.Text);

                tchx = System.Convert.ToDouble(tbx2.Text);
                tchy = System.Convert.ToDouble(tby2.Text);

                n1x = System.Convert.ToDouble(tbx3.Text);
                n1y = System.Convert.ToDouble(tby3.Text);
            }

            if (_Ws == 3)
            {
                fz = System.Convert.ToDouble(tbz1.Text);
                tchz = System.Convert.ToDouble(tbz2.Text);
                n1z = System.Convert.ToDouble(tbz3.Text);
            }

            double fi_t = 0;
            if (_Ws == 2)
            {
                fi_t = (1 / _tch) * (tchx * Math.Pow(n1x / 1000, 1 / 6) + tchy * Math.Pow(n1y / 1000, 1 / 6));
                
            }

            else
            {
                fi_t = (1 / _tch) * (tchx * Math.Pow(n1x / 1000, 1 / 6) + tchy * Math.Pow(n1y / 1000, 1 / 6) + tchz * Math.Pow(n1z / 1000, 1 / 6));
            }

            double FI = fi_t * Ws_ * Rc_;

            double Nprom = 0;

            if (_Ws == 2)
            {
                Nprom = tchx * n1x * Math.Pow(fx / _f1, 6) + tchy * n1y * Math.Pow(fy / _f1, 6);
            }
            else
            {
                Nprom = tchx * n1x * Math.Pow(fx / _f1, 6) + tchy * n1y * Math.Pow(fy / _f1, 6) + tchz * n1z * Math.Pow(fz / _f1, 6);
            }

            double Nc = 60 * z1 / zp * Nprom;
            double Kp = FI * Math.Pow(Nc, 1 / 6);

            double sigma_cd = 0.6 * sigmaB;

            double sigmacd_p = sigma_cd / Kp;
            double S1 = 0.5 * (S + 2 * h + Math.Tan(y));

            double m = 35 * Math.Pow(N / n1, 1 / 3);

            double z2 = z1 * u;

            double a1 = 180 - Math.Abs(m * (z2 - z1) / a) * 57.3;

            double z0 = z1 * a1 / 360;

            double sigmacd = F * Kd / (z0 * S1 * b * K);

            ans1.Text = System.Convert.ToString(sigmacd);
            ans2.Text = System.Convert.ToString(sigmacd_p);
        }
    }
}
