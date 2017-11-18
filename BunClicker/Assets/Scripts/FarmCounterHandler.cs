using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmCounterHandler : MonoBehaviour {

    public UnityEngine.UI.Text farmCounterText;

    void Start()
    {
        farmCounterText.text = string.Format(Text.STR_NUM_FARM, Vars.Farms.getNumFarms());
    }

    void Update()
    {
        farmCounterText.text = string.Format(Text.STR_NUM_FARM, Vars.Farms.getNumFarms());
    }
	
}
