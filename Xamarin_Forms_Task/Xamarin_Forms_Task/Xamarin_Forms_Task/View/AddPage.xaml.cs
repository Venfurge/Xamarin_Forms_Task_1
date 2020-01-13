using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public AddPage(ObservableCollection<Animal> AnimalsCol)
        {
            InitializeComponent();
            BindingContext = new AddPageVM(AnimalsCol, Navigation);
        }
        public AddPage(Animal animal, ObservableCollection<Animal> AnimalsCol)
        {
            InitializeComponent();
            BindingContext = new AddPageVM(animal, AnimalsCol, Navigation);
        }
    }
}