namespace JogoCorrida
{
    public class Jogo
    {
        public Elemento Carro { get; set; }
        public List<Elemento> Obstaculos { get; set; }
        public List<Elemento> Moedas { get; set; }

        public int Velocidade { get; set; }
        public int Pontuacao { get; set; }
        public int Tempo { get; set; }
        public int MelhorPontuacao { get; set; }
        public int ColisoesPermitidas { get; set; }
        public int Faixa1Inicio { get; set; }
        public int Faixa1Fim {  get; set; }
        public int Faixa2Inicio { get; set; }
        public int Faixa2Fim { get; set; }
        public int YMaximo { get; set; } = 50;

        public void IniciaJogo()
        {
            Carro = new Elemento();
            Carro.Tipo = TipoElemento.Carro;
            Carro.PosicaoX = PosicionaObjeto(1);
            Carro.PosicaoY = YMaximo - 10;

            Carro.Altura = 100;
            Carro.Largura = 50;

            Obstaculos = FabricaObstaculos(3, 200, 400);
            Moedas = FabricaMoedas(3, 200, 400);
        }
        public List<Elemento> FabricaObstaculos(int qtd, int dmin, int dmax)
        {
            var y_inicial = -100;
            var rnd = new Random();
            var obstaculos = new List<Elemento>();

            for (int i = 0; i < qtd; i++)
            {
                if (i != 0) y_inicial -= rnd.Next(dmin, dmax);
                var ob = new Elemento
                {
                    Tipo = TipoElemento.Obstaculo,
                    Altura = 200,
                    Largura = 100
                };

                var faixa = rnd.Next(1, 3);
                ob.PosicaoX = PosicionaObjeto(faixa);
                ob.PosicaoY = y_inicial;
                obstaculos.Add(ob);
            }
            return obstaculos;
        }

        public List<Elemento> FabricaMoedas(int qtd, int dmin, int dmax)
        {
            var y_inicial = -100;
            var rnd = new Random();
            var moedas = new List<Elemento>();

            for (int i = 0; i < qtd; i++)
            {
                if (i != 0) y_inicial -= rnd.Next(dmin, dmax);
                var md = new Elemento
                {
                    Tipo = TipoElemento.Moeda,
                    Altura = 200,
                    Largura = 100
                };

                var faixa = rnd.Next(1, 3);
                md.PosicaoX = PosicionaObjeto(faixa);
                md.PosicaoY = y_inicial;
                moedas.Add(md);
            }
            return moedas;
        }

        public int PosicionaObjeto(int faixa)
        {
            if (faixa == 1)
            {
                return Faixa1Fim - ((Faixa1Fim - Faixa1Inicio) / 2);
            }
            else
            {
                return Faixa2Fim - ((Faixa2Fim - Faixa2Inicio) / 2);
            }
        }

        public void Acelerar (int incremento)
        {
            Velocidade += incremento;
        }

        public int ChecaFaixaElemento(Elemento elemento)
        {
            if (elemento.PosicaoX >= Faixa1Inicio && elemento.PosicaoX <= Faixa1Fim)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public bool ChecarColisao()
        {
            foreach (var ob in Obstaculos)
            {
                if (ChecaFaixaElemento(Carro) == ChecaFaixaElemento(ob))
                {
                    if (Math.Abs((Carro.PosicaoY + 50) - (ob.PosicaoY + 100)) <= 30)
                        return true;
                }
            }
            return false;
        }

        public bool ChecarPontuacao()
        {
            foreach (var md in Moedas)
            {
                if (ChecaFaixaElemento(Carro) == ChecaFaixaElemento(md))
                {
                    if (Math.Abs((Carro.PosicaoY + 50) - (md.PosicaoY + 100)) <= 30)
                        return true;
                }
            }
            return false;
        }

        public bool VerificaFimJogo()
        {
            return ChecarColisao();
        }

        public void MovimentaObstaculos()
        {
            foreach (var ob in Obstaculos)
            {
                ob.PosicaoY += 15;
                if(ob.PosicaoY > YMaximo)
                {
                    ob.PosicaoY = 0;
                }
            }

            foreach (var md in Moedas)
            {
                md.PosicaoY += 50;
                if (md.PosicaoY > YMaximo)
                {
                    md.PosicaoY = 0;
                }
            }
        }
    }
}
