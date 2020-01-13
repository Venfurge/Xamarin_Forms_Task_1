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
        public ObservableCollection<Animal> Animals { get; set; }
        public MainPage()   
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();
            BindingContext = new MainPageVM(Navigation, Animals);
        }
    }
}
