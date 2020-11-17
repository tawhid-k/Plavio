namespace SchedulingWizard.frames
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerpnl = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cpass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.id2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.id = new System.Windows.Forms.Label();
            this.pass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.uname2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.uname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registerpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Login or signup before schedule";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::SchedulingWizard.Properties.Resources.icons8_close_window_50px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(43, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(310, 53);
            this.button5.TabIndex = 19;
            this.button5.Text = "      Close Window";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.close);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SchedulingWizard.Properties.Resources.icons8_minimize_window_50px_1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(43, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "      Minimize page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.minimizePage);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::SchedulingWizard.Properties.Resources.icons8_previous_50px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(43, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "        Previous page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.prevPage);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SchedulingWizard.Properties.Resources.icons8_settings_200px;
            this.pictureBox3.Location = new System.Drawing.Point(93, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchedulingWizard.Properties.Resources.texture_surface_dark_128260_2160x3840;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 563);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // registerpnl
            // 
            this.registerpnl.Controls.Add(this.button7);
            this.registerpnl.Controls.Add(this.button6);
            this.registerpnl.Controls.Add(this.cpass2);
            this.registerpnl.Controls.Add(this.label8);
            this.registerpnl.Controls.Add(this.email);
            this.registerpnl.Controls.Add(this.label7);
            this.registerpnl.Controls.Add(this.id2);
            this.registerpnl.Controls.Add(this.id);
            this.registerpnl.Controls.Add(this.pass2);
            this.registerpnl.Controls.Add(this.uname2);
            this.registerpnl.Controls.Add(this.label5);
            this.registerpnl.Controls.Add(this.label6);
            this.registerpnl.Location = new System.Drawing.Point(786, -5);
            this.registerpnl.Name = "registerpnl";
            this.registerpnl.Size = new System.Drawing.Size(406, 563);
            this.registerpnl.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(288, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 32);
            this.button7.TabIndex = 23;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.cencelRegistration);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(185, 509);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 32);
            this.button6.TabIndex = 22;
            this.button6.Text = "Register";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.register);
            // 
            // cpass2
            // 
            this.cpass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cpass2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpass2.ForeColor = System.Drawing.Color.White;
            this.cpass2.HintForeColor = System.Drawing.Color.White;
            this.cpass2.HintText = "";
            this.cpass2.isPassword = true;
            this.cpass2.LineFocusedColor = System.Drawing.Color.White;
            this.cpass2.LineIdleColor = System.Drawing.Color.White;
            this.cpass2.LineMouseHoverColor = System.Drawing.Color.White;
            this.cpass2.LineThickness = 3;
            this.cpass2.Location = new System.Drawing.Point(11, 443);
            this.cpass2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cpass2.Name = "cpass2";
            this.cpass2.Size = new System.Drawing.Size(374, 40);
            this.cpass2.TabIndex = 21;
            this.cpass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cpass2.OnValueChanged += new System.EventHandler(this.crp2Cgange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "Confirm Password";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HintForeColor = System.Drawing.Color.White;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.White;
            this.email.LineIdleColor = System.Drawing.Color.White;
            this.email.LineMouseHoverColor = System.Drawing.Color.White;
            this.email.LineThickness = 4;
            this.email.Location = new System.Drawing.Point(11, 245);
            this.email.Margin = new System.Windows.Forms.Padding(6);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(374, 40);
            this.email.TabIndex = 19;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // id2
            // 
            this.id2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id2.ForeColor = System.Drawing.Color.White;
            this.id2.HintForeColor = System.Drawing.Color.White;
            this.id2.HintText = "";
            this.id2.isPassword = false;
            this.id2.LineFocusedColor = System.Drawing.Color.White;
            this.id2.LineIdleColor = System.Drawing.Color.White;
            this.id2.LineMouseHoverColor = System.Drawing.Color.White;
            this.id2.LineThickness = 4;
            this.id2.Location = new System.Drawing.Point(11, 151);
            this.id2.Margin = new System.Windows.Forms.Padding(6);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(374, 40);
            this.id2.TabIndex = 17;
            this.id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(6, 115);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 30);
            this.id.TabIndex = 16;
            this.id.Text = "ID";
            // 
            // pass2
            // 
            this.pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass2.ForeColor = System.Drawing.Color.White;
            this.pass2.HintForeColor = System.Drawing.Color.White;
            this.pass2.HintText = "";
            this.pass2.isPassword = true;
            this.pass2.LineFocusedColor = System.Drawing.Color.White;
            this.pass2.LineIdleColor = System.Drawing.Color.White;
            this.pass2.LineMouseHoverColor = System.Drawing.Color.White;
            this.pass2.LineThickness = 3;
            this.pass2.Location = new System.Drawing.Point(11, 348);
            this.pass2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(374, 40);
            this.pass2.TabIndex = 15;
            this.pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass2.OnValueChanged += new System.EventHandler(this.rPchange);
            // 
            // uname2
            // 
            this.uname2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname2.ForeColor = System.Drawing.Color.White;
            this.uname2.HintForeColor = System.Drawing.Color.White;
            this.uname2.HintText = "";
            this.uname2.isPassword = false;
            this.uname2.LineFocusedColor = System.Drawing.Color.White;
            this.uname2.LineIdleColor = System.Drawing.Color.White;
            this.uname2.LineMouseHoverColor = System.Drawing.Color.White;
            this.uname2.LineThickness = 4;
            this.uname2.Location = new System.Drawing.Point(11, 60);
            this.uname2.Margin = new System.Windows.Forms.Padding(6);
            this.uname2.Name = "uname2";
            this.uname2.Size = new System.Drawing.Size(374, 40);
            this.uname2.TabIndex = 14;
            this.uname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.startSliding);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(387, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(374, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.tryLogin);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(387, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(374, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create a new account";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.createAccount);
            // 
            // uname
            // 
            this.uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.Color.White;
            this.uname.HintForeColor = System.Drawing.Color.DimGray;
            this.uname.HintText = "AIUB";
            this.uname.isPassword = false;
            this.uname.LineFocusedColor = System.Drawing.Color.White;
            this.uname.LineIdleColor = System.Drawing.Color.White;
            this.uname.LineMouseHoverColor = System.Drawing.Color.White;
            this.uname.LineThickness = 4;
            this.uname.Location = new System.Drawing.Point(387, 246);
            this.uname.Margin = new System.Windows.Forms.Padding(6);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(374, 40);
            this.uname.TabIndex = 10;
            this.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass
            // 
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.HintForeColor = System.Drawing.Color.DimGray;
            this.pass.HintText = "password";
            this.pass.isPassword = true;
            this.pass.LineFocusedColor = System.Drawing.Color.White;
            this.pass.LineIdleColor = System.Drawing.Color.White;
            this.pass.LineMouseHoverColor = System.Drawing.Color.White;
            this.pass.LineThickness = 3;
            this.pass.Location = new System.Drawing.Point(387, 331);
            this.pass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(374, 40);
            this.pass.TabIndex = 11;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.OnValueChanged += new System.EventHandler(this.setPass);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Login";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.showLoginOptionAgain);
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(789, 559);
            this.Controls.Add(this.registerpnl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registerpnl.ResumeLayout(false);
            this.registerpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel registerpnl;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cpass2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id2;
        private System.Windows.Forms.Label id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uname2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button7;
    }
}