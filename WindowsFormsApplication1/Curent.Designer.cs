﻿namespace WindowsFormsApplication1
{
    partial class Curent
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
            this.Calculation = new System.Windows.Forms.Button();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelSpeedWave = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Resistance = new System.Windows.Forms.TextBox();
            this.Tension = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "I = U/R";
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculation.Location = new System.Drawing.Point(12, 244);
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
            this.labelPeriod.Location = new System.Drawing.Point(138, 155);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(133, 15);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "R - сопротивление";
            // 
            // labelSpeedWave
            // 
            this.labelSpeedWave.AutoSize = true;
            this.labelSpeedWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeedWave.ForeColor = System.Drawing.Color.White;
            this.labelSpeedWave.Location = new System.Drawing.Point(3, 155);
            this.labelSpeedWave.Name = "labelSpeedWave";
            this.labelSpeedWave.Size = new System.Drawing.Size(112, 15);
            this.labelSpeedWave.TabIndex = 6;
            this.labelSpeedWave.Text = "U - напряжение";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(138, 224);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 17);
            this.Answer.TabIndex = 5;
            // 
            // Resistance
            // 
            this.Resistance.Location = new System.Drawing.Point(157, 173);
            this.Resistance.Name = "Resistance";
            this.Resistance.Size = new System.Drawing.Size(90, 35);
            this.Resistance.TabIndex = 4;
            // 
            // Tension
            // 
            this.Tension.Location = new System.Drawing.Point(12, 173);
            this.Tension.Name = "Tension";
            this.Tension.Size = new System.Drawing.Size(82, 35);
            this.Tension.TabIndex = 3;
            // 
            // WaveLength
            // 
            this.WaveLength.AutoSize = true;
            this.WaveLength.ForeColor = System.Drawing.Color.White;
            this.WaveLength.Location = new System.Drawing.Point(12, 84);
            this.WaveLength.Name = "WaveLength";
            this.WaveLength.Size = new System.Drawing.Size(147, 29);
            this.WaveLength.TabIndex = 2;
            this.WaveLength.Text = "Закон Ома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Электрический ток";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 29);
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
            this.menuStrip1.Size = new System.Drawing.Size(786, 33);
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
            this.электростатикаToolStripMenuItem.Click += new System.EventHandler(this.электростатикаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.TurnButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Calculation);
            this.panel1.Controls.Add(this.labelPeriod);
            this.panel1.Controls.Add(this.labelSpeedWave);
            this.panel1.Controls.Add(this.Answer);
            this.panel1.Controls.Add(this.Resistance);
            this.panel1.Controls.Add(this.Tension);
            this.panel1.Controls.Add(this.WaveLength);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 371);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 713);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 14;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(749, 62);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 309);
            this.vScrollBar1.TabIndex = 13;
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.White;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_fullscreen_close_4417879;
            this.TurnButton.Location = new System.Drawing.Point(730, 0);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 26);
            this.TurnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnButton.TabIndex = 11;
            this.TurnButton.TabStop = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_close15_216468;
            this.CloseButton.Location = new System.Drawing.Point(761, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 26);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 10;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Curent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 371);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Curent";
            this.Text = "Curent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelSpeedWave;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox Resistance;
        private System.Windows.Forms.TextBox Tension;
        private System.Windows.Forms.Label WaveLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem магнетизмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электрическийТокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинематикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электромагнитныеКолебанияToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem электростатикаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox TurnButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.VScrollBar vScrollBar1;
    }
}