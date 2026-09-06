using JogoCorrida;
using JogoCorridaWinFormsApp.Properties;
using System.Drawing.Text;
using System.Media;
using System.Resources;
using System.Windows.Forms;

namespace JogoCorridaWinFormsApp
{
    public partial class Pista : Form
    {
        Jogo jogo;
        DateTime temporUltimaMovimentacao = DateTime.Now;
        List<PictureBox> pictureBoxes = [];
        List<PictureBox> pictureBoxesMD = [];


        public Pista(string Nível) //método construtor que vai dar nascimento para o projeto
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.BackgroundImage = Properties.Resources.Fase1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            TocarSomCorrida();

            jogo = new Jogo(); //aqui instanciamos o objeto jogo da classe Jogo
            jogo.Faixa1Inicio = 150;
            jogo.Faixa1Fim = 310;
            jogo.Faixa2Inicio = 380;
            jogo.Faixa2Fim = 490;

            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            jogo.Carro.PosicaoY = 590;
            jogo.YMaximo = 800;
            jogo.ColisoesPermitidas = 3;
            jogo.PontosFinais = 0;

            if (Nível == "Fácil")
            {
                jogo.Velocidade = 300;
            }
            else if (Nível == "Médio")
            {
                jogo.Velocidade = 150;
            }
            else if (Nível == "Difícil")
                jogo.Velocidade = 50;

            var tempoUltimaMovimentaCarro = DateTime.Now;
            pictureBoxes = new List<PictureBox>();
            pictureBoxesMD = new List<PictureBox>();

            foreach (var obj in jogo.Obstaculos)
            {
                var picOb = new PictureBox();
                picOb.BackColor = Color.Transparent;
                picOb.SizeMode = PictureBoxSizeMode.StretchImage;
                picOb.Size = new Size(50, 100);
                picOb.Image = Properties.Resources.fotoObjeto;
                pictureBoxes.Add(picOb);
                this.Controls.Add(picOb);
            }
            timerJogo.Enabled = true;
            lblMoedas.Text = "Moedas: 0";
            lblPontuacao.Text = "Pontuação: " + jogo.Pontuacao;

            foreach (var med in jogo.Moedas)
            {
                var picMd = new PictureBox();
                picMd.BackColor = Color.Transparent;
                picMd.SizeMode = PictureBoxSizeMode.StretchImage;
                picMd.Size = new Size(80, 100);
                picMd.Image = fotoMoeda.Image;
                pictureBoxesMD.Add(picMd);
                this.Controls.Add(picMd);
            }
        }


        private void Pista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            }
            if (e.KeyCode == Keys.Right)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(2);
            }
        }

        private async void timerJogo_Tick(object sender, EventArgs e)
        {
            picCarro.Location = new Point(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY);
            lblPontuacao.Text = "Pontuação: " + jogo.Pontuacao;

            jogo.Pontuacao++;

            if ((DateTime.Now - temporUltimaMovimentacao).Milliseconds >= jogo.Velocidade)
            {
                temporUltimaMovimentacao = DateTime.Now;
                jogo.MovimentaObstaculos();
            }

            for (int i = 0; i < jogo.Obstaculos.Count; i++)
            {
                var ob = jogo.Obstaculos[i];
                pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                if (ob.TipoImagem == 1 && pictureBoxes[i].Tag?.ToString() != "1")
                {
                    pictureBoxes[i].Image = Properties.Resources.fotoObjeto;
                    pictureBoxes[i].Tag = "1";
                    pictureBoxes[i].Size = new Size(80, 100);
                }
                else if (ob.TipoImagem == 2 && pictureBoxes[i].Tag?.ToString() != "2")
                {
                    pictureBoxes[i].Image = Properties.Resources.picChick;
                    pictureBoxes[i].Tag = "2";
                    pictureBoxes[i].Size = new Size(76, 95);
                }
            }

            for (int i = 0; i < jogo.Moedas.Count; i++)
            {
                var md = jogo.Moedas[i];
                pictureBoxesMD[i].Location = new Point(md.PosicaoX, md.PosicaoY);
            }

            if (jogo.ChecarColisao())
            {
                timerJogo.Enabled = false;
                var imagemDoCarro = picCarro.Image;
                picCarro.Image = Properties.Resources.explosao;
                await Task.Delay(250);
                picCarro.Image = imagemDoCarro;
                TocarSomBatida();
                jogo.ColisoesPermitidas -= 1;

                if (jogo.VerificaFimJogo())
                {
                    jogo.PontosFinais = jogo.Pontuacao + (jogo.MoedasColetadas * 10);
                    MessageBox.Show("Fim de Jogo!\n" +
                        "Moedas coletadas: " + jogo.MoedasColetadas.ToString() + " = " + jogo.MoedasColetadas * 10 + " pontos\n" +
                        "Pontuação final: " + jogo.PontosFinais.ToString() + " pontos");

                    Application.Restart();
                }
                else timerJogo.Enabled = true;
            }

            if (jogo.ChecarMoeda())
            {
                jogo.MoedasColetadas += 1;
                lblMoedas.Text = "Moedas: " + jogo.MoedasColetadas.ToString();
            }

            if (jogo.Pontuacao >= 300)
            {
                this.BackgroundImage = Properties.Resources.Fase2FimDeTarde;
//                jogo.Velocidade += 50;
            }

            if (jogo.Pontuacao >= 750)
            {
                this.BackgroundImage = Properties.Resources.Fase3Noite;
  //              jogo.Velocidade += 100;
            }
        }

        private void TocarSomCorrida()
        {
            SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = "D:\\joao\\jogo\\somBatida.wav";
            //sp.Play();
        }

        private void TocarSomBatida()
        {
            SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = "D:\\joao\\jogo\\somBatida.wav";
            //sp.Play();
            Thread.Sleep(1000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fotoMoeda_Click(object sender, EventArgs e)
        {

        }

        //        private void btnReiniciar_Click(object sender, EventArgs e)
        //       {
       //             this.Focus();

        //            Application.Restart();
        //        }
    }
}