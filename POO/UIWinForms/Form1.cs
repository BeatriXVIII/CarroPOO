using POO;

namespace UIWinForms
{
    public partial class Form1 : Form
    {
        Carro carro;

        public Form1()
        {
            InitializeComponent();
            carro = new Carro("Chevrolet", "Sedan", "Branco", 1984, "KA-4185", 50, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carro.Frear(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void ExibirPneu(Pneu pneu, TextBox textbox)
        {
            textbox.Text = textbox.Text + "\r\nAro:" + pneu.Aro;
            textbox.Text = textbox.Text + "\r\nMarca: " + pneu.Marca;
            textbox.Text = textbox.Text + "\r\nPSI: " + pneu.PSI;
            textbox.Text = textbox.Text + "\r\nPSIMaximo: " + pneu.PSIMinimo;
            textbox.Text = textbox.Text + "\r\nPSIMinimo: " + pneu.PSI;
            textbox.Text = textbox.Text + "\r\nLargura: " + pneu.Largura;
            textbox.Text = textbox.Text + "\r\nPercentualBprracha: " + pneu.PercentualBorracha;
            textbox.Text = textbox.Text + "\r\nVelocidadeMaxima: " + pneu.VelocidadeMaxima;
            textbox.Text = textbox.Text + "\r\nCargaMaxima: " + pneu.CargaMaxima;
            textbox.Text = textbox.Text + "\r\nEstourado: " + pneu.Estourado;
            textbox.Text = textbox.Text + "\r\nFurado: " + pneu.Furado;
            textbox.Text = textbox.Text + "\r\nEstepe: " + pneu.Estepe;

            if (pneu.Estourado)
            {
                textbox.BackColor = Color.Red;
            }
        }
        private void Form1Lord(object sender, EventArgs e)
        {
            Exibir();
        }
        private void Exibir()
        {
            textBoxExibir.Text = textBoxExibir.Text + "\r\nMarca: " + carro.Marca;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nModelo: " + carro.Modelo;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCor: " + carro.Cor;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nAno: " + carro.Ano;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPlaca: " + carro.Placa;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCapacidadeDoTanque: " + carro.CapacidadeDoTanque;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPercentualDeCombustivel: " + carro.PercentualDeCombustivel;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nLigado: " + carro.Ligado;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nvelocidadeMaxima: " + carro.VelocidadeMaxima;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nvelocidadeAtual: " + carro.VelocidadeAtual;

            ExibirPneu(carro.PneuDianteiroEsquerdo, textBoxPneuDianteiroEsquerdo);
            ExibirPneu(carro.PneuDianteiroDireito, textBoxPneuDianteiroDireito);
            ExibirPneu(carro.PneuTraseiroEsquerdo, textBoxPneuTraseiroEsquerdo);
            ExibirPneu(carro.PneuTraseiroDireito, textBoxPneuTraseiroDireito);
            ExibirPneu(carro.PneuDeEstepe, textBoxPneuDeEstepe);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Exibir();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (carro.Ligado)
            {
                carro.Desligar();
                button.Text = "Ligar";
            }
            else
            {
                button.Text = "Desligar";
                carro.Ligar();
            }
            Exibir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carro.Acelerar(Convert.ToInt32(textBoxImpulso.Text)); ;
            Exibir();
        }
        private void buttonTrocarPneu_Click(object sender, EventArgs e)
        {
            try
            {

                Pneu pneu = null;
                switch (comboBoxPneu.SelectedIndex)
                {
                    case 0:
                        pneu = carro.PneuDianteiroEsquerdo;
                        carro.PneuDianteiroEsquerdo = carro.PneuDeEstepe;

                        break;
                    case 1:
                        pneu = carro.PneuDianteiroDireito;
                        carro.PneuDianteiroDireito = carro.PneuDeEstepe;
                        break;

                    case 2:
                        pneu = carro.PneuTraseiroEsquerdo;
                        carro.PneuTraseiroEsquerdo = carro.PneuDeEstepe;
                        break;
                    case 3:
                        pneu = carro.PneuTraseiroDireito;
                        carro.PneuTraseiroDireito = carro.PneuDeEstepe;
                        break;
                }
                if (pneu != null)
                {
                    carro.PneuDeEstepe = pneu;
                }
                Exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        public Pneu PneuDianteiroEsquerdo
        {
            get
            {
                return PneuDianteiroEsquerdo;
            }
            set
            {
                if (Ligado)
                {
                    throw new Exception("Seu animal, desliga o carro!");
                }
                PneuDianteiroEsquerdo = value;
            }
        }
        private void SemCombustivel()
        {
            if (carro.PercentualDeCombustivel < 49)
            {
                return;
            }
            throw new Exception("Seu animal, Reponha o combustivel!");
            return;
        }
        public bool Ligado { get; private set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxERRO_TextChanged(object sender, EventArgs e)
        {
            carro.CarroEstaOperacional();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}