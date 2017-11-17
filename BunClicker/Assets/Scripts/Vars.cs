using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Tracks and holds all variables.
*/
public static class Vars {

    private static int numBuns = 0;
    private static float BunsPerSec = 0;
    private static int BunsPerClick = 1;

    public static int getNumBuns()
    {
        return numBuns;
    }

    public static int getBunsPerClick()
    {
        return BunsPerClick;
    }

    public static void addBuns(int x)
    {
        numBuns += x;
    }
	
}
