using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class WarlordSuper:Warlord
    {
        private int numberSuperWin;
        public int NumberSuperWin
        {
            get => numberSuperWin;
            set
            {
                if (value >= 0 && value < NumberOfBattles) 
                    numberSuperWin = value;
            }
        }
        public WarlordSuper(string fio, int numberOfBattles, int numberWins, int _numberSuperWin) : base (fio, numberOfBattles, numberWins)
        {
            numberSuperWin = _numberSuperWin;
        }

        public override double GetQuality()
        {
            return (NumberSuperWin*NumberSuperWin/NumberOfBattles) + base.GetQuality();
        }

        public override string? ToString()
        {
            return $"ФИО {Fio}\nколичество битв {NumberOfBattles}\nколичество побед {NumberWins}\nколичество побед с превосходящими силами {NumberSuperWin}\nкоэффициент{GetQuality()}";
        }
    }
}
