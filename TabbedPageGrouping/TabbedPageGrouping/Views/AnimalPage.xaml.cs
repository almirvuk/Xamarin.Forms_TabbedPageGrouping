using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.ViewModels;
using Xamarin.Forms;

namespace TabbedPageGrouping.Views {

    public partial class AnimalPage : ContentPage {

        public AnimalPage() {

            InitializeComponent();
            BindingContext = new AnimalViewModel();
        }
    }
}
