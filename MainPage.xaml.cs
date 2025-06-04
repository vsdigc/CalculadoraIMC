namespace IMCcalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
         double peso, altura, imc;
         string classificacao;

         // Tentar converter as entradas
         bool pesoOk = double.TryParse(weightEntry.Text, out peso);
         bool alturaOk = double.TryParse(heightEntry.Text, out altura);

         if (!pesoOk || !alturaOk || altura <= 0)
         {
            labelResult.Text = "Por favor, insira valores válidos!";
            return;
         }
         // Cálculo do IMC
         imc = peso / (altura * altura);

         // Classificação
         if (imc < 18.5)
            classificacao = "Abaixo do peso.";
         else if (imc < 25)
            classificacao = "Peso normal.";
         else if (imc < 30)
            classificacao = "Acima do peso.";
         else
            classificacao = "Obesidade";

         // Mostrar resultado formatado
         labelResult.Text = $"Seu IMC É: {imc:F2}\nClassificação: {classificacao}";
        }
    }

}
