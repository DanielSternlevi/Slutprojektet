using System;

public class john : characterinfo
{
    public john()
    {
        Console.WriteLine("You chose John");
        isstrong = true;
        health = 25;
        int RandomDamage = SetRandomDamage();
    }
    public void johntakesd()
    {
        Random generator = new Random();
        int rando = generator.Next(6);
        health -= rando;

        if (health < 0)
        {
            health = 0;
        }

    }
    public int SetRandomDamage()
    {
        Random random = new Random();
        int damage = random.Next(1, 6);
        return damage;
    }

}