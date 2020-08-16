using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MagnetismForm : Form
    {
        public MagnetismForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void CalculationWaveLength_Click(object sender, EventArgs e) // расчет длины волны
        {
          
            double v = Convert.ToDouble(SpeedWave.Text);
            double T = Convert.ToDouble(Period.Text);

            double Calculate;
            Calculate = (v * T) / 10;
            AnswerWaveLength.Text = Calculate.ToString("Ответ: ") + Calculate + " м.";
        }

        private void кинематикаToolStripMenuItem_Click(object sender, EventArgs e) // перебрасываем на тему "Кинематика"
        {
            this.Hide();
            Kinematics kinematics = new Kinematics();
            kinematics.StartPosition = FormStartPosition.CenterScreen;
            kinematics.Show();
        }

        private void электромагнитныеКолебанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kolebaniya kolebaniya = new Kolebaniya();
            kolebaniya.StartPosition = FormStartPosition.CenterScreen;
            kolebaniya.Show();
        }

        private void электрическийТокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curent curent = new Curent();
            curent.StartPosition = FormStartPosition.CenterScreen;
            curent.Show();
        }

        private void электростатикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electrostatics electrostatics = new Electrostatics();
            electrostatics.StartPosition = FormStartPosition.CenterScreen;
            electrostatics.Show();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Minimized;
            }
        }

      
        

       

    }
}
