namespace POO
{
    public class Pneu
    {
        public int Aro { get; set; }
        public String Marca { get; set; }
        public int PSI { get; set; }
        public int PSIMaximo { get; set; }
        public int PSIMinimo { get; set; }
        public int Largura { get; set; }
        public double PercentualBorracha { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int CargaMaxima { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public int VelocidadeAtual { get; set; }
        public int CargaAtual { get; set; }
        public bool Estepe { get; set; }

        public Pneu(int aro, string marca, int pSI, int pSIMaximo, int largura, int velocidadeMaxima, int cargaMaxima, bool estepe = false)
        {
            Aro = aro;
            Marca = marca;
            PSI = pSI;
            PSIMaximo = pSIMaximo;
            PSIMinimo = 0;
            Largura = largura;
            PercentualBorracha = 100;
            VelocidadeMaxima = velocidadeMaxima;
            CargaMaxima = cargaMaxima;
            Estourado = false;
            Furado = false;
            VelocidadeAtual = 0;
            CargaAtual = 0;
            Estepe = estepe;
        }
        public void exibir()
        {
            Console.WriteLine("\n\nAro: " + Aro);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("PSI: " + PSI);
            Console.WriteLine("PSIMaximo: " + PSIMaximo);
            Console.WriteLine("PSIMinimo: " + PSIMinimo);
            Console.WriteLine("Largura: " + Largura);
            Console.WriteLine("PercentualBorracha:" + PercentualBorracha);
            Console.WriteLine("VelocidadeMaxima:" + VelocidadeMaxima);
            Console.WriteLine("CargaMaxima: " + CargaMaxima);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("CargaAtual: " + CargaAtual);

        }
        public void Acelerar(int impulso)
        {
            if (Furado || Estourado)
            {
                string estado;

                estado = Furado ? "furado" : "estourado";
                Console.WriteLine($"O Pneu esta {estado}");
                return;
            }

            VelocidadeAtual = VelocidadeAtual + impulso;
            PercentualBorracha = PercentualBorracha - 1;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

            if (PercentualBorracha < 0)
                PercentualBorracha = 0;



            if (PercentualBorracha < 30)
            {
                Estourado = true;
                VelocidadeAtual = 0;
            }
        }
        public void Frear(int impulso)
        {
            VelocidadeAtual = VelocidadeAtual - impulso;
            PercentualBorracha = PercentualBorracha - 1;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;
            if (PercentualBorracha < 0)
                PercentualBorracha = 0;
            /*if(VelocidadeAtual == 0 )
             *{
             *    exibir();
             *    PercentualBorracha += 2;
             *    //Thread.Sleep(2000);
             *}
             */
            EstourarPneu();
        }
        private void EstourarPneu()
        {
            if (PercentualBorracha < 30 || VelocidadeAtual > VelocidadeMaxima || PSI > PSIMaximo || CargaAtual > CargaMaxima)
            {
                Estourado = true;
                VelocidadeAtual = 0;
            }
        }

        public void Furar()
        {
            Furado = true;
        }
        public void Remendar()
        {
            Furado = false;
        }

        internal void Exibir()
        {
            throw new NotImplementedException();
        }
    }
}