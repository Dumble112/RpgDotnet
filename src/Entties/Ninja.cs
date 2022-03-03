namespace rpg.src.Entties
{
    public class Ninja : Hero
    {
         public Ninja(string name,int level,string heroType)
        {
            this.name = name;
            this.level= level;
            this.heroType= heroType;
        }
        public override string Attack(){
            return this.name +" "+" Atacou com sua kunai";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
               return this.name + " Lançou uma kunai extra " + Bonus;
        }else{
            return this.name +" Lançou uma shuriken "+ Bonus;
        }
    } 
        
    }
}
