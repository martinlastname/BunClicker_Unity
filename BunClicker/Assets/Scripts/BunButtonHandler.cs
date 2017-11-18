using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text bunButtonText;
    public TooltipHandler tooltip;

	// Use this for initialization
	void Start()
    {
        bunButtonText.text = Text.STR_BUN_BUTTON;
	}
	
	// Update is called once per frame
	void Update()
    {
        // Grammar
        if (Vars.Buns.getBunsPerClick() == 1)
        {
            bunButtonText.text = Text.STR_BUN_BUTTON;
        }		
        else
        {
            bunButtonText.text = Text.STR_BUN_BUTTON + "s";
        }
	}

    public void onClick()
    {
        if (Random.value <= (Vars.Buns.getPercentageChance()/100f)) {
            Vars.Buns.addBuns(Vars.Buns.getBunsPerClick());
        }
        else
        {

        }
    }

    public void onHover()
    {
        tooltip.setText(string.Format(Text.STR_CHANCE_BUNS, Vars.Buns.getPercentageChance()));
        tooltip.enable();
    }

    public void onExit()
    {
        tooltip.disable();
    }
}
