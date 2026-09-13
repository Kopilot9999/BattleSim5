public class Character{
    public string Name{get; set;}
    public int Health{get; set;}
    public int Level{get; set;}
    
    public Character(string name, int health, int level){
        Name = name;
        Health = health;
        Level = level;
        
    }}
    
    public class Warrior : Character{
        public int Armor;
        public Warrior(string name, int health, int level, int armor)
            : base(name, health, level)
        {
            Armor = armor;
        }
        public void ShieldBlock(){
            Armor -=20;
            Console.WriteLine("Ви заблокували атаку");
        }
    }

public class Mage : Character{
    public int Mana;
    public Mage(string name, int health, int level, int mana)
    : base(name, health, level)
    {
        Mana = mana;
    }
    public void CastHeal(){
        Mana -=20;
        Health +=20;
    }
}
public class Archer : Character{
    public int ArrowCount;
    public Archer(string name, int health, int level, int arrowcount)
    : base(name, health, level)
    {
        ArrowCount = arrowcount;
    }
    public void ShootDoubleArrow(){
        ArrowCount -=2;
        Console.WriteLine("Ви вистрелили дві стріли");
    }
}

class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior("Гром", 120, 5, 50);
        Mage mage = new Mage("Гендальф", 80, 7, 100);
        Archer archer = new Archer("Леголас", 90, 6, 20);
        
        warrior.ShieldBlock();
        mage.CastHeal();
        archer.ShootDoubleArrow();
    }
}

    
    
