//Murilo gosta que tenha o 'main'

using JogoCorrida;
class Program
{
    static void Main() //static pq ele n se altera por si só
    {

        Jogo jogo = new Jogo();
        jogo.Faixa1Inicio = 2;
        jogo.Faixa1Fim = 12;
        jogo.Faixa2Inicio = 13;
        jogo.Faixa2Fim = 21;

        jogo.IniciaJogo();
        jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
        jogo.Carro.PosicaoY = 12;
        jogo.YMaximo = 10;

        jogo.Velocidade = 150;
        var tempoUltimaMovimentaCarro = DateTime.Now;


        //Thread keyThread = new Thread(ListenerForKeys);
        //Console.WriteLine("Hora de Correr!!!\n");
        //var posicao = "Left";

        for ( ; ; )
        {
            DesenhaCenario();
            DesenhaElemento(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY, '8');

            foreach(var obj in jogo.Obstaculos)
            {
                if (obj.PosicaoY >= 0)
                {
                    DesenhaElemento(obj.PosicaoY, obj.PosicaoX, '0');
                }
            }

            if ((DateTime.Now - tempoUltimaMovimentaCarro).Milliseconds >= jogo.Velocidade)
            {
                tempoUltimaMovimentaCarro = DateTime.Now;
                jogo.MovimentaObstaculos();
            }

            //DesenhaElemento(2, 6, '0');
            //DesenhaElemento(4, 17, '0');
            //DesenhaElemento(10, posicao == "Left" ? 6 : 17, '8');

            if (Console.KeyAvailable)
            {
                var tecla = Console.ReadKey();
                Console.WriteLine(tecla.Key.ToString());
                if(tecla.Key == ConsoleKey.LeftArrow)
                {
                    jogo.Carro.PosicaoY = jogo.PosicionaObjeto(1);
                    TocarSom();
                }
                else if(tecla.Key == ConsoleKey.RightArrow)
                {
                    jogo.Carro.PosicaoY = jogo.PosicionaObjeto(2);
                    TocarSom();
                }
            }

            if(jogo.ChecarColisao())
            {
                GameOver();
                break;
            }

            Thread.Sleep(50);
        }
    }

    public static void DesenhaElemento(int linha, int coluna, char simbolo)
    {
        var xOriginal = Console.CursorLeft;
        var yOriginal = Console.CursorTop;
        Console.SetCursorPosition(coluna, linha);
        Console.Write(simbolo.ToString());
        Console.SetCursorPosition(xOriginal, yOriginal);
    }

    public static void DesenhaCenario()
    {
        Console.Clear();
        Console.WriteLine("+-----------+----------+");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("|           |          |");
        Console.WriteLine("+-----------+----------+");
    }

    public static void GameOver()
    {
        Console.Clear();
        Console.WriteLine("GAME OVER");
    }

    static void TocarSom()
    {
        Console.Beep();
    }
}