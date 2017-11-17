using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCounterHandler : MonoBehaviour {

    public UnityEngine.UI.Text carCount;

    void Start()
    {
        carCount.text = string.Format(Text.STR_NUM_CAR, Vars.Carrots.getNumCarrots());
    }

    void Update()
    {
        carCount.text = string.Format(Text.STR_NUM_CAR, Vars.Carrots.getNumCarrots());
    }
}
