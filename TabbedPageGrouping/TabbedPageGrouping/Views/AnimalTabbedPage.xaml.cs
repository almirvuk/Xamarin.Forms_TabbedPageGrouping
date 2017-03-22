using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.DAL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageGrouping.Views {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalTabbedPage : TabbedPage {

        public AnimalTabbedPage() {

            InitializeComponent();

            DummyDB _context = new DummyDB();

            List<string> allContinents = new List<string>();

            // Retrieve and insert all continents from our list
            foreach (var continent in _context.Animals) 
                allContinents.Add(continent.ContinentOrigin);

            // Distinct to remove duplicates
            allContinents = allContinents.Distinct().ToList();

            // Create dinamically tabs for continents that we have
            foreach (var continent in allContinents) 
                Children.Add(new AnimalTabPage(continent));
        }
    }
}
