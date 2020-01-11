using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Forms_Task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AnimalsCollection Animals { get; set; }
        public bool Visibility { get; set; }
        public bool Enability { get; set; }
        public Animal animal { get; set; }
        public AddPage()
        {
            Visibility = true;
            Enability = false;
            InitializeComponent();
            Animals = AnimalsCollection.getInstanse();
            animal = new Animal();
            BindingContext = this;
        }
        public AddPage(Animal animal)
        {
            Visibility = false;
            Enability = true;
            InitializeComponent();
            Animals = AnimalsCollection.getInstanse();
            BindingContext = this;
        }
        private void nameEntryCompleted(object sender, EventArgs e)
        {
            animal.Name = ((Entry)sender).Text;
        }
        private void imageUrlEntryCompleted(object sender, EventArgs e)
        {
            animal.ImageUrl = ((Entry)sender).Text;
        }    
        private void saveButtonClicked(object sender, EventArgs e)
        {
            Animals.Animals.Add(animal);
            Navigation.PopAsync();
        }
        private void deleteButtonClicked(object sender, EventArgs e)
        {
            Animals.Animals.Remove(animal);
            Navigation.PopAsync();
        }
    }
}