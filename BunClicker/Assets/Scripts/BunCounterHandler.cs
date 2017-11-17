using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunCounterHandler : MonoBehaviour
{
    public UnityEngine.UI.Text bunCount;

    void Start()
    {
        bunCount.text = string.Format(Text.STR_NUM_BUNS, Vars.Buns.getNumBuns());
    }

    void Update()
    {
        bunCount.text = string.Format(Text.STR_NUM_BUNS, Vars.Buns.getNumBuns());
    }

}
