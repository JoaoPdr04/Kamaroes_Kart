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
            TocarSomCorrida();

            jogo = new Jogo(); //aqui instanciamos o objeto jogo da classe Jogo
            jogo.Faixa1Inicio = 150;
            jogo.Faixa1Fim = 250;
            jogo.Faixa2Inicio = 360;
            jogo.Faixa2Fim = 460;

            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            jogo.Carro.PosicaoY = 590;
            jogo.YMaximo = 800;

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
                picOb.Image = fotoObjeto.Image; 
                pictureBoxes.Add(picOb);
                this.Controls.Add(picOb);
            }
            timerJogo.Enabled = true;


            foreach (var med in jogo.Moedas)
            {
                var picMd = new PictureBox();
                picMd.BackColor = Color.Transparent;
                picMd.SizeMode = PictureBoxSizeMode.StretchImage;
                picMd.Size = new Size(50, 100);
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

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            picCarro.Location = new Point(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY);

            if ((DateTime.Now - temporUltimaMovimentacao).Milliseconds >= jogo.Velocidade)
            {
                temporUltimaMovimentacao = DateTime.Now;
                jogo.MovimentaObstaculos();
            }

            for (int i = 0; i < jogo.Obstaculos.Count; i++)
            {
                var ob = jogo.Obstaculos[i];

                if (ob.PosicaoY >= -150)
                {
                    pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                }
            }

            for (int i = 0; i < jogo.Moedas.Count; i++)
            {
                var md = jogo.Obstaculos[i];

                if (md.PosicaoY >= -50)
                {
                    pictureBoxesMD[i].Location = new Point(md.PosicaoX, md.PosicaoY);
                }
            }

            if (jogo.ChecarColisao())
            {
                timerJogo.Enabled = false;
                TocarSomBatida();
                MessageBox.Show("Bateu!", "Fim de Jogo");
                Application.Restart();
            }
        }

        private void TocarSomCorrida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\joao\\jogo\\somBatida.wav";
            sp.PlayLooping();
        }

        private void TocarSomBatida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\joao\\jogo\\somBatida.wav";
            sp.Play();
            Thread.Sleep(1000);
        }
    }
}