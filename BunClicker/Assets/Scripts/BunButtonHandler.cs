using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text bunButtonText;

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
        Vars.Buns.addBuns(Vars.Buns.getBunsPerClick());
    }
}
