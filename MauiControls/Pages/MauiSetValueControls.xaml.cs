using System.Globalization;

namespace MauiControls.Pages;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
		InitializeComponent();
	}

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");

        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");

        }
    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");

        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(slider1.Value, 2);
        lblSlider.Text = valor.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Valor do Stepper {value}");
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "On", "OK");
        }
        else
        {
            await DisplayAlert("Switch", "Off", "OK");

        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-PT");
        var data = ((DatePicker)sender).Date;
        var dataSelecionada = data.ToString("d", culture);
        await DisplayAlert("Data Selecionada", dataSelecionada, "OK");
    }

    private async void time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (time1 != null)
        {
            var horaSelecionada = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Hora Selecionada", horaSelecionada, "OK");
        }
    }
}