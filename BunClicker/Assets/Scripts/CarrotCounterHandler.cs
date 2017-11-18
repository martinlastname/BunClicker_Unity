using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCounterHandler : MonoBehaviour {

    public UnityEngine.UI.Text carCount;

    void Start()
    {
        carCount.text = string.Format(Text.STR_NUM_CAR, Vars.Carrots.getNumCarrots());

        StartCoroutine(growCarrots());
    }

    void Update()
    {
        carCount.text = string.Format(Text.STR_NUM_CAR, Vars.Carrots.getNumCarrots());
    }

    /**
    Generates carrots every second based on number of carrot patches.
    */
    IEnumerator growCarrots()
    {
        while (true)
        {
            Vars.Carrots.addCar(Vars.Patches.getCarrotsPerSec());
            yield return new WaitForSeconds(1);
        }
    }
}
