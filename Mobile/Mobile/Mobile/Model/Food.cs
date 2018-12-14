using Parse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    class Food
    {
        public static List<string> FoodNames = new List<string>
        { "Omlet" , "Mercimek" , "Gözleme" , "Menemen"};

        public Food()
        {
            initAsync();
        }

        private async System.Threading.Tasks.Task initAsync()
        {
            var query = from Food in ParseObject.GetQuery("food_name") where true select Food;
            IEnumerable<ParseObject> results = await query.FindAsync();
            
        }
    }
}
