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
        public AddPage()
        {
            InitializeComponent();
            BindingContext = new AddPageVM(Navigation);
        }
        public AddPage(Animal animal)
        {
            InitializeComponent();
            BindingContext = new AddPageVM(animal, Navigation);
        }
    }
}