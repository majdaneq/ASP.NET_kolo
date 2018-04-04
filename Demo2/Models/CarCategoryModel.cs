using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2.Models
{
    public class CarCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> Cars { get; set; }
    }
}