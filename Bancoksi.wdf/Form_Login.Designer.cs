namespace Bancoksi.wdf
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            pictureBox1 = new PictureBox();
            linkLabel_Esqueceu_a_senha = new LinkLabel();
            textBox_Utilizador = new TextBox();
            textBox_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Entrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(245, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // linkLabel_Esqueceu_a_senha
            // 
            linkLabel_Esqueceu_a_senha.AutoSize = true;
            linkLabel_Esqueceu_a_senha.LinkColor = Color.Black;
            linkLabel_Esqueceu_a_senha.Location = new Point(12, 426);
            linkLabel_Esqueceu_a_senha.Name = "linkLabel_Esqueceu_a_senha";
            linkLabel_Esqueceu_a_senha.Size = new Size(105, 15);
            linkLabel_Esqueceu_a_senha.TabIndex = 10;
            linkLabel_Esqueceu_a_senha.TabStop = true;
            linkLabel_Esqueceu_a_senha.Text = "Esqueceu a senha?";
            // 
            // textBox_Utilizador
            // 
            textBox_Utilizador.Location = new Point(317, 252);
            textBox_Utilizador.Name = "textBox_Utilizador";
            textBox_Utilizador.Size = new Size(151, 23);
            textBox_Utilizador.TabIndex = 11;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(317, 298);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(151, 23);
            textBox_Password.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 234);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "Utilizador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 280);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // button_Entrar
            // 
            button_Entrar.BackColor = Color.DodgerBlue;
            button_Entrar.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Entrar.ForeColor = SystemColors.ControlLightLight;
            button_Entrar.Location = new Point(311, 327);
            button_Entrar.Name = "button_Entrar";
            button_Entrar.Size = new Size(157, 30);
            button_Entrar.TabIndex = 15;
            button_Entrar.Text = "Entrar";
            button_Entrar.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_Entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Utilizador);
            Controls.Add(linkLabel_Esqueceu_a_senha);
            Controls.Add(pictureBox1);
            Name = "Form_Login";
            Text = "Form_login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel_Esqueceu_a_senha;
        private TextBox textBox_Utilizador;
        private TextBox textBox_Password;
        private Label label1;
        private Label label2;
        private Button button_Entrar;
    }
}