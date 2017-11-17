using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotButtonHandler : MonoBehaviour {

    public UnityEngine.UI.Text carButtonText;

	// Use this for initialization
	void Start() {
        carButtonText.text = Text.STR_CAR_BUTTON;
	}
	
	// Update is called once per frame
	void Update() {
        
        if (Vars.Carrots.getCarPerClick() == 1)
        {
            carButtonText.text = Text.STR_CAR_BUTTON;
        }
        else
        {
            carButtonText.text = Text.STR_CAR_BUTTON + "s";
        }
	}

    public void onClick()
    {
        Vars.Carrots.addCar(Vars.Carrots.getCarPerClick());
    }
}
