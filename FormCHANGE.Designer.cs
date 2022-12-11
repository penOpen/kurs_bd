namespace Dbkurs
{
    partial class FormCHANGE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Rc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ws = new System.Windows.Forms.TextBox();
            this.lbx1 = new System.Windows.Forms.Label();
            this.lby1 = new System.Windows.Forms.Label();
            this.lbz1 = new System.Windows.Forms.Label();
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx3 = new System.Windows.Forms.Label();
            this.lby2 = new System.Windows.Forms.Label();
            this.lby3 = new System.Windows.Forms.Label();
            this.lbz2 = new System.Windows.Forms.Label();
            this.lbz3 = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tby3 = new System.Windows.Forms.TextBox();
            this.tbz1 = new System.Windows.Forms.TextBox();
            this.tbz2 = new System.Windows.Forms.TextBox();
            this.tbz3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.F1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.Label();
            this.ans2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество роликов (1 или 2)";
            // 
            // Rc
            // 
            this.Rc.Location = new System.Drawing.Point(15, 116);
            this.Rc.Name = "Rc";
            this.Rc.Size = new System.Drawing.Size(154, 22);
            this.Rc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Число смен работы передачи в сутки (2 или 3)";
            // 
            // Ws
            // 
            this.Ws.Location = new System.Drawing.Point(15, 196);
            this.Ws.Name = "Ws";
            this.Ws.Size = new System.Drawing.Size(154, 22);
            this.Ws.TabIndex = 6;
            this.Ws.TextChanged += new System.EventHandler(this.Ws_TextChanged);
            // 
            // lbx1
            // 
            this.lbx1.AutoSize = true;
            this.lbx1.Location = new System.Drawing.Point(487, 18);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(91, 16);
            this.lbx1.TabIndex = 7;
            this.lbx1.Text = "Нагрузка F1i";
            this.lbx1.Visible = false;
            // 
            // lby1
            // 
            this.lby1.AutoSize = true;
            this.lby1.Location = new System.Drawing.Point(723, 18);
            this.lby1.Name = "lby1";
            this.lby1.Size = new System.Drawing.Size(91, 16);
            this.lby1.TabIndex = 8;
            this.lby1.Text = "Нагрузка F2i";
            this.lby1.Visible = false;
            // 
            // lbz1
            // 
            this.lbz1.AutoSize = true;
            this.lbz1.Location = new System.Drawing.Point(917, 18);
            this.lbz1.Name = "lbz1";
            this.lbz1.Size = new System.Drawing.Size(91, 16);
            this.lbz1.TabIndex = 9;
            this.lbz1.Text = "Нагрузка F3i";
            this.lbz1.Visible = false;
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Location = new System.Drawing.Point(475, 101);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(120, 16);
            this.lbx2.TabIndex = 10;
            this.lbx2.Text = "Время работы tч1";
            this.lbx2.Visible = false;
            // 
            // lbx3
            // 
            this.lbx3.AutoSize = true;
            this.lbx3.Location = new System.Drawing.Point(403, 196);
            this.lbx3.Name = "lbx3";
            this.lbx3.Size = new System.Drawing.Size(253, 16);
            this.lbx3.TabIndex = 11;
            this.lbx3.Text = "Частота вращения шкива в минуту n1i";
            this.lbx3.Visible = false;
            // 
            // lby2
            // 
            this.lby2.AutoSize = true;
            this.lby2.Location = new System.Drawing.Point(723, 101);
            this.lby2.Name = "lby2";
            this.lby2.Size = new System.Drawing.Size(120, 16);
            this.lby2.TabIndex = 12;
            this.lby2.Text = "Время работы tч2";
            this.lby2.Visible = false;
            // 
            // lby3
            // 
            this.lby3.AutoSize = true;
            this.lby3.Location = new System.Drawing.Point(729, 196);
            this.lby3.Name = "lby3";
            this.lby3.Size = new System.Drawing.Size(24, 16);
            this.lby3.TabIndex = 13;
            this.lby3.Text = "n2i";
            this.lby3.Visible = false;
            // 
            // lbz2
            // 
            this.lbz2.AutoSize = true;
            this.lbz2.Location = new System.Drawing.Point(917, 101);
            this.lbz2.Name = "lbz2";
            this.lbz2.Size = new System.Drawing.Size(120, 16);
            this.lbz2.TabIndex = 14;
            this.lbz2.Text = "Время работы tч3";
            this.lbz2.Visible = false;
            // 
            // lbz3
            // 
            this.lbz3.AutoSize = true;
            this.lbz3.Location = new System.Drawing.Point(917, 196);
            this.lbz3.Name = "lbz3";
            this.lbz3.Size = new System.Drawing.Size(24, 16);
            this.lbz3.TabIndex = 15;
            this.lbz3.Text = "n3i";
            this.lbz3.Visible = false;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(478, 52);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 22);
            this.tbx1.TabIndex = 16;
            this.tbx1.Visible = false;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(478, 142);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 22);
            this.tbx2.TabIndex = 17;
            this.tbx2.Visible = false;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(478, 229);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 22);
            this.tbx3.TabIndex = 18;
            this.tbx3.Visible = false;
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(726, 52);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(100, 22);
            this.tby1.TabIndex = 19;
            this.tby1.Visible = false;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(726, 142);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(100, 22);
            this.tby2.TabIndex = 20;
            this.tby2.Visible = false;
            // 
            // tby3
            // 
            this.tby3.Location = new System.Drawing.Point(726, 229);
            this.tby3.Name = "tby3";
            this.tby3.Size = new System.Drawing.Size(100, 22);
            this.tby3.TabIndex = 21;
            this.tby3.Visible = false;
            // 
            // tbz1
            // 
            this.tbz1.Location = new System.Drawing.Point(920, 52);
            this.tbz1.Name = "tbz1";
            this.tbz1.Size = new System.Drawing.Size(100, 22);
            this.tbz1.TabIndex = 22;
            this.tbz1.Visible = false;
            // 
            // tbz2
            // 
            this.tbz2.Location = new System.Drawing.Point(920, 142);
            this.tbz2.Name = "tbz2";
            this.tbz2.Size = new System.Drawing.Size(100, 22);
            this.tbz2.TabIndex = 23;
            this.tbz2.Visible = false;
            // 
            // tbz3
            // 
            this.tbz3.Location = new System.Drawing.Point(920, 229);
            this.tbz3.Name = "tbz3";
            this.tbz3.Size = new System.Drawing.Size(100, 22);
            this.tbz3.TabIndex = 24;
            this.tbz3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 128);
            this.button1.TabIndex = 25;
            this.button1.Text = "РАСЧЁТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Введите общее время работы передачи tч";
            // 
            // tch
            // 
            this.tch.Location = new System.Drawing.Point(15, 52);
            this.tch.Name = "tch";
            this.tch.Size = new System.Drawing.Size(154, 22);
            this.tch.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Максимально длительная действующая нагрузка F1";
            // 
            // F1
            // 
            this.F1.Location = new System.Drawing.Point(478, 340);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(154, 22);
            this.F1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Расчетная прочность зубьев ремня sigma cd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Допускаемая прочность зубьев ремня sigma cd";
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(952, 415);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(0, 16);
            this.ans1.TabIndex = 32;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(961, 460);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(0, 16);
            this.ans2.TabIndex = 33;
            // 
            // FormCHANGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 687);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbz3);
            this.Controls.Add(this.tbz2);
            this.Controls.Add(this.tbz1);
            this.Controls.Add(this.tby3);
            this.Controls.Add(this.tby2);
            this.Controls.Add(this.tby1);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lbz3);
            this.Controls.Add(this.lbz2);
            this.Controls.Add(this.lby3);
            this.Controls.Add(this.lby2);
            this.Controls.Add(this.lbx3);
            this.Controls.Add(this.lbx2);
            this.Controls.Add(this.lbz1);
            this.Controls.Add(this.lby1);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.Ws);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rc);
            this.Controls.Add(this.label2);
            this.Name = "FormCHANGE";
            this.Text = "FormCHANGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ws;
        private System.Windows.Forms.Label lbx1;
        private System.Windows.Forms.Label lby1;
        private System.Windows.Forms.Label lbz1;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx3;
        private System.Windows.Forms.Label lby2;
        private System.Windows.Forms.Label lby3;
        private System.Windows.Forms.Label lbz2;
        private System.Windows.Forms.Label lbz3;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tby3;
        private System.Windows.Forms.TextBox tbz1;
        private System.Windows.Forms.TextBox tbz2;
        private System.Windows.Forms.TextBox tbz3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox F1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ans1;
        private System.Windows.Forms.Label ans2;
    }
}