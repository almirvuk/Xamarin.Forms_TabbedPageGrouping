using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.DAL;
using TabbedPageGrouping.Models;

namespace TabbedPageGrouping.ViewModels {

    public class AnimalViewModel : INotifyPropertyChanged {

        private ObservableCollection<Animal> animals;
        public ObservableCollection<Animal> Animals {
            get { return animals; }
            set { animals = value; }
        }

        public AnimalViewModel() {

            Animals = new ObservableCollection<Animal>();

            DummyDB _context = new DummyDB();

            foreach (var animal in _context.Animals) {
                Animals.Add(animal);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
