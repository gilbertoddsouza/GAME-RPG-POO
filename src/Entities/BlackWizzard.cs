using POO_jogo_rpg.src.Enums;

namespace POO_jogo_rpg.src.Entities {
    public class BlackWizzard : Character {
        public BlackWizzard(string name):base(name) {
            this.CharacterType = CharacterTypes.Wizzard;
            this.Life          = 8;
            this.Mana          = 10;
            this.multiplierLife = 6;
            this.multiplierMana = 10;                        
        }

        public override string Attack() {
            return $"{this.Name} attacked with a magic.";
        }           
    }
}