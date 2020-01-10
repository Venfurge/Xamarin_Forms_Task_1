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
        public Animal animal { get; set; }
        public AddPage()
        {
            Visibility = false;
            InitializeComponent();
            Animals = AnimalsCollection.getInstanse();
            animal = new Animal();
        }
        public AddPage(Animal animal)
        {
            Visibility = true;
            InitializeComponent();
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
    }
}