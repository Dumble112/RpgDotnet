namespace rpg.src.Entties
{
    public class Wizard : Hero
    {
        public Wizard(string name,int level,string heroType)
        {
            this.name = name;
            this.level= level;
            this.heroType= heroType;
        }
        public override string Attack(){
            return this.name +" "+" Lançou magia";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
               return this.name + " Lançou magia forte com bonus de " + Bonus;
        }else{
            return this.name +" Lançou uma magia com força fraca com bonus de "+Bonus;
        }
    } 
        
    }
}