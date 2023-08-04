public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    // public Enemy(string name, int health, List<Attack> attackList){
    public Enemy(string name, int health){
        Name = name;
        Health = health;
        AttackList = new List<Attack>();

    }

    public void RandomAttack()
    {
        Random random = new Random();
        Console.WriteLine(AttackList[random.Next(0, AttackList.Count)].AttackName);
    }

    public void AddToAttackList(Attack newAttack )
    {
        AttackList.Add(newAttack);
    
    }
}