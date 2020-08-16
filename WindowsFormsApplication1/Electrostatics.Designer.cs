namespace WindowsFormsApplication1
{
    partial class Electrostatics
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
            this.label1 = new System.Windows.Forms.Label();
            this.Calculation = new System.Windows.Forms.Button();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Charge = new System.Windows.Forms.TextBox();
            this.Potensial = new System.Windows.Forms.TextBox();
            this.WaveLength = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электромагнитныеКолебанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинематикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электрическийТокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магнетизмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электростатикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Электростатика";
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculation.ForeColor = System.Drawing.Color.White;
            this.Calculation.Location = new System.Drawing.Point(12, 259);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(107, 38);
            this.Calculation.TabIndex = 8;
            this.Calculation.Text = "Посчитать";
            this.Calculation.UseVisualStyleBackColor = false;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeriod.ForeColor = System.Drawing.Color.White;
            this.labelPeriod.Location = new System.Drawing.Point(212, 174);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(133, 15);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "R - сопротивление";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(144, 259);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 17);
            this.Answer.TabIndex = 5;
            // 
            // Charge
            // 
            this.Charge.Location = new System.Drawing.Point(233, 206);
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(90, 35);
            this.Charge.TabIndex = 4;
            // 
            // Potensial
            // 
            this.Potensial.Location = new System.Drawing.Point(12, 206);
            this.Potensial.Name = "Potensial";
            this.Potensial.Size = new System.Drawing.Size(82, 35);
            this.Potensial.TabIndex = 3;
            // 
            // WaveLength
            // 
            this.WaveLength.AutoSize = true;
            this.WaveLength.ForeColor = System.Drawing.Color.White;
            this.WaveLength.Location = new System.Drawing.Point(12, 84);
            this.WaveLength.Name = "WaveLength";
            this.WaveLength.Size = new System.Drawing.Size(428, 29);
            this.WaveLength.TabIndex = 2;
            this.WaveLength.Text = "Потенциал электрического поля";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 29);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.электромагнитныеКолебанияToolStripMenuItem,
            this.кинематикаToolStripMenuItem,
            this.электрическийТокToolStripMenuItem,
            this.магнетизмToolStripMenuItem,
            this.электростатикаToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_App_Services_copy_Amazon_SNS_Topic_259245;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.ToolStripMenuItem.Text = "Тема";
            // 
            // электромагнитныеКолебанияToolStripMenuItem
            // 
            this.электромагнитныеКолебанияToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._007___Oscillation_512;
            this.электромагнитныеКолебанияToolStripMenuItem.Name = "электромагнитныеКолебанияToolStripMenuItem";
            this.электромагнитныеКолебанияToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.электромагнитныеКолебанияToolStripMenuItem.Text = "Электромагнитные колебания";
            this.электромагнитныеКолебанияToolStripMenuItem.Click += new System.EventHandler(this.электромагнитныеКолебанияToolStripMenuItem_Click);
            // 
            // кинематикаToolStripMenuItem
            // 
            this.кинематикаToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.depositphotos_309732072_stock_illustration_classical_physics_blue_violet_flat;
            this.кинематикаToolStripMenuItem.Name = "кинематикаToolStripMenuItem";
            this.кинематикаToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.кинематикаToolStripMenuItem.Text = "Кинематика";
            this.кинематикаToolStripMenuItem.Click += new System.EventHandler(this.кинематикаToolStripMenuItem_Click);
            // 
            // электрическийТокToolStripMenuItem
            // 
            this.электрическийТокToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._22_512;
            this.электрическийТокToolStripMenuItem.Name = "электрическийТокToolStripMenuItem";
            this.электрическийТокToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.электрическийТокToolStripMenuItem.Text = "Электрический ток";
            this.электрическийТокToolStripMenuItem.Click += new System.EventHandler(this.электрическийТокToolStripMenuItem_Click);
            // 
            // магнетизмToolStripMenuItem
            // 
            this.магнетизмToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_engage_2199100;
            this.магнетизмToolStripMenuItem.Name = "магнетизмToolStripMenuItem";
            this.магнетизмToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.магнетизмToolStripMenuItem.Text = "Магнетизм";
            this.магнетизмToolStripMenuItem.Click += new System.EventHandler(this.магнетизмToolStripMenuItem_Click);
            // 
            // электростатикаToolStripMenuItem
            // 
            this.электростатикаToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_Current_flow_electric_current_electric_wave_electrical_current_electricity_4753029;
            this.электростатикаToolStripMenuItem.Name = "электростатикаToolStripMenuItem";
            this.электростатикаToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.электростатикаToolStripMenuItem.Text = "Электростатика";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.TurnButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Calculation);
            this.panel1.Controls.Add(this.labelPeriod);
            this.panel1.Controls.Add(this.Answer);
            this.panel1.Controls.Add(this.Charge);
            this.panel1.Controls.Add(this.Potensial);
            this.panel1.Controls.Add(this.WaveLength);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 378);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 50);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "W – потенциальная энергия заряда во внешнем электрическом поле.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "φ = W / q";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_close15_216468;
            this.CloseButton.Location = new System.Drawing.Point(768, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 26);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 11;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.White;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_fullscreen_close_4417879;
            this.TurnButton.Location = new System.Drawing.Point(737, 0);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 26);
            this.TurnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnButton.TabIndex = 12;
            this.TurnButton.TabStop = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // Electrostatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 378);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Electrostatics";
            this.Text = "Electrostatics";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem электростатикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электрическийТокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинематикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электромагнитныеКолебанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магнетизмToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox Charge;
        private System.Windows.Forms.TextBox Potensial;
        private System.Windows.Forms.Label WaveLength;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox TurnButton;
    }
}