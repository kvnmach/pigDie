using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack___
{
     public class Card
    {

        public enum Suit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }

        public enum Rank

        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace,
        }

        public Suit mySuit { get; set; }
        public Rank myRank { get; set; } 
        public int Value { get; set; }
        //want to extract the cards out of this class
        //want to give them a value
         private List<Card> myCards;

         public Card()
         {
             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 13; j++)
                    Card.Add(new Card){ Suit =}
             }
         }

         
         
             
         








































    }
        }
        


        
            
        
       

