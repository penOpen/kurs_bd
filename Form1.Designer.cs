namespace Dbkurs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.z1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.sigmaB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.zp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число зубьев меньшего шкива z1";
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(15, 27);
            this.z1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(100, 22);
            this.z1.TabIndex = 1;
            this.z1.TextChanged += new System.EventHandler(this.z1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расстояние между осями шкивов a";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(15, 153);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коэф динамичности нагрузки Kд";
            // 
            // Kd
            // 
            this.Kd.Location = new System.Drawing.Point(15, 111);
            this.Kd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(100, 22);
            this.Kd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Передаточное число u";
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(15, 69);
            this.u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(100, 22);
            this.u.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Частота вращения меньшего шкива n1";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(15, 195);
            this.n1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 22);
            this.n1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Мощность, передаваемая ремнем N";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(15, 237);
            this.N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 22);
            this.N.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Угол профиля y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Наименьшая толщина зуба S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Высота зуба h";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Шириня ремня b";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(389, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Предел прочности резины на отрыв от основания sigma в\'";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(15, 297);
            this.y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 22);
            this.y.TabIndex = 17;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(15, 350);
            this.S.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(100, 22);
            this.S.TabIndex = 18;
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(15, 392);
            this.h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 22);
            this.h.TabIndex = 19;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(15, 446);
            this.b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 20;
            // 
            // sigmaB
            // 
            this.sigmaB.Location = new System.Drawing.Point(15, 516);
            this.sigmaB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sigmaB.Name = "sigmaB";
            this.sigmaB.Size = new System.Drawing.Size(100, 22);
            this.sigmaB.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Постоянный режим работы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 48);
            this.button2.TabIndex = 23;
            this.button2.Text = "Переменный режим работы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(393, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Число зубьев ремня zp";
            // 
            // zp
            // 
            this.zp.Location = new System.Drawing.Point(627, 15);
            this.zp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zp.Name = "zp";
            this.zp.Size = new System.Drawing.Size(100, 22);
            this.zp.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 554);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Введите нагрузку F";
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(15, 584);
            this.F.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(100, 22);
            this.F.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 656);
            this.Controls.Add(this.F);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.zp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sigmaB);
            this.Controls.Add(this.b);
            this.Controls.Add(this.h);
            this.Controls.Add(this.S);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.u);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox z1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox a;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Kd;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox u;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox n1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox N;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox y;
        public System.Windows.Forms.TextBox S;
        public System.Windows.Forms.TextBox h;
        public System.Windows.Forms.TextBox b;
        public System.Windows.Forms.TextBox sigmaB;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox zp;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox F;
    }
}

