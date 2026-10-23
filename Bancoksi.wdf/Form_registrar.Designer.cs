namespace Bancoksi.wdf
{
    partial class Form_registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_registrar));
            pictureBox1 = new PictureBox();
            button_Criar_Utilizador = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_Escolher_Password = new TextBox();
            textBox_Nome_do_Utilizador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(269, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button_Criar_Utilizador
            // 
            button_Criar_Utilizador.BackColor = Color.DodgerBlue;
            button_Criar_Utilizador.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Criar_Utilizador.ForeColor = SystemColors.ControlLightLight;
            button_Criar_Utilizador.Location = new Point(322, 306);
            button_Criar_Utilizador.Name = "button_Criar_Utilizador";
            button_Criar_Utilizador.Size = new Size(157, 30);
            button_Criar_Utilizador.TabIndex = 20;
            button_Criar_Utilizador.Text = "Criar Utilizador";
            button_Criar_Utilizador.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 259);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 19;
            label2.Text = "Escolhe uma Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 213);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 18;
            label1.Text = "Nome de Utilizador";
            // 
            // textBox_Escolher_Password
            // 
            textBox_Escolher_Password.Location = new Point(322, 277);
            textBox_Escolher_Password.Name = "textBox_Escolher_Password";
            textBox_Escolher_Password.Size = new Size(151, 23);
            textBox_Escolher_Password.TabIndex = 17;
            // 
            // textBox_Nome_do_Utilizador
            // 
            textBox_Nome_do_Utilizador.Location = new Point(322, 231);
            textBox_Nome_do_Utilizador.Name = "textBox_Nome_do_Utilizador";
            textBox_Nome_do_Utilizador.Size = new Size(151, 23);
            textBox_Nome_do_Utilizador.TabIndex = 16;
            // 
            // Form_registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_Criar_Utilizador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Escolher_Password);
            Controls.Add(textBox_Nome_do_Utilizador);
            Controls.Add(pictureBox1);
            Name = "Form_registrar";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_Criar_Utilizador;
        private Label label2;
        private Label label1;
        private TextBox textBox_Escolher_Password;
        private TextBox textBox_Nome_do_Utilizador;
    }
}