namespace MinhaPrimeiraInterface;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        var idadeInsirida = txtIdade.Text;
        if (int.TryParse(idadeInsirida, out var idadeConvertida))
        {
            var resultadoCalculo = idadeConvertida * 7;

            lblResultado.Text = $"A idade total do seu cachorro é de {resultadoCalculo} anos.";
        }
        else
        {
            MessageBox.Show("O número digitado precisa ser inteiro!");
        }
    }
}