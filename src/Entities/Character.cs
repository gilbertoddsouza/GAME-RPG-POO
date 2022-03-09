using POO_jogo_rpg.src.Enums;

namespace POO_jogo_rpg.src.Entities {
    public abstract class Character {

        public string Name {get; protected set;}
        public int Level {get; protected set;}
        public int Life {get; protected set;}
        public int Mana {get; protected set;}
        protected int multiplierLife;
        protected int multiplierMana;

        public CharacterTypes CharacterType {get; protected set;}

        public Character (string name) {
            this.Name   = name;
            this.Level  = 1;
        } 
        public override string ToString() {
            return  $"Name: {this.Name}  level: {this.Level}  type: {this.CharacterType.ToString()} mana: {this.Mana} life: {this.Life}";
        } 

        public abstract string Attack(); 

        public string levelUp(){
            this.Level++;
            this.Mana += multiplierMana;
            this.Life += multiplierLife;            
            return $"{this.Name}  advanced to the level {this.Level}";
        }        
    }
}