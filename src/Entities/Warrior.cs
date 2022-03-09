using POO_jogo_rpg.src.Enums;

namespace POO_jogo_rpg.src.Entities {
    public class Warrior : Character {
        public Warrior(string name):base(name) {
            this.CharacterType = CharacterTypes.Warrior;
            this.Mana = 2;
            this.Life = 12;
            this.multiplierLife = 10;
            this.multiplierMana = 4;
        }

        public override string Attack() {
            return $"{this.Name}  Attacked with his sword.";
        }
    }
}