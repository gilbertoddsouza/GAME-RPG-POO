using POO_jogo_rpg.src.Enums;

namespace POO_jogo_rpg.src.Entities {
    public class Wizzard : Character {
        public Wizzard(string name):base(name) {
            this.CharacterType  = CharacterTypes.BlackWizzard;
            this.Life           = 8;
            this.Mana           = 10;
            this.multiplierLife = 6;
            this.multiplierMana = 10;
        }

        public override string Attack() {
            return $"{this.Name} attacked with a black magic.";
        }  

        public string Attack( int bonus) {
            if (bonus > 6) {
              return $"{this.Name} attacked with a black magic plus bonus {bonus}. Super effective attack!!";
            } else {
              return $"{this.Name} attacked with a black magic plus bonus {bonus}";
            }
        }                 
    }
}