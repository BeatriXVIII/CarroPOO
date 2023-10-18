using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace POO
{
    public class Carro
    {
        //propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public int CapacidadeDoTanque { get; set; }
        public int PercentualDeCombustivel { get; set; }
        public bool Ligado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public object PneuDianteiroEstepe { get; private set; }
        public bool CarroEstaOperaciona { get; set; }
        public object PercentualDianteiroDireito { get; private set; }
        public Pneu PneuDeEstepe { get; set; }
        public string Placa { get; set; }
        public Pneu pneuDianteiroEsquerdo;
        public Pneu pneuDianteiroDireito;
        public Pneu pneuTraseiroEsquerdo;
        public Pneu pneuTraseiroDireito;
        //metodo que pede para o usuário desligar o carro.
        public void TrocarPneu(Pneu pneu, Pneu novoPneu)
        {
            if (VelocidadeAtual > 0)
                throw new Exception("Vai Trocar o Pneu do carro, preguiçoso! E vê se não esquece de parar o carro.");
            if (Ligado)
                throw new Exception("Seu animal, desligue o carro!");

        }
        //pneu DIANTEIRO ESQUERDO chama o método TrocarPneu
        public Pneu PneuDianteiroEsquerdo
        {
            get { return pneuDianteiroEsquerdo; }
            set
            {
                TrocarPneu(pneuDianteiroEsquerdo, value);
                pneuDianteiroEsquerdo = value;
            }
        }
        //pneu DIANTEIRO DIREITO chama o método TrocarPneu
        public Pneu PneuDianteiroDireito
        {
            get { return pneuDianteiroDireito; }
            set { TrocarPneu(pneuDianteiroDireito, value); }
        }
        //pneu TRASEIRO ESQUERDO chama o método TrocarPneu
        public Pneu PneuTraseiroEsquerdo
        {
            get { return pneuTraseiroEsquerdo; }
            set
            {
                TrocarPneu(pneuTraseiroEsquerdo, value);
                pneuTraseiroEsquerdo = value;
            }
        }
        //pneu TRASEIRO DIANTEIRO chama o método TrocarPneu
        public Pneu PneuTraseiroDireito
        {
            get { return pneuTraseiroDireito; }
            set
            {
                TrocarPneu(pneuTraseiroDireito, value);
                pneuTraseiroDireito = value;
            }
        }
        public Carro(
             string marca,
             string modelo,
             string cor,
             int ano,
             string placa,
             int capacidadeDoTanque,
             int percentualDeCombustivel)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Placa = placa;
            Ligado = false;
            pneuDianteiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            pneuDianteiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            pneuTraseiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            pneuTraseiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500);
            PneuDeEstepe = new Pneu(13, "Michelin", 33, 38, 25, 70, 500, true);
            CapacidadeDoTanque = capacidadeDoTanque;
            PercentualDeCombustivel = percentualDeCombustivel;
        }
        public void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDiantero");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDiantero");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuDeEsquepe");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("PneuDianteiroEsquerdo: " + PneuDianteiroEsquerdo);
            Console.WriteLine("PneuDianteiroDireito: " + PneuDianteiroDireito);
            Console.WriteLine("PneuTraseiroEsquerdo: " + PneuTraseiroEsquerdo);
            Console.WriteLine("PneuTraseiroDireito: " + PneuTraseiroDireito);
            Console.WriteLine("PneuDeEstepe: " + PneuDeEstepe);
            Console.WriteLine("CapacidadeDoTanque: " + CapacidadeDoTanque);
            Console.WriteLine("PercentualDeCombustivel: " + PercentualDeCombustivel);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("velocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("velocidadeAtual: " + VelocidadeAtual);
        }
        public void Ligar()
        {
            if (PercentualDeCombustivel > 0)
                Ligado = true;
            PercentualDeCombustivel = PercentualDeCombustivel - 1;
        }
        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Frear(int impulso)
        {
            VelocidadeAtual -= impulso;
            PneuDianteiroDireito.Acelerar(impulso);
            PneuDianteiroEsquerdo.Acelerar(impulso);
            PneuTraseiroDireito.Acelerar(impulso);
            PneuTraseiroEsquerdo.Acelerar(impulso);
            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;
        }
        public void Acelerar(int impulso)
        {
            if (!Ligado)
            {
                Console.WriteLine("O carro está desligado.");
                return;
            }
            PercentualDeCombustivel -= 5;
            VelocidadeAtual += impulso;
            PneuDianteiroDireito.Acelerar(impulso);
            PneuDianteiroEsquerdo.Acelerar(impulso);
            PneuTraseiroDireito.Acelerar(impulso);
            PneuTraseiroEsquerdo.Acelerar(impulso);
            CarroEstaOperacional();

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            
        }
        public object GetPercentualDianteiroDireito()
        {
            return PercentualDianteiroDireito;
        }
        public bool CarroEstaOperacional()
        {
            if (PercentualDeCombustivel == 0)
            {
                Console.WriteLine("O carro está sem combustivel.");
                Desligar();
                return true;
            }
            if (PneuDianteiroDireito.Estourado || PneuDianteiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro direto");
                Parar();
                return false;
            }
            if (PneuDianteiroEsquerdo.Estourado || PneuDianteiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro esquerdo");
                Parar();
                return false;
            }
            if (PneuTraseiroDireito.Estourado || PneuTraseiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu traseiro direito.");
                Parar();
                return false;
            }
            if (PneuTraseiroEsquerdo.Estourado || PneuTraseiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o pneu traseiro esquerdo");
                Parar();
                return false;
            }
            return true;
        }
        private void Parar()
        {
            Frear(VelocidadeAtual);
        }

        internal void Acelerar()
        {
            throw new NotImplementedException();
        }
    }
}
