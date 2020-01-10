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
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Animal> Animals { get; set; }
        public MainPage()   
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>
            {
                new Animal { Name = "John", ImageUrl = "e.jpg"}
            };
            BindingContext = this;
        }     
        private void OnButtonClick(object sender, EventArgs e)
        {
            Animals.Add(new Animal { Name = "Oleg", ImageUrl = "a.jpg" });
            //Navigation.PushAsync(new AddPage());
        }
    }
}
