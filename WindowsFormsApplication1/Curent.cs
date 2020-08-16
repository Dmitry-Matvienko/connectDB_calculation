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
    public partial class Curent : Form
    {
        public Curent()
        {
            InitializeComponent();

        }


        private void электромагнитныеКолебанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kolebaniya kolebaniya = new Kolebaniya();
            kolebaniya.StartPosition = FormStartPosition.CenterScreen;
            kolebaniya.Show();
        }

        private void кинематикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kinematics kinematics = new Kinematics();
            kinematics.StartPosition = FormStartPosition.CenterScreen;
            kinematics.Show();
        }

        private void магнетизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagnetismForm magnetism = new MagnetismForm();
            magnetism.StartPosition = FormStartPosition.CenterScreen;
            magnetism.Show();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            double U = Convert.ToDouble(Tension.Text);
            double R = Convert.ToDouble(Resistance.Text);

            double I;

            I = U / R;

            Answer.Text = I.ToString("Ответ: ") + I + "ом.";
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


        Point LastPoint;
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left = 300;
            button1.Top = 400;
        }

     




    }
}
