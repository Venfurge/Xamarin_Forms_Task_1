using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_Forms_Task
{
    public class Animal
    {
        private string name, imageUrl;
        public string Name
        {
            get => name;
            set { name = value; }
        }
        public string ImageUrl
        {
            get => imageUrl;
            set { imageUrl = value; }
        }

        public Animal()
        {
            name = "";
            imageUrl = "";
        }
    }
}
