using System;

public class Player
{
    public static Random random = new Random();
    
    public int RollDie()
    {
        return random.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return random.NextDouble() * 100;
    }
}
