using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Forms_Task
{
    public class AddPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public ObservableCollection<Animal> AnimalsCol { get; set; }
        public bool Visibility { get; set; }
        public bool Enability { get; set; }
        public Animal Animal { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand SaveAnimalCommand { get; set; }
        public ICommand DeleteAnimalCommand { get; set; }
        public string Name
        {
            get => Animal.Name;
            set 
            { 
                Animal.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string ImageUrl
        {
            get => Animal.ImageUrl;
            set 
            { 
                Animal.ImageUrl = value;
                OnPropertyChanged("ImageUrl");
            }
        }
        public string Description
        {
            get => Animal.Description;
            set 
            {
                Animal.Description = value;
                OnPropertyChanged("Description");
            }
        }
        public DateTime Data
        {
            get => Animal.Data;
            set
            {
                Animal.Data = value;
                OnPropertyChanged("Data");
            }
        }
        public uint Mark
        {
            get => Animal.Mark;
            set 
            { 
                Animal.Mark = value;
                OnPropertyChanged("Mark");
            }
        }
        public AddPageVM(ObservableCollection<Animal> Animals, INavigation navigation)
        {
            Visibility = true;
            Enability = false;
            AnimalsCol = Animals;
            Navigation = navigation;
            Animal = new Animal();
            SaveAnimalCommand = new Command(SaveAnimal);
            DeleteAnimalCommand = null;
        }
        public AddPageVM(Animal Animal, ObservableCollection<Animal> Animals, INavigation navigation)
        {
            Visibility = false;
            Enability = true;
            Navigation = navigation;
            AnimalsCol = Animals;
            this.Animal = Animal;
            OnPropertyChanged("Name");
            OnPropertyChanged("ImageUrl");
            DeleteAnimalCommand = new Command(DeleteAnimal);
            SaveAnimalCommand = null;
        }
        private void SaveAnimal(object sender)
        {
            AnimalsCol.Add(Animal);
            Navigation.PopAsync();
        }
        private void DeleteAnimal()
        {
            AnimalsCol.Remove(Animal);
            Navigation.PopAsync();
        }
    }
}
