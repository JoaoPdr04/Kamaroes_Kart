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
            timerJogo = new System.Windows.Forms.Timer(components);
            fotoMoeda = new PictureBox();
            lblMoedas = new Label();
            lblPontuacao = new Label();
            btnReiniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoMoeda).BeginInit();
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
            picCarro.Location = new Point(228, 635);
            picCarro.Name = "picCarro";
            picCarro.Size = new Size(76, 95);
            picCarro.SizeMode = PictureBoxSizeMode.StretchImage;
            picCarro.TabIndex = 1;
            picCarro.TabStop = false;
            // 
            // timerJogo
            // 
            timerJogo.Tick += timerJogo_Tick;
            // 
            // fotoMoeda
            // 
            fotoMoeda.BackColor = Color.Transparent;
            fotoMoeda.Image = (Image)resources.GetObject("fotoMoeda.Image");
            fotoMoeda.Location = new Point(29, 61);
            fotoMoeda.Name = "fotoMoeda";
            fotoMoeda.Size = new Size(72, 87);
            fotoMoeda.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoMoeda.TabIndex = 3;
            fotoMoeda.TabStop = false;
            fotoMoeda.Click += fotoMoeda_Click;
            // 
            // lblMoedas
            // 
            lblMoedas.AutoSize = true;
            lblMoedas.BackColor = Color.FromArgb(255, 255, 128);
            lblMoedas.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoedas.Location = new Point(12, 161);
            lblMoedas.Name = "lblMoedas";
            lblMoedas.Size = new Size(79, 17);
            lblMoedas.TabIndex = 4;
            lblMoedas.Text = "Moedas: 0";
            lblMoedas.Click += label1_Click;
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.BackColor = SystemColors.ButtonHighlight;
            lblPontuacao.Font = new Font("Snap ITC", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPontuacao.Location = new Point(12, 34);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(89, 15);
            lblPontuacao.TabIndex = 5;
            lblPontuacao.Text = "Pontuação: 0";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(128, 255, 128);
            btnReiniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnReiniciar.Location = new Point(643, 114);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.TabStop = false;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Visible = false;
            // 
            // Pista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 742);
            Controls.Add(btnReiniciar);
            Controls.Add(lblPontuacao);
            Controls.Add(lblMoedas);
            Controls.Add(fotoMoeda);
            Controls.Add(picCarro);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Pista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pista";
            KeyDown += Pista_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoMoeda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picCarro;
        private System.Windows.Forms.Timer timerJogo;
        private PictureBox fotoMoeda;
        private Label lblMoedas;
        private Label lblPontuacao;
        private Button btnReiniciar;
    }
}
