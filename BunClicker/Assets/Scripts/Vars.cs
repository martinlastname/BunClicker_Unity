using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Tracks and holds all variables.
*/
public static class Vars {

    // BUNS
    private static float numBuns = 0;
    private static float bunsPerSec = 0;
    private static float bunsPerClick = 1;
    private static float baseBunsPercentChance = 1;

    // CARROTS
    private static float numCarrots = 0;
    private static float carrotsPerSec = 0;
    private static float carrotsPerClick = 1;

    // PATCHES (CARROTS)
    private static float numPatches = 0;
    private static float patchBaseCost = 10;
    private static float patchGrowthRate = 1.15F;
    private static float carrotsPerPatch = 1;

    // FARMS (BUNS)
    private static float numFarms = 0;
    private static float farmBaseCost = 10;
    private static float farmGrowthRate = 1.25f;
    private static float bunsPerFarm = 1;


    /**
    BUNS
    */
    internal static class Buns
    {
        public static int getNumBuns()
        {
            return Mathf.RoundToInt(numBuns);
        }

        public static float getBunsPerClick()
        {
            return bunsPerClick;
        }

        public static void addBuns(float x)
        {
            numBuns += x;
        }

        public static void spendBuns(int x)
        {
            numBuns -= x;
        }

        public static float getBunsPerSec()
        {
            // TODO
            return 0f;
        }

        public static float getPercentageChance()
        {
            return baseBunsPercentChance;
        }
    }

    /**
    CARROTS
    */
    internal static class Carrots
    {
        public static int getNumCarrots()
        {
            return Mathf.RoundToInt(numCarrots);
        }

        public static float getCarPerClick()
        {
            return carrotsPerClick;
        }

        public static void addCar(float x)
        {
            numCarrots += x;
        }

        public static void spendCar(float x)
        {
            numCarrots -= x;
        }

        public static float getCarPerSec()
        {
            // TODO
            return 0f;
        }
    }


    /**
    PATCHES (CARROTS)
    */
    internal static class Patches
    {
        public static int getNumPatches()
        {
            return Mathf.RoundToInt(numPatches) ;
        }

        public static void incPatch()
        {
            addPatches(1);
        }

        private static void addPatches(float x)
        {
            numPatches += x;
        }

        public static int getPatchCost()
        {
            return Mathf.RoundToInt(patchBaseCost * Mathf.Pow(patchGrowthRate, getNumPatches()));
        }

        public static float getCarrotsPerPatch()
        {
            return carrotsPerPatch;
        }

        public static float getCarrotsPerSec()
        {
            return getCarrotsPerPatch() * getNumPatches();
        }
    }
	
    /**
    FARMS (BUNS)
    */
    internal static class Farms
    {
        public static int getNumFarms()
        {
            return Mathf.RoundToInt(numFarms);
        }
        
        public static void incFarm()
        {
            addFarms(1);
        }

        private static void addFarms(float x)
        {
            numFarms += x;
        }

        public static int getFarmCost()
        {
            return Mathf.RoundToInt(farmBaseCost * Mathf.Pow(farmGrowthRate, getNumFarms()));
        }

        public static float getBunsPerFarm()
        {
            return bunsPerFarm;
        }

        public static float getBunsPerSec()
        {
            return getBunsPerFarm() * getNumFarms();
        }
    }
}
