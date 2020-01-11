using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Forms_Task
{
    public class AddPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public INavigation Navigation { get; set; }
        public AnimalsCollection Animals { get; set; }
        public ObservableCollection<Animal> AnimalsCol { get; set; }
        public bool Visibility { get; set; }
        public bool Enability { get; set; }
        public Animal Animal { get; set; }
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
        public AddPageVM(INavigation navigation)
        {
            Visibility = true;
            Enability = false;
            Animals = AnimalsCollection.getInstanse();
            AnimalsCol = Animals.Animals;
            Navigation = navigation;
            Animal = new Animal();
        }

        public AddPageVM(Animal Animal, INavigation navigation)
        {
            Visibility = false;
            Enability = true;
            Animals = AnimalsCollection.getInstanse();
            Navigation = navigation;
            AnimalsCol = Animals.Animals;
            this.Animal = Animal;
            OnPropertyChanged("Name");
            OnPropertyChanged("ImageUrl");
        }
        public void nameEntryCompleted(object sender, EventArgs e)
        {
            Animal.Name = ((Entry)sender).Text;
        }
        public void imageUrlEntryCompleted(object sender, EventArgs e)
        {
            Animal.ImageUrl = ((Entry)sender).Text;
        }
        public void saveButtonClicked(object sender, EventArgs e)
        {
            Animals.Animals.Add(Animal);
            Navigation.PopAsync();
        }
        public void deleteButtonClicked(object sender, EventArgs e)
        {
            Animals.Animals.Remove(Animal);
            Navigation.PopAsync();
        }
    }
}
