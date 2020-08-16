namespace WindowsFormsApplication1
{
    partial class ProjectFrorm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электромагнитныеКолебанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинематикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электрическийТокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магнетизмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.электростатикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.TurnButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.TurnButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 344);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 46);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочник расчета формул по физике";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
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
            this.ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_App_Services_copy_Amazon_SNS_Topic_259245;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ToolStripMenuItem.Text = "Тема";
            // 
            // электромагнитныеКолебанияToolStripMenuItem
            // 
            this.электромагнитныеКолебанияToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._007___Oscillation_512;
            this.электромагнитныеКолебанияToolStripMenuItem.Name = "электромагнитныеКолебанияToolStripMenuItem";
            this.электромагнитныеКолебанияToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.электромагнитныеКолебанияToolStripMenuItem.Text = "Электромагнитные колебания";
            this.электромагнитныеКолебанияToolStripMenuItem.Click += new System.EventHandler(this.электромагнитныеКолебанияToolStripMenuItem_Click);
            // 
            // кинематикаToolStripMenuItem
            // 
            this.кинематикаToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.depositphotos_309732072_stock_illustration_classical_physics_blue_violet_flat;
            this.кинематикаToolStripMenuItem.Name = "кинематикаToolStripMenuItem";
            this.кинематикаToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.кинематикаToolStripMenuItem.Text = "Кинематика";
            this.кинематикаToolStripMenuItem.Click += new System.EventHandler(this.кинематикаToolStripMenuItem_Click);
            // 
            // электрическийТокToolStripMenuItem
            // 
            this.электрическийТокToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources._22_512;
            this.электрическийТокToolStripMenuItem.Name = "электрическийТокToolStripMenuItem";
            this.электрическийТокToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.электрическийТокToolStripMenuItem.Text = "Электрический ток";
            this.электрическийТокToolStripMenuItem.Click += new System.EventHandler(this.электрическийТокToolStripMenuItem_Click);
            // 
            // магнетизмToolStripMenuItem
            // 
            this.магнетизмToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_engage_2199100;
            this.магнетизмToolStripMenuItem.Name = "магнетизмToolStripMenuItem";
            this.магнетизмToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.магнетизмToolStripMenuItem.Text = "Магнетизм";
            this.магнетизмToolStripMenuItem.Click += new System.EventHandler(this.магнетизмToolStripMenuItem_Click);
            // 
            // электростатикаToolStripMenuItem
            // 
            this.электростатикаToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_Current_flow_electric_current_electric_wave_electrical_current_electricity_4753029;
            this.электростатикаToolStripMenuItem.Name = "электростатикаToolStripMenuItem";
            this.электростатикаToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.электростатикаToolStripMenuItem.Text = "Электростатика";
            this.электростатикаToolStripMenuItem.Click += new System.EventHandler(this.электростатикаToolStripMenuItem_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_close15_216468;
            this.CloseButton.Location = new System.Drawing.Point(607, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 26);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.White;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.Image = global::WindowsFormsApplication1.Properties.Resources.iconfinder_fullscreen_close_4417879;
            this.TurnButton.Location = new System.Drawing.Point(576, 0);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 26);
            this.TurnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnButton.TabIndex = 3;
            this.TurnButton.TabStop = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // ProjectFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectFrorm";
            this.Text = "ProjectFrorm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnButton)).EndInit();
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
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox TurnButton;
    }
}