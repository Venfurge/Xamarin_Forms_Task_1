using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_Forms_Task
{
    public class Animal
    {
        private string name, imageUrl, description;
        private DateTime data;
        private uint mark;
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
        public string Description
        {
            get => description;
            set { description = value; }
        }
        public DateTime Data
        {
            get => data;
            set { data = value; }
        }
        public uint Mark
        {
            get => mark;
            set { mark = value; }
        }
        public Animal()
        {
            name = "";
            imageUrl = "";
            description = "";
            data = data.Date;
            mark = 0;
        }
    }
}
