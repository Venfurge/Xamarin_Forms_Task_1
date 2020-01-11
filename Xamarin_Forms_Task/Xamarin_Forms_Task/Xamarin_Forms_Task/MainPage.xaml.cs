using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Forms_Task
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //public ObservableCollection<Animal> Animals { get; set; }
        public AnimalsCollection Animals { get; set; }
        public ObservableCollection<Animal> AnimalsCol { get; set; }
        public MainPage()   
        {
            InitializeComponent();
            Animals = AnimalsCollection.getInstanse();
            AnimalsCol = AnimalsCollection.getInstanse().Animals;
            BindingContext = this;
        }
        private void AnimalTaped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage(Animals.Animals[0]));
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            //Animals.Animals.Add(new Animal { Name = "Oleg", ImageUrl = "a.jpg" });
            Navigation.PushAsync(new AddPage());
        }
    }
}
