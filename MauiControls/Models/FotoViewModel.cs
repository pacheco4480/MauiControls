using System.Collections.ObjectModel;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> Fotos { get; private set; }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() {Nome = "Andrômeda", ImageUrl = "galaxia1.jpeg"},
                new Foto() {Nome = "Via Láctea", ImageUrl = "galaxia2.jpeg"},
                new Foto() {Nome = "Universo", ImageUrl = "galaxia3.jpeg"},
                new Foto() {Nome = "Galáxia", ImageUrl = "galaxia4.jpeg"},
                new Foto() {Nome = "Sombrero", ImageUrl = "galaxia5.jpeg"},
            };
        }
    }
}
