namespace RDP
{
    partial class RemoteDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktop));
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.KeyGen = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_fullname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.pic_Profile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Location = new System.Drawing.Point(752, 603);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(602, 603);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtKey
            // 
            this.txtKey.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Location = new System.Drawing.Point(611, 277);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(330, 15);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // KeyGen
            // 
            this.KeyGen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KeyGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.KeyGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyGen.Location = new System.Drawing.Point(89, 277);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.KeyGen.Size = new System.Drawing.Size(330, 15);
            this.KeyGen.TabIndex = 9;
            this.KeyGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyGen.UseWaitCursor = true;
            this.KeyGen.TextChanged += new System.EventHandler(this.KeyGen_TextChanged);
            // 
            // exit
            // 
            this.exit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(901, 814);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 23);
            this.exit.TabIndex = 10;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.btn_KeyGen_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(901, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 13;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_fullname
            // 
            this.txt_fullname.AutoSize = true;
            this.txt_fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_fullname.Location = new System.Drawing.Point(159, 645);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(60, 16);
            this.txt_fullname.TabIndex = 14;
            this.txt_fullname.Text = "fullName";
            // 
            // txt_firstname
            // 
            this.txt_firstname.AutoSize = true;
            this.txt_firstname.Location = new System.Drawing.Point(159, 742);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(64, 16);
            this.txt_firstname.TabIndex = 15;
            this.txt_firstname.Text = "firstName";
            // 
            // txt_lastName
            // 
            this.txt_lastName.AutoSize = true;
            this.txt_lastName.Location = new System.Drawing.Point(329, 742);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(65, 16);
            this.txt_lastName.TabIndex = 16;
            this.txt_lastName.Text = "lastName";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(159, 814);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(40, 16);
            this.txt_email.TabIndex = 17;
            this.txt_email.Text = "email";
            // 
            // pic_Profile
            // 
            this.pic_Profile.Location = new System.Drawing.Point(0, 566);
            this.pic_Profile.Name = "pic_Profile";
            this.pic_Profile.Size = new System.Drawing.Size(120, 120);
            this.pic_Profile.TabIndex = 18;
            this.pic_Profile.TabStop = false;
            this.pic_Profile.Click += new System.EventHandler(this.pic_Profile_Click);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 850);
            this.Controls.Add(this.pic_Profile);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.KeyGen);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.DoubleBuffered = true;
            this.Name = "RemoteDesktop";
            this.Load += new System.EventHandler(this.RemoteDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox KeyGen;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt_fullname;
        private System.Windows.Forms.Label txt_firstname;
        private System.Windows.Forms.Label txt_lastName;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.PictureBox pic_Profile;
    }
}