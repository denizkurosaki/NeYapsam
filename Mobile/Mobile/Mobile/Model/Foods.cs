using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    class Foods
    {
        public static List<Food> foods = new List<Food>
        {
            new Food{ID = 1,    Image = "meal.png",    Label = "Pilav",    Calorie = "283 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[24],Ingredients.ing[13] } },

            new Food{ID = 2,    Image = "meal.png",    Label = "Menemen",    Calorie = "177 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[19],Ingredients.ing[14],
                Ingredients.ing[6], Ingredients.ing[5], } },

            new Food{ID = 3,    Image = "dessert.png",    Label = "Sütlaç",    Calorie = "386 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[24],Ingredients.ing[26], Ingredients.ing[8] } },

            new Food{ID = 4,    Image = "meal.png",    Label = "Karnıyarık",    Calorie = "191 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[23],Ingredients.ing[12] } },

            new Food{ID = 9,    Image = "saladdish.png",    Label = "Piyaz",    Calorie = "59 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[14],Ingredients.ing[25], Ingredients.ing[11] } },

            new Food{ID = 5,    Image = "meal.png",    Label = "Tavuksote",    Calorie = "288 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[4],Ingredients.ing[19], Ingredients.ing[14], } },

            new Food{ID = 8,    Image = "saladdish.png",    Label = "Çoban Salatası",    Calorie = "98 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[17], Ingredients.ing[14], Ingredients.ing[19]
            ,Ingredients.ing[11]} },

            new Food{ID = 6,    Image = "meal.png",    Label = "Etsote",    Calorie = "255 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[12], Ingredients.ing[19], Ingredients.ing[14], } },

            new Food{ID = 7,    Image = "meal.png",    Label = "Köfte",    Calorie = "235 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[12] } },

            new Food{ID = 10,    Image = "saladdish.png",    Label = "Sezar Salatası",    Calorie = "466 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[17],Ingredients.ing[3], Ingredients.ing[14],
                Ingredients.ing[11] ,Ingredients.ing[9],Ingredients.ing[6]} },

            new Food{ID = 11,    Image = "meal.png",    Label = "Balık Tava",    Calorie = "164 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[7],Ingredients.ing[11], Ingredients.ing[13] } },

            new Food{ID = 12,    Image = "meal.png",    Label = "Fırında Patates",    Calorie = "431 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[16],Ingredients.ing[14], Ingredients.ing[19] } },

            new Food{ID = 13,    Image = "meal.png",    Label = "Patates Kızartması",    Calorie = "250 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[16], Ingredients.ing[13] } },

            new Food{ID = 14,    Image = "saladdish.png",    Label = "Havuç Salatası",    Calorie = "88 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[2],Ingredients.ing[17], Ingredients.ing[11] } },

            new Food{ID = 15,    Image = "meal.png",    Label = "Kızarmış Yumurta",    Calorie = "121 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[6],Ingredients.ing[13] } },

            new Food{ID = 16,    Image = "meal.png",    Label = "Omlet",    Calorie = "101 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[6], Ingredients.ing[13], Ingredients.ing[8], } },

            new Food{ID = 17,    Image = "meal.png",    Label = "Güveç",    Calorie = "148 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[24],Ingredients.ing[13] } },

            new Food{ID = 18,    Image = "meal.png",    Label = "Orman Kebabı",    Calorie = "256 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[2],Ingredients.ing[13]
            ,Ingredients.ing[12] , Ingredients.ing[16] ,Ingredients.ing[14]} },

            new Food{ID = 19,    Image = "meal.png",    Label = "Patlıcan Musakka",    Calorie = "131 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[23],Ingredients.ing[12] } },

            new Food{ID = 20,    Image = "dessert.png",    Label = "Elmalı Turta",    Calorie = "442 kcal"
            ,ingredients = new List<Ingredient>{ Ingredients.ing[0],Ingredients.ing[8],Ingredients.ing[26] } },
            
        };

        public Foods()
        {

        }
    }
}
