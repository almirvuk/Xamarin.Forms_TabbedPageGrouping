using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.Views;
using Xamarin.Forms;

namespace TabbedPageGrouping {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void GoToAll(object sender, EventArgs e) {
            Navigation.PushAsync(new AnimalPage());
        }

        private void GoToTabs(object sender, EventArgs e) {
            Navigation.PushAsync(new AnimalTabbedPage());

        }
    }
}
