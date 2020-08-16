namespace WindowsFormsApplication1
{
    partial class MagnetismForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CalculationWaveLength = new System.Windows.Forms.Button();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelSpeedWave = new System.Windows.Forms.Label();
            this.AnswerWaveLength = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.TextBox();
            this.SpeedWave = new System.Windows.Forms.TextBox();
            this.WaveLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электромагнитныеКолебанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинематикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электрическийТокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магнетизмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электростатикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.TurnButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.CalculationWaveLength);
            this.panel1.Controls.Add(this.labelPeriod);
            this.panel1.Controls.Add(this.labelSpeedWave);
            this.panel1.Controls.Add(this.AnswerWaveLength);
            this.panel1.Controls.Add(this.Period);
            this.panel1.Controls.Add(this.SpeedWave);
            this.panel1.Controls.Add(this.WaveLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 318);
            this.panel1.TabIndex = 2;
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.White;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_fullscreen_close_4417879;
            this.TurnButton.Location = new System.Drawing.Point(703, 1);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 26);
            this.TurnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnButton.TabIndex = 12;
            this.TurnButton.TabStop = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_close15_216468;
            this.CloseButton.Location = new System.Drawing.Point(734, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 26);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 11;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // CalculationWaveLength
            // 
            this.CalculationWaveLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CalculationWaveLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationWaveLength.ForeColor = System.Drawing.Color.White;
            this.CalculationWaveLength.Location = new System.Drawing.Point(12, 224);
            this.CalculationWaveLength.Name = "CalculationWaveLength";
            this.CalculationWaveLength.Size = new System.Drawing.Size(107, 42);
            this.CalculationWaveLength.TabIndex = 8;
            this.CalculationWaveLength.Text = "Посчитать";
            this.CalculationWaveLength.UseVisualStyleBackColor = false;
            this.CalculationWaveLength.Click += new System.EventHandler(this.CalculationWaveLength_Click);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeriod.ForeColor = System.Drawing.Color.White;
            this.labelPeriod.Location = new System.Drawing.Point(154, 155);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(57, 15);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "Период";
            // 
            // labelSpeedWave
            // 
            this.labelSpeedWave.AutoSize = true;
            this.labelSpeedWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeedWave.ForeColor = System.Drawing.Color.White;
            this.labelSpeedWave.Location = new System.Drawing.Point(3, 155);
            this.labelSpeedWave.Name = "labelSpeedWave";
            this.labelSpeedWave.Size = new System.Drawing.Size(116, 15);
            this.labelSpeedWave.TabIndex = 6;
            this.labelSpeedWave.Text = "Скорость волны";
            // 
            // AnswerWaveLength
            // 
            this.AnswerWaveLength.AutoSize = true;
            this.AnswerWaveLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerWaveLength.Location = new System.Drawing.Point(138, 224);
            this.AnswerWaveLength.Name = "AnswerWaveLength";
            this.AnswerWaveLength.Size = new System.Drawing.Size(0, 17);
            this.AnswerWaveLength.TabIndex = 5;
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(136, 173);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(90, 35);
            this.Period.TabIndex = 4;
            // 
            // SpeedWave
            // 
            this.SpeedWave.Location = new System.Drawing.Point(12, 173);
            this.SpeedWave.Name = "SpeedWave";
            this.SpeedWave.Size = new System.Drawing.Size(82, 35);
            this.SpeedWave.TabIndex = 3;
            // 
            // WaveLength
            // 
            this.WaveLength.AutoSize = true;
            this.WaveLength.ForeColor = System.Drawing.Color.White;
            this.WaveLength.Location = new System.Drawing.Point(12, 84);
            this.WaveLength.Name = "WaveLength";
            this.WaveLength.Size = new System.Drawing.Size(178, 29);
            this.WaveLength.TabIndex = 2;
            this.WaveLength.Text = "Длина волны";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Магнетизм";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 33);
            this.panel2.TabIndex = 0;
           
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
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
            // 
            // электростатикаToolStripMenuItem
            // 
            this.электростатикаToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_Current_flow_electric_current_electric_wave_electrical_current_electricity_4753029;
            this.электростатикаToolStripMenuItem.Name = "электростатикаToolStripMenuItem";
            this.электростатикаToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.электростатикаToolStripMenuItem.Text = "Электростатика";
            this.электростатикаToolStripMenuItem.Click += new System.EventHandler(this.электростатикаToolStripMenuItem_Click);
            // 
            // MagnetismForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 318);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MagnetismForm";
            this.Text = "MagnetismForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электромагнитныеКолебанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинематикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электрическийТокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магнетизмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электростатикаToolStripMenuItem;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelSpeedWave;
        private System.Windows.Forms.Label AnswerWaveLength;
        private System.Windows.Forms.TextBox Period;
        private System.Windows.Forms.TextBox SpeedWave;
        private System.Windows.Forms.Label WaveLength;
        private System.Windows.Forms.Button CalculationWaveLength;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox TurnButton;
    }
}