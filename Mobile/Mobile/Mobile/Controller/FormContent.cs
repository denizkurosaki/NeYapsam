using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Controller
{
    class FormContent
    {
        public static Content GetContent()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Havuç" ,"carrot.png"));
            cards.Add(new Card("Havuç", "carrot.png"));
            cards.Add(new Card("Havuç", "carrot.png"));
            cards.Add(new Card("Havuç", "carrot.png"));
            cards.Add(new Card("Havuç", "carrot.png"));
            return new Content(cards);
        }
    }
}
