using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Model
{
    class Ingredients
    {
        public static Ingredient[] ing = new Ingredient[] 
        {
            new Ingredient{ID = 1,  Name = "Elma",   Image = "apple.png"},
            new Ingredient{ID = 2,  Name = "Tereyağ",Image = "butter.png"},
            new Ingredient{ID = 3,  Name = "Havuç",  Image = "carrot.png"},
            new Ingredient{ID = 4,  Name = "Peynir", Image = "cheese.png"},
            new Ingredient{ID = 5,  Name = "Tavuk",  Image = "chicken.png"},
            new Ingredient{ID = 6,  Name = "Sivri Biber",  Image = "chilli.png"},
            new Ingredient{ID = 7,  Name = "Yumurta",Image = "egg.png"},
            new Ingredient{ID = 8,  Name = "Balık",  Image = "fish.png"},
            new Ingredient{ID = 9,  Name = "Un",     Image = "flour.png"},
            new Ingredient{ID = 10, Name = "Sarımsak",Image = "garlic.png"},
            new Ingredient{ID = 11, Name = "Fındık", Image = "hazelnut.png"},
            new Ingredient{ID = 12, Name = "Limon",  Image = "lemon.png"},
            new Ingredient{ID = 13, Name = "Et",     Image = "meat.png"},
            new Ingredient{ID = 14, Name = "Yağ",    Image = "oil.png"},
            new Ingredient{ID = 15, Name = "Soğan",  Image = "onion.png"},
            new Ingredient{ID = 16, Name = "Dolmalık Biber",  Image = "pepper.png"},
            new Ingredient{ID = 17, Name = "Patates",Image = "potato.png"},
            new Ingredient{ID = 18, Name = "Marul",  Image = "salad.png"},
            new Ingredient{ID = 19, Name = "Tuz",    Image = "salt.png"},
            new Ingredient{ID = 20, Name = "Domates",Image = "tomato.png"},
            new Ingredient{ID = 21, Name = "Ceviz",  Image = "walnut.png"},
            new Ingredient{ID = 22, Name = "Yoğurt", Image = "yogurt.png"},
            new Ingredient{ID = 23, Name = "Ekmek",  Image = "bread.png"},
            new Ingredient{ID = 24, Name = "Patlıcan",Image = "eggplant.png"},
            new Ingredient{ID = 25, Name = "Pirinç", Image = "rice.png"},
            new Ingredient{ID = 26, Name = "Fasülye",Image = "beans.png"},
            new Ingredient{ID = 27, Name = "Süt" ,   Image = "milk.png"},
        };
        public List<Ingredient> ingredients = new List<Ingredient>();
        
        Ingredients()
        {
            ingredients.AddRange(ing);
        }

    }
}
