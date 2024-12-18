using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Warlord
    {
        public string Fio {  get; set; }
        private int numberOfBattles;
        public int NumberOfBattles 
        { get => numberOfBattles;
          set 
          { 
                if (value >= 0) numberOfBattles = value; 
          } 
        }
        private int numberWins;
        public int NumberWins
        {
            get => numberWins;
            set 
            { 
                if (value >= 0) numberWins = value; 
            }
        }
        public Warlord(string fio, int numberOfBattles, int numberWins)
        {
            Fio = fio;
            NumberOfBattles = numberOfBattles;
            NumberWins = numberWins;
        }

        public virtual double GetQuality()
        {
            return (double)(numberWins*numberWins)/numberOfBattles;
        }

        public override string? ToString()
        {
            return $"ФИО {Fio}\nколичество битв {NumberOfBattles}\nколичество побед {NumberWins}\n{GetQuality()}";
        }
    }
}
