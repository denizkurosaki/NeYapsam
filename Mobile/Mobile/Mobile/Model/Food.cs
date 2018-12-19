using Parse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    class Food
    {
        public Int16 ID { get; set; }
        public String Label { get; set; }
        public String Image { get; set; }
        public String Calorie { get; set; }

        public List<Ingredient> ingredients;
    }
}
