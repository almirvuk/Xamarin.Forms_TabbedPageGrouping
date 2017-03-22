using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.ViewModels;
using Xamarin.Forms;

namespace TabbedPageGrouping.Views {

    public partial class AnimalTabPage : ContentPage {

        public AnimalTabPage(string continent) {

            InitializeComponent();

            // Do not forget to set title for the 
            // value you are using in tab 
            Title = continent;

            BindingContext = new AnimalSecondViewModel(continent);
        }
    }
}
