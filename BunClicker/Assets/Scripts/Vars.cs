using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Tracks and holds all variables.
*/
public static class Vars {

    // BUNS
    private static int numBuns = 0;
    private static float bunsPerSec = 0;
    private static int bunsPerClick = 1;

    // CARROTS
    private static int numCarrots = 0;
    private static float carrotsPerSec = 0;
    private static int carrotsPerClick = 1;

    // PATCHES (CARROTS)
    private static int numPatches = 0;
    private static float patchBaseCost = 10;
    private static float patchGrowthRate = 1.15F;


    /**
    BUNS
    */
    internal static class Buns
    {
        public static int getNumBuns()
        {
            return numBuns;
        }

        public static int getBunsPerClick()
        {
            return bunsPerClick;
        }

        public static void addBuns(int x)
        {
            numBuns += x;
        }

        public static float getBunsPerSec()
        {
            // TODO
            return 0f;
        }
    }

    /**
    CARROTS
    */
    internal static class Carrots
    {
        public static int getNumCarrots()
        {
            return numCarrots;
        }

        public static int getCarPerClick()
        {
            return carrotsPerClick;
        }

        public static void addCar(int x)
        {
            numCarrots += x;
        }

        public static void spendCar(int x)
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
            return numPatches;
        }

        public static void incPatch()
        {
            numPatches++;
        }

        public static int getPatchCost()
        {
            return Mathf.RoundToInt(patchBaseCost * Mathf.Pow(patchGrowthRate, getNumPatches()));
        }

        public static float getCarrotsPerSec()
        {
            // TODO
            return 0f;
        }
    }
	
}
