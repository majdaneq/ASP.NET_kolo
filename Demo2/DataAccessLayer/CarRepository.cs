using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Demo2.Models;

namespace Demo2.DataAccessLayer
{
    public class CarRepository
    {
        private static List<CarCategoryModel> Categories = new List<CarCategoryModel>();

        static CarRepository()
        {
            var a = new CarCategoryModel { Id = 1, Name = "Opel" };
            a.Cars = new List<CarModel>
            {
                new CarModel {Id = 1, Brand="Opel",Name="Astra",ReleaseDate=2002,Engine=1.7f },
                new CarModel {Id = 1, Brand="Opel",Name="Zafira",ReleaseDate=2007,Engine=2.0f },
                new CarModel {Id = 1, Brand="Opel",Name="Vectra",ReleaseDate=2010,Engine=3.7f },
                new CarModel {Id = 1, Brand="Opel",Name="Corsa",ReleaseDate=2000,Engine=1.2f },
            };
            
            Categories.Add(a);

            a = new CarCategoryModel { Id = 2, Name = "Fiat" };
            a.Cars = new List<CarModel>
            {
               new CarModel {Id = 1, Brand="Fiat",Name="Punto",ReleaseDate=2002,Engine=1.7f },
               new CarModel {Id = 1, Brand="Fiat",Name="Panda",ReleaseDate=2007,Engine=2.0f },
               new CarModel {Id = 1, Brand="Fiat",Name="Seicento",ReleaseDate=2010,Engine=3.7f },
            };
            Categories.Add(a);

            a = new CarCategoryModel { Id = 3, Name = "Peugeot" };
            a.Cars = new List<CarModel>
            {
                new CarModel {Id = 1, Brand="Peugeot",Name="207",ReleaseDate=2002,Engine=1.7f },
               new CarModel {Id = 1, Brand="Peugeot",Name="307",ReleaseDate=2007,Engine=2.0f },
               new CarModel {Id = 1, Brand="Peugeot",Name="407",ReleaseDate=2010,Engine=3.7f },
            };
            Categories.Add(a);
        }

        public List<CarCategoryModel> GetCategories()
        {
            return Categories;
        }

        public CarCategoryModel GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.Id == id);
        }

        public CarModel GetCarById(int id)
        {
            foreach (var category in Categories)
            {
                foreach (var car in category.Cars)
                {
                    if (car.Id == id)
                        return car;
                }
            }

            return null;
        }

    }
}