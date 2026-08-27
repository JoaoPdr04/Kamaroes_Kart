namespace JogoCorridaWinFormsApp
{
    partial class Pista
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pista));
            pictureBox1 = new PictureBox();
            picCarro = new PictureBox();
            fotoObjeto = new PictureBox();
            timerJogo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoObjeto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picCarro
            // 
            picCarro.BackColor = Color.Transparent;
            picCarro.BackgroundImageLayout = ImageLayout.None;
            picCarro.Image = (Image)resources.GetObject("picCarro.Image");
            picCarro.Location = new Point(196, 568);
            picCarro.Name = "picCarro";
            picCarro.Size = new Size(140, 162);
            picCarro.SizeMode = PictureBoxSizeMode.StretchImage;
            picCarro.TabIndex = 1;
            picCarro.TabStop = false;
            picCarro.Click += picCarro_Click;
            // 
            // fotoObjeto
            // 
            fotoObjeto.BackColor = Color.Transparent;
            fotoObjeto.Image = (Image)resources.GetObject("fotoObjeto.Image");
            fotoObjeto.Location = new Point(29, 12);
            fotoObjeto.Name = "fotoObjeto";
            fotoObjeto.Size = new Size(67, 78);
            fotoObjeto.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoObjeto.TabIndex = 2;
            fotoObjeto.TabStop = false;
            // 
            // timerJogo
            // 
            timerJogo.Tick += timerJogo_Tick;
            // 
            // Pista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 742);
            Controls.Add(fotoObjeto);
            Controls.Add(picCarro);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pista";
            KeyDown += Pista_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoObjeto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picCarro;
        private PictureBox fotoObjeto;
        private System.Windows.Forms.Timer timerJogo;
    }
}
