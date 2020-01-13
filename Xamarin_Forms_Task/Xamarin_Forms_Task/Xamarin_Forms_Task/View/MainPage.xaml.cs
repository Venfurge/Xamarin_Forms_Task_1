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
            Animals.Add(new Animal() { Name = "John", ImageUrl = "a.jpg" });
            Animals.Add(new Animal() { Name = "Wick", ImageUrl = "b.jpg" });
            Animals.Add(new Animal() { Name = "Oleg", ImageUrl = "d.jpg" });
            Animals.Add(new Animal() { Name = "Brawler", ImageUrl = "a.jpg" });
            Animals.Add(new Animal() { Name = "John", ImageUrl = "e.jpg" });
            BindingContext = new MainPageVM(Navigation, Animals);
        }
    }
}
