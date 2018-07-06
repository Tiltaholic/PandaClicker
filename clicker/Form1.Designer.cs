namespace clicker
{
    partial class PandaClicker
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
            this.components = new System.ComponentModel.Container();
            this.rightClick = new System.Windows.Forms.Timer(this.components);
            this.leftClick = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.leftCpsMin = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.leftCpsMax = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rightCpsMax = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.rightCpsMin = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // rightClick
            // 
            this.rightClick.Tick += new System.EventHandler(this.rightClick_Tick);
            // 
            // leftClick
            // 
            this.leftClick.Tick += new System.EventHandler(this.leftClick_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(71, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CPS Min";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // leftCpsMin
            // 
            this.leftCpsMin.BackColor = System.Drawing.Color.Transparent;
            this.leftCpsMin.Location = new System.Drawing.Point(136, 118);
            this.leftCpsMin.Maximum = 45;
            this.leftCpsMin.Name = "leftCpsMin";
            this.leftCpsMin.Size = new System.Drawing.Size(75, 23);
            this.leftCpsMin.TabIndex = 2;
            this.leftCpsMin.Text = "leftCpsMin";
            this.leftCpsMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.leftCpsMin.Value = 11;
            this.leftCpsMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.leftCpsMin_Scroll);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(71, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "CPS Max";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // leftCpsMax
            // 
            this.leftCpsMax.BackColor = System.Drawing.Color.Transparent;
            this.leftCpsMax.Location = new System.Drawing.Point(136, 148);
            this.leftCpsMax.Maximum = 45;
            this.leftCpsMax.Name = "leftCpsMax";
            this.leftCpsMax.Size = new System.Drawing.Size(75, 23);
            this.leftCpsMax.TabIndex = 4;
            this.leftCpsMax.Text = "leftCpsMax";
            this.leftCpsMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.leftCpsMax.Value = 15;
            this.leftCpsMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.leftCpsMax_Scroll);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(99, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Left Click";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(387, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Right Click";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rightCpsMax
            // 
            this.rightCpsMax.BackColor = System.Drawing.Color.Transparent;
            this.rightCpsMax.Location = new System.Drawing.Point(423, 148);
            this.rightCpsMax.Name = "rightCpsMax";
            this.rightCpsMax.Size = new System.Drawing.Size(75, 23);
            this.rightCpsMax.TabIndex = 9;
            this.rightCpsMax.Text = "leftCpsMax";
            this.rightCpsMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rightCpsMax.Value = 55;
            this.rightCpsMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rightCpsMax_Scroll);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(358, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "CPS Max";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rightCpsMin
            // 
            this.rightCpsMin.BackColor = System.Drawing.Color.Transparent;
            this.rightCpsMin.Location = new System.Drawing.Point(423, 118);
            this.rightCpsMin.Name = "rightCpsMin";
            this.rightCpsMin.Size = new System.Drawing.Size(75, 23);
            this.rightCpsMin.TabIndex = 7;
            this.rightCpsMin.Text = "riCpsMin";
            this.rightCpsMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rightCpsMin.Value = 45;
            this.rightCpsMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rightCpsMin_Scroll);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(358, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "CPS Min";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(217, 122);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(19, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "11";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(217, 148);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(21, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "15";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.White;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(504, 122);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(23, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "45";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(504, 148);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(23, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "55";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PandaClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 220);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.rightCpsMax);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.rightCpsMin);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.leftCpsMax);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.leftCpsMin);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "PandaClicker";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "PandaClicker";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer rightClick;
        private System.Windows.Forms.Timer leftClick;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar leftCpsMin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTrackBar leftCpsMax;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar rightCpsMax;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTrackBar rightCpsMin;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}

