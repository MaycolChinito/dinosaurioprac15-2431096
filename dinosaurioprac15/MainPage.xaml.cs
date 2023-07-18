using System.Buffers.Text;

namespace dinosaurioprac15;

//<Summary>
//<Createddate>15/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>17/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// Construya un programa en MAUI que dado el nombre de un dinosaurio, su peso(kg) y su altura(mts),
// nos calcule su peso expresado en libras y su altura expresada en centímetros
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double PesoDinosaurio = Convert.ToDouble(Peso.Text);


        double libras =  220462262 * (PesoDinosaurio);

        Pesado.Text = Convert.ToString(libras);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        double AlturaDinosaurio = Convert.ToDouble(Altura.Text);


        double centimetros = 100 * (AlturaDinosaurio);

        AlturaMedida.Text = Convert.ToString(centimetros);
    }
}

