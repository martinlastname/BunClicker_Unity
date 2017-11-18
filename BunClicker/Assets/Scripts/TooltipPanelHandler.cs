using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipPanelHandler : MonoBehaviour {

    public TooltipHandler tooltip;

    private Vector2 offset = new Vector2(100, -50);

    // Use this for initialization
    void Start () {
        //GetComponent<RectTransform>().sizeDelta = new Vector2(tooltip.getWidth(), tooltip.getHeight());
        
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        transform.position = Vector2.Lerp(transform.position, mousePosition + offset, 1f);
        
    }
	
	// Update is called once per frame
	void Update () {
        //GetComponent<RectTransform>().sizeDelta = new Vector2(tooltip.getWidth(), tooltip.getHeight());

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        transform.position = Vector2.Lerp(transform.position, mousePosition + offset, 1f);

        if (tooltip.getEnabled())
        {

        }
        else
        {

        }
        
    }
}
