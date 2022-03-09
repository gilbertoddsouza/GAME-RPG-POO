using POO_jogo_rpg.src.Enums;

namespace POO_jogo_rpg.src.Entities {
    public class Ninja : Character  {
        public Ninja(string name):base(name) {
            this.CharacterType = CharacterTypes.Ninja;
            this.Mana = 4;
            this.Life = 10;
            this.multiplierLife = 8;
            this.multiplierMana = 5;            
        }

        public override string Attack() {
            return $"{this.Name}  Attacked with his katana.";
        }
    }
}