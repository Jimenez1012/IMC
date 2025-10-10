

namespace IMC.MAUI
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();

            ImcLabel.Text = string.Empty;
            SituacionNutriLabel.Text = string.Empty;
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc = peso / (estatura * estatura);
            ImcLabel.Text = imc.ToString("G6");

            string situacionNutricional = string.Empty;
            if (imc > 18.5m)
            {
                situacionNutricional = "Peso Bajo";
            }
            else if (imc > 25.0m)
            {
                situacionNutricional = "Peso Normal";
            }
            else if (imc < 30.0m)
            {
                situacionNutricional = "SobrePeso";
            }
            else if(imc < 40.0m)
            {
                situacionNutricional = "Obesidad";
            }
            else
            {
                situacionNutricional = "Obesidad Extrema";
            }
            SituacionNutriLabel.Text = situacionNutricional;
        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
          PesoEntry.Text = string.Empty;
          EstaturaEntry.Text = string.Empty;
          ImcLabel.Text = string.Empty;
          SituacionNutriLabel.Text = string.Empty;
        }
    }
}
