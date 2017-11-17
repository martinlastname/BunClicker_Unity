using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text bunButtonText;

	// Use this for initialization
	void Start ()
    {
        bunButtonText.text = Text.STR_BUN_BUTTON;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Grammar
        if (Vars.getBunsPerClick() == 1)
        {
            bunButtonText.text = Text.STR_BUN_BUTTON;
        }		
        else
        {
            bunButtonText.text = Text.STR_BUN_BUTTON_P;
        }
	}

    public void clicked ()
    {
        Vars.addBuns(Vars.getBunsPerClick());
    }
}
