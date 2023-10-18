namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu meuPneu = new Pneu(17, "Michelin", 33, 38, 25, 240, 500);
            meuPneu.exibir();
            Pneu troca;

            Carro carro = new Carro("Chevrolet", "Sedan", "Branco", 1984, "KA-4185", 50, 100);
        }
    }
}