using System.Threading.Tasks.Dataflow;
namespace rpgCSharp.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Type Type { get; set; }

        public Wizard Wizard { get; set; }

        private int Health;

        public Hero() {
            this.Health = 99;
            this.Wizard = new Wizard();

        }

        public Hero(string name, int level, Type type)
        {
            this.Name = name;
            this.Level = level;
            this.Type = type;
            this.Health = 99;
            this.Wizard = new Wizard();

        }

        public void LevelUp() {
            this.Level++;
        }

        public void LevelDown()
        {
            this.Level--;
        }

        public void HealthUp(){
            if(this.Health < 99){
                this.Health++;
            }
        }

        public void HealthDown()
        {
            if (this.Health > 0)
            {
                this.Health--;
            }
        }

        public void Recovery(Hero hero)
        {
            this.LevelUp();
            this.HealthUp();
        }

        public void Damage(Hero hero)
        {
            this.LevelDown();
            this.HealthDown();
        }

        public string Attack(Hero opponent){
            this.Damage(opponent);
            this.Wizard.BonusAdd(15);
            return this.Wizard.BonusMessage();
        }

        public override string ToString() {
            return $"My Hero: {this.Name}\nLevel: {this.Level}\nType: {this.Type.ToString()}";
        }
    }
}