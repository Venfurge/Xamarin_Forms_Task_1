using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin_Forms_Task
{
    public class AnimalsCollection
    {
        private static AnimalsCollection instanse;
        public ObservableCollection<Animal> Animals { get; set; }
        private AnimalsCollection()
        {
            Animals = new ObservableCollection<Animal>();
        }
        public static AnimalsCollection getInstanse()
        {
            if (instanse == null)
                instanse = new AnimalsCollection();
            return instanse;
        }
    }
}
