using CarMVVM.Commands;
using CarMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarMVVM.ViewModel
{
    internal class CarsViewModel
    {
        public ICommand addCarCommand { get; set; }
        public Car newCar { get; set; }
        public  ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();
        public CarsViewModel()
        {
            newCar = new();
            addCarCommand = new AddCommand(Add, CanAdd);
            Cars = new ObservableCollection<Car>()
            {
                new Car { ID = 1, Make = "Toyota", Model = "Corolla", Year = 2015, Price = 15000.00, Color = "Blue" },
                new Car { ID = 2, Make = "Honda", Model = "Civic", Year = 2017, Price = 18000.00, Color = "Red" },
                new Car { ID = 3, Make = "Ford", Model = "Mustang", Year = 2020, Price = 32000.00, Color = "Black" }
            };
        }
        private bool CanAdd(object obj)
        {
            return true;
        }

        private void Add(object obj)
        {
            //Car NewCar = obj as Car;
            //var car = new Car();
            //car.Model = NewCar.Model;
            //Cars.Add(car);
            //Cars.Add(obj as Car);
            Cars.Add(newCar);
            MessageBox.Show("Added");

        }

    }
}
