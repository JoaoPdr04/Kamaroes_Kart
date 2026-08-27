using JogoCorrida;
using JogoCorridaWinFormsApp.Properties;
using System.Drawing.Text;
using System.Resources;
using System.Windows.Forms;

namespace JogoCorridaWinFormsApp
{
    public partial class Pista : Form
    {
        Jogo jogo;
        DateTime temporUltimaMovimentacao = DateTime.Now;
        List<PictureBox> pictureBoxes = [];

        public Pista() //método construtor que vai dar nascimento para o projeto
        {
            InitializeComponent();
            jogo = new Jogo(); //aqui instanciamos o objeto jogo da classe Jogo
            jogo.Faixa1Inicio = 150;
            jogo.Faixa1Fim = 250;
            jogo.Faixa2Inicio = 360;
            jogo.Faixa2Fim = 460;

            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            jogo.Carro.PosicaoY = 590;
            jogo.YMaximo = 800;

            jogo.Velocidade = 50;
            var tempoUltimaMovimentaCarro = DateTime.Now;
            pictureBoxes = new List<PictureBox>();

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

            if (jogo.ChecarColisao())
            {
                timerJogo.Enabled = false;
                MessageBox.Show("Bateu!", "Fim de Jogo");
                Application.Exit();
            }
        }

        private void picCarro_Click(object sender, EventArgs e)
        {

        }
    }
}