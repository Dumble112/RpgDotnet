namespace rpg.src.Entties
{
    public class Knight : Hero
    {
       public Knight(string name,int level,string heroType)
        {
            this.name = name;
            this.level= level;
            this.heroType= heroType;
        }
         public override string Attack(){
            return this.name +" "+" Atacou com sua espada";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
               return this.name + " Lançou um ataque com critico " + Bonus;
        }else{
            return this.name +" Atacou com um ataque basico "+Bonus;
        }
    } 
        
    }
}