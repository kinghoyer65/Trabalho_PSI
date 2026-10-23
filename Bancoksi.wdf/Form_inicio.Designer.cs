namespace Bancoksi.wdf
{
    partial class Form_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            button_login = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel_registrar = new LinkLabel();
            pictureBox1 = new PictureBox();
            button_Sair1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.BackColor = Color.RoyalBlue;
            button_login.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_login.ForeColor = SystemColors.ControlLightLight;
            button_login.Location = new Point(324, 250);
            button_login.Name = "button_login";
            button_login.Size = new Size(157, 30);
            button_login.TabIndex = 1;
            button_login.Text = "login";
            button_login.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(373, 126);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(12, 417);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 6;
            // 
            // linkLabel_registrar
            // 
            linkLabel_registrar.AutoSize = true;
            linkLabel_registrar.LinkColor = Color.Black;
            linkLabel_registrar.Location = new Point(373, 300);
            linkLabel_registrar.Name = "linkLabel_registrar";
            linkLabel_registrar.Size = new Size(50, 15);
            linkLabel_registrar.TabIndex = 7;
            linkLabel_registrar.TabStop = true;
            linkLabel_registrar.Text = "registrar";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(204, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button_Sair1
            // 
            button_Sair1.BackColor = Color.Red;
            button_Sair1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_Sair1.ForeColor = SystemColors.ControlText;
            button_Sair1.Location = new Point(18, 409);
            button_Sair1.Name = "button_Sair1";
            button_Sair1.Size = new Size(57, 30);
            button_Sair1.TabIndex = 9;
            button_Sair1.Text = "Sair";
            button_Sair1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_Sair1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel_registrar);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(button_login);
            Name = "Form1";
            Text = "Form_inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_login;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel_registrar;
        private PictureBox pictureBox1;
        private Button button_Sair1;
    }
}
