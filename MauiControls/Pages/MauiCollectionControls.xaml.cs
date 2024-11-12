using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
    public MauiCollectionControls()
    {
        InitializeComponent();
        BindingContext = new FotoViewModel();
    }

    // Certifique-se de que a assinatura esteja correta
    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null && e.PreviousItem != null)
        {
            Foto anterior = e.PreviousItem as Foto;
            Foto atual = e.CurrentItem as Foto;

            DisplayAlert("CarouselView", $"Anterior = {anterior?.Nome} \n\nAtual = {atual?.Nome}", "Ok");
        }
    }

    private void SeatbeltAlert_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta do Cinto de Segurança!", "Selecionou/deselecionou este componente!", "Ok");
    }



    //private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //{
    //    if (e.CurrentItem != null && e.PreviousItem != null)
    //    {
    //        Foto anterior = e.PreviousItem as Foto;
    //        Foto atual = e.CurrentItem as Foto;

    //        await DisplayAlert("CarouselView", $"Anterior = {anterior.Nome} \n\nAtual = {atual.Nome}", "Ok");
    //    }
    //}
}
