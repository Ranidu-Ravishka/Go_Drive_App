namespace GoDrive__Guna_
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.butreset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butlogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.butminimizehome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butclosehome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.piclogologin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogologin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 80;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.butreset);
            this.guna2Panel1.Controls.Add(this.butlogin);
            this.guna2Panel1.Controls.Add(this.lblpassword);
            this.guna2Panel1.Controls.Add(this.lblusername);
            this.guna2Panel1.Controls.Add(this.txtpassword);
            this.guna2Panel1.Controls.Add(this.txtusername);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-69, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(629, 802);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // butreset
            // 
            this.butreset.BorderRadius = 15;
            this.butreset.CheckedState.Parent = this.butreset;
            this.butreset.CustomImages.Parent = this.butreset;
            this.butreset.FillColor = System.Drawing.Color.White;
            this.butreset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.butreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreset.ForeColor = System.Drawing.Color.Black;
            this.butreset.HoverState.Parent = this.butreset;
            this.butreset.Location = new System.Drawing.Point(235, 492);
            this.butreset.Name = "butreset";
            this.butreset.ShadowDecoration.Parent = this.butreset;
            this.butreset.Size = new System.Drawing.Size(190, 45);
            this.butreset.TabIndex = 3;
            this.butreset.Text = "Reset";
            this.butreset.UseTransparentBackground = true;
            // 
            // butlogin
            // 
            this.butlogin.BorderRadius = 15;
            this.butlogin.CheckedState.Parent = this.butlogin;
            this.butlogin.CustomImages.Parent = this.butlogin;
            this.butlogin.FillColor = System.Drawing.Color.White;
            this.butlogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.butlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlogin.ForeColor = System.Drawing.Color.Black;
            this.butlogin.HoverState.Parent = this.butlogin;
            this.butlogin.Location = new System.Drawing.Point(235, 430);
            this.butlogin.Name = "butlogin";
            this.butlogin.ShadowDecoration.Parent = this.butlogin;
            this.butlogin.Size = new System.Drawing.Size(190, 45);
            this.butlogin.TabIndex = 3;
            this.butlogin.Text = "Login";
            this.butlogin.UseTransparentBackground = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpassword.Location = new System.Drawing.Point(167, 330);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(86, 20);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusername.Location = new System.Drawing.Point(167, 254);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(91, 20);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 9;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(167, 353);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(330, 36);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.BorderRadius = 9;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(167, 277);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(330, 36);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.butminimizehome);
            this.guna2ShadowPanel1.Controls.Add(this.butclosehome);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1130, -1);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(70, 44);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // butminimizehome
            // 
            this.butminimizehome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butminimizehome.BackgroundImage")));
            this.butminimizehome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butminimizehome.CheckedState.Parent = this.butminimizehome;
            this.butminimizehome.CustomImages.Parent = this.butminimizehome;
            this.butminimizehome.FillColor = System.Drawing.Color.Transparent;
            this.butminimizehome.FillColor2 = System.Drawing.Color.Transparent;
            this.butminimizehome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butminimizehome.ForeColor = System.Drawing.Color.White;
            this.butminimizehome.HoverState.Parent = this.butminimizehome;
            this.butminimizehome.Location = new System.Drawing.Point(11, 13);
            this.butminimizehome.Name = "butminimizehome";
            this.butminimizehome.ShadowDecoration.Parent = this.butminimizehome;
            this.butminimizehome.Size = new System.Drawing.Size(20, 20);
            this.butminimizehome.TabIndex = 4;
            this.butminimizehome.Click += new System.EventHandler(this.butminimizehome_Click);
            // 
            // butclosehome
            // 
            this.butclosehome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butclosehome.BackgroundImage")));
            this.butclosehome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butclosehome.CheckedState.Parent = this.butclosehome;
            this.butclosehome.CustomImages.Parent = this.butclosehome;
            this.butclosehome.FillColor = System.Drawing.Color.Transparent;
            this.butclosehome.FillColor2 = System.Drawing.Color.Transparent;
            this.butclosehome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butclosehome.ForeColor = System.Drawing.Color.White;
            this.butclosehome.HoverState.Parent = this.butclosehome;
            this.butclosehome.Location = new System.Drawing.Point(37, 13);
            this.butclosehome.Name = "butclosehome";
            this.butclosehome.ShadowDecoration.Parent = this.butclosehome;
            this.butclosehome.Size = new System.Drawing.Size(20, 20);
            this.butclosehome.TabIndex = 4;
            this.butclosehome.Click += new System.EventHandler(this.butclosehome_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BackgroundImage = global::GoDrive__Guna_.Properties.Resources.Eye;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GradientButton1.BorderRadius = 9;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.Location = new System.Drawing.Point(461, 353);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(36, 36);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // piclogologin
            // 
            this.piclogologin.Image = ((System.Drawing.Image)(resources.GetObject("piclogologin.Image")));
            this.piclogologin.Location = new System.Drawing.Point(601, 155);
            this.piclogologin.Name = "piclogologin";
            this.piclogologin.ShadowDecoration.Parent = this.piclogologin;
            this.piclogologin.Size = new System.Drawing.Size(536, 483);
            this.piclogologin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogologin.TabIndex = 1;
            this.piclogologin.TabStop = false;
            this.piclogologin.Click += new System.EventHandler(this.piclogologin_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.piclogologin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogologin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox piclogologin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2GradientButton butlogin;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2GradientButton butreset;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton butclosehome;
        private Guna.UI2.WinForms.Guna2GradientButton butminimizehome;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}

