namespace WIPR
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            buttonLogin = new Button();
            buttoncancel = new Button();
            labelLogin = new Label();
            labelUser = new Label();
            labelPass = new Label();
            pictureBox1 = new PictureBox();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Lime;
            buttonLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(403, 267);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(134, 94);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.BackColor = Color.Red;
            buttoncancel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncancel.Location = new Point(604, 267);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(134, 94);
            buttoncancel.TabIndex = 1;
            buttoncancel.Text = "Cancel";
            buttoncancel.UseVisualStyleBackColor = false;
            buttoncancel.Click += buttoncancel_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(474, 19);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(209, 74);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "LOGIN";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(327, 128);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(119, 31);
            labelUser.TabIndex = 3;
            labelUser.Text = "Username";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPass.Location = new Point(327, 177);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(113, 31);
            labelPass.TabIndex = 4;
            labelPass.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(474, 128);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(226, 27);
            textBoxUser.TabIndex = 6;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(474, 181);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(226, 27);
            textBoxPass.TabIndex = 7;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(pictureBox1);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(labelLogin);
            Controls.Add(buttoncancel);
            Controls.Add(buttonLogin);
            Name = "loginform";
            Text = "loginform";
            Load += loginform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttoncancel;
        private Label labelLogin;
        private Label labelUser;
        private Label labelPass;
        private PictureBox pictureBox1;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
    }
}