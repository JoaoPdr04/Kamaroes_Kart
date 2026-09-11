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
            lblTempo = new Label();
            lblVida = new Label();
            lblFase = new Label();
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
            fotoMoeda.Location = new Point(12, 112);
            fotoMoeda.Name = "fotoMoeda";
            fotoMoeda.Size = new Size(41, 46);
            fotoMoeda.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoMoeda.TabIndex = 3;
            fotoMoeda.TabStop = false;
            // 
            // lblMoedas
            // 
            lblMoedas.AutoSize = true;
            lblMoedas.BackColor = Color.FromArgb(255, 255, 128);
            lblMoedas.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoedas.Location = new Point(12, 161);
            lblMoedas.Name = "lblMoedas";
            lblMoedas.Size = new Size(67, 14);
            lblMoedas.TabIndex = 4;
            lblMoedas.Text = "Moedas: 0";
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.BackColor = SystemColors.ButtonHighlight;
            lblPontuacao.Font = new Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPontuacao.Location = new Point(12, 52);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(82, 13);
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
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = SystemColors.ActiveCaption;
            lblTempo.Font = new Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempo.Location = new Point(12, 83);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(56, 13);
            lblTempo.TabIndex = 7;
            lblTempo.Text = "Tempo: 0";
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.BackColor = Color.FromArgb(255, 128, 128);
            lblVida.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVida.Location = new Point(639, 117);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(55, 14);
            lblVida.TabIndex = 8;
            lblVida.Text = "Vidas: 3";
            // 
            // lblFase
            // 
            lblFase.AutoSize = true;
            lblFase.BackColor = Color.FromArgb(224, 224, 224);
            lblFase.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFase.Location = new Point(333, 31);
            lblFase.Name = "lblFase";
            lblFase.Size = new Size(78, 25);
            lblFase.TabIndex = 9;
            lblFase.Text = "Fase 1";
            // 
            // Pista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 742);
            Controls.Add(lblFase);
            Controls.Add(lblVida);
            Controls.Add(lblTempo);
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
        private Label lblTempo;
        private Label lblVida;
        private Label lblFase;
    }
}
