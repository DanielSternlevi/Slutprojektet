using System;

public class john : characterinfo
{
    public john()
    {
        Console.WriteLine("You chose John");
        isstrong = true;
        health = 25;

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

}