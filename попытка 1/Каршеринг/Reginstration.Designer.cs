
namespace Каршеринг
{
    partial class Reginstration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reginstration));
            this.buttonReg = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.prava = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Label();
            this.Last_name = new System.Windows.Forms.TextBox();
            this.NameUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.Black;
            this.buttonReg.Location = new System.Drawing.Point(128, 320);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(371, 60);
            this.buttonReg.TabIndex = 6;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(369, 251);
            this.password.Name = "password";
            this.password.PasswordChar = '0';
            this.password.Size = new System.Drawing.Size(232, 34);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // LoginName
            // 
            this.LoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginName.Location = new System.Drawing.Point(72, 251);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(232, 34);
            this.LoginName.TabIndex = 4;
            this.LoginName.Enter += new System.EventHandler(this.LoginName_Enter);
            this.LoginName.Leave += new System.EventHandler(this.LoginName_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prava);
            this.panel1.Controls.Add(this.Registration);
            this.panel1.Controls.Add(this.Last_name);
            this.panel1.Controls.Add(this.NameUser);
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.LoginName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 450);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Водительские права";
            // 
            // prava
            // 
            this.prava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prava.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prava.Location = new System.Drawing.Point(254, 174);
            this.prava.MaxLength = 10;
            this.prava.Name = "prava";
            this.prava.Size = new System.Drawing.Size(192, 34);
            this.prava.TabIndex = 10;
            this.prava.Enter += new System.EventHandler(this.prava_Enter);
            this.prava.Leave += new System.EventHandler(this.prava_Leave);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(286, 403);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(61, 20);
            this.Registration.TabIndex = 9;
            this.Registration.Text = "Войти";
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Last_name
            // 
            this.Last_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Last_name.Location = new System.Drawing.Point(105, 106);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(232, 34);
            this.Last_name.TabIndex = 8;
            this.Last_name.Enter += new System.EventHandler(this.Last_name_Enter);
            this.Last_name.Leave += new System.EventHandler(this.Last_name_Leave);
            // 
            // NameUser
            // 
            this.NameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUser.Location = new System.Drawing.Point(369, 106);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(232, 34);
            this.NameUser.TabIndex = 7;
            this.NameUser.Enter += new System.EventHandler(this.Name_Enter);
            this.NameUser.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 100);
            this.panel2.TabIndex = 0;
            // 
            // buttom
            // 
            this.buttom.AutoSize = true;
            this.buttom.BackColor = System.Drawing.Color.White;
            this.buttom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttom.Location = new System.Drawing.Point(625, 0);
            this.buttom.Name = "buttom";
            this.buttom.Size = new System.Drawing.Size(29, 32);
            this.buttom.TabIndex = 2;
            this.buttom.Text = "x";
            this.buttom.Click += new System.EventHandler(this.buttom_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reginstration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reginstration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reginstration";
            this.Load += new System.EventHandler(this.Reginstration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Last_name;
        private System.Windows.Forms.TextBox NameUser;
        private System.Windows.Forms.Label buttom;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.TextBox prava;
        private System.Windows.Forms.Label label2;
    }
}