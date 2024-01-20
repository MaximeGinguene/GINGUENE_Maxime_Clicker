using UnityEngine;

public class GlobalMiner
{
    public int currentCash;
    public int minerValue = 10;
    public bool turnOffButton = false;
    public int numberOfMiners;
    public int minePerSec;

    private static GlobalMiner instance;

    private GlobalMiner() {}

    public static GlobalMiner GetInstance()
    {
        if (instance == null) instance = new GlobalMiner();
        return instance;
    }
}
