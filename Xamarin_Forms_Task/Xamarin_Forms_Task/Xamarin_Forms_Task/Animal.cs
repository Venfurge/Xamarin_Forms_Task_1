using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Forms_Task
{
    public class Animal
    {
        private string name, imageUrl;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
    }
}
