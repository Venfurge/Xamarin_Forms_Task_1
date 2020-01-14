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
            Animals.Add(new Animal() { Name = "John", ImageUrl = "a.jpg", Description = "John is hungry", Data = new DateTime(2019,11,28), Mark = 38 });
            Animals.Add(new Animal() { Name = "Wick", ImageUrl = "b.jpg", Description = "Wick fill wickness", Data = new DateTime(2013, 1, 13), Mark = 15 });
            Animals.Add(new Animal() { Name = "Oleg", ImageUrl = "d.jpg", Description = "Oleg is Oleg", Data = new DateTime(2001, 12, 13), Mark = 88 });
            Animals.Add(new Animal() { Name = "Brawler", ImageUrl = "a.jpg", Description = "Nothing Special", Data = new DateTime(2014, 5, 16), Mark = 12 });
            Animals.Add(new Animal() { Name = "John", ImageUrl = "e.jpg", Description = "Against this John", Data = new DateTime(2003, 3, 3), Mark = 57 });
            BindingContext = new MainPageVM(Navigation, Animals);
        }
    }
}
