using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Forms_Task
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public INavigation Navigation { get; set; }
        public AnimalsCollection Animals { get; set; }
        public ObservableCollection<Animal> AnimalsCol { get; set; }

        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;
            Animals = AnimalsCollection.getInstanse();
            AnimalsCol = AnimalsCollection.getInstanse().Animals;
        }
        public void AnimalTaped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage(Animals.Animals[0]));
        }
        public void OnButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }
    }
}
