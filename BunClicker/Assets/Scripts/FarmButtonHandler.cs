using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text farmButtonText;

    void Start()
    {
        farmButtonText.text = Text.STR_FARM_BUTTON + "\n"
            + string.Format(Text.STR_COST_BUNS, Vars.Farms.getFarmCost()) + "\n"
            + string.Format(Text.STR_NUM_FARM, Vars.Farms.getNumFarms());
    }
	
    void Update()
    {
        farmButtonText.text = Text.STR_FARM_BUTTON + "\n"
            + string.Format(Text.STR_COST_BUNS, Vars.Farms.getFarmCost()) + "\n"
            + string.Format(Text.STR_NUM_FARM, Vars.Farms.getNumFarms());
    }

    public void onClick()
    {
        if (Vars.Buns.getNumBuns() >= Vars.Farms.getFarmCost())
        {
            Vars.Buns.spendBuns(Vars.Farms.getFarmCost());
            Vars.Farms.incFarm();
        }
    }
}
