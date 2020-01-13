using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
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
        public ICommand CreateAnimalCommand { get; set; }
        public ICommand AnimalTapCommand { get; set; }

        private Animal selectedAnimal;
        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;
            Animals = AnimalsCollection.getInstanse();
            AnimalsCol = AnimalsCollection.getInstanse().Animals;
            CreateAnimalCommand = new Command(CreateAnimal);
            AnimalTapCommand = new Command(AnimalTap);
        }

        public Animal SelectedAnimal
        {
            get => selectedAnimal;
            set
            {
                selectedAnimal = value;
                OnPropertyChanged("SelectedAnimal");
            }
        }
        private void CreateAnimal()
        {
            Navigation.PushAsync(new AddPage());
        }
        private void AnimalTap()
        {
            if (SelectedAnimal == null)
                return;
            Navigation.PushAsync(new AddPage(SelectedAnimal));
            SelectedAnimal = null;
        }
    }
}
