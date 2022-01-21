using System.Globalization;
namespace rpgCSharp.src.Entities
{
    public class Wizard
    {
        public int Bonus { get; set; }

        public string BonusMessage() {
            return $"Ganhou {this.Bonus} pontos";
        }

        public int BonusAdd(int bonus)
        {
            return this.Bonus += bonus;
        }

        public int BonusSub(int bonus)
        {
            return this.Bonus -= bonus;
        }

        public Wizard()
        {
            this.Bonus = 10;
        }
    }
}