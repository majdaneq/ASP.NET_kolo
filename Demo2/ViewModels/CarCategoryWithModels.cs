using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2.ViewModels
{
    public class CarCategoryWithModels
    {   public List<CarCategoryModel> CarBrand { get; set; }
        public List<CarModel> CarModel { get; set; }
        public int CurrentCategory { get; set; }
    }
}