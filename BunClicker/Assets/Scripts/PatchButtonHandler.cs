using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text patchText;

    void Start()
    {
        patchText.text = Text.STR_PATCH_BUTTON + "\n"
            + string.Format(Text.STR_COST_CAR, Vars.Patches.getPatchCost()) + "\n"
            + string.Format(Text.STR_NUM_PATCH, Vars.Patches.getNumPatches());
    }

    void Update()
    {
        patchText.text = Text.STR_PATCH_BUTTON + "\n"
            + string.Format(Text.STR_COST_CAR, Vars.Patches.getPatchCost()) + "\n"
            + string.Format(Text.STR_NUM_PATCH, Vars.Patches.getNumPatches());
    }

    public void onClick()
    {
        if (Vars.Carrots.getNumCarrots() >= Vars.Patches.getPatchCost())
        {
            Vars.Carrots.spendCar(Vars.Patches.getPatchCost());
            Vars.Patches.incPatch();            
        }
    }
	

	
}
