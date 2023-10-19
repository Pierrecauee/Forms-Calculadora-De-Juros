namespace App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lblValorPrincipalEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void Fundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtValorEmprestimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTaxaJuros_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxaAnualDeJuros_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            double principal = Convert.ToDouble(txtValorEmprestimo.Text); //esta convertendo os valores das text box para numeros
            double taxaJurosAnual = Convert.ToDouble(txtTaxaAnualDeJuros.Text); //esta convertendo os valores das text box para numeros
            int numParcelas = Convert.ToInt32(NumerodeParcelas.Text); //esta convertendo os valores das text box para numeros

            //transforma a taxa de juros anual em taxa de juros mensal
            double taxaJurosMensal = (taxaJurosAnual / 12) / 100;

            //multiplica a taxa de juros mensal assim calculando a amortizacao a partir das parcelas de juros mensais
            double valorDaParcela = (principal * taxaJurosMensal) / (1 - Math.Pow(1 + taxaJurosMensal, -numParcelas));

            // Calcula o valor total a ser pagoincluindo juros
            double valorTotal = valorDaParcela * numParcelas;

            double valorJuros = valorTotal - principal;
            // Exibe os resultados na interface do usuário
            lblResultado.Text = "Valor da Parcela: R$"
                                + valorDaParcela.ToString("F2")
                                + "\nValor Total a Pagar: R$"
                                + valorTotal.ToString("F2")
                                + "\nValor Juros: "
                                + valorJuros.ToString("F2");

        }

        private void NumerodeParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}