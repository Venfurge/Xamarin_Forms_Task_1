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
    //Comment
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()   
        {
            InitializeComponent();
            BindingContext = new MainPageVM(Navigation);
        }
        private void AnimalTapped(object sender, SelectionChangedEventArgs e)
        {
            ((MainPageVM)BindingContext).AnimalTaped(sender, e);
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            ((MainPageVM)BindingContext).OnButtonClick(sender, e);
        }
    }
}
