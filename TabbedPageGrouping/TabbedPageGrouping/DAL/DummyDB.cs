using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageGrouping.Models;

namespace TabbedPageGrouping.DAL {
    public class DummyDB {

        public List<Animal> Animals = new List<Animal>()
        {
            new Animal()
            {
                AnimalID = 1,
                ContinentOrigin = "Asia",
                Name = "Ant"
            },
            new Animal()
            {
                AnimalID = 2,
                ContinentOrigin = "Europe",
                Name = "Frog"
            },
            new Animal()
            {
                AnimalID = 3,
                ContinentOrigin = "Asia",
                Name = "Asian Elephant"
            },
            new Animal()
            {
                AnimalID = 4,
                ContinentOrigin = "Europe",
                Name = "Grasshopper"
            },
            new Animal()
            {
                AnimalID = 5,
                ContinentOrigin = "Europe",
                Name = "Mouse"
            },
            new Animal()
            {
                AnimalID = 6,
                ContinentOrigin = "Europe",
                Name = "Mosquito"
            },
            new Animal()
            {
                AnimalID = 7,
                ContinentOrigin = "Africa",
                Name = "Antelope"
            },
            new Animal()
            {
                AnimalID = 8,
                ContinentOrigin = "Africa",
                Name = "Camel"
            },
            new Animal()
            {
                AnimalID = 9,
                ContinentOrigin = "Africa",
                Name = "Egret"
            }
        };
    }
}
