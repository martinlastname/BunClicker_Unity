using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipHandler : MonoBehaviour {

    public UnityEngine.UI.Text tooltip;

    private Vector2 offset = new Vector2(110, -15);
    private Vector2 restOffset = new Vector2(400, -400);

    private bool isEnabled = false;
    private string tooltipText = "";

    void Update()
    {

        if (isEnabled)
        {
            tooltip.text = tooltipText;
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.position = Vector2.Lerp(transform.position, mousePosition + offset, 1f);
        }

        else
        {
            tooltip.text = "";
            transform.position = new Vector2(-100, -100);
        }
        
    }

    public void setText(string s)
    {
        tooltipText = s;
    }

    public void enable()
    {
        isEnabled = true;
    }

    public void disable()
    {
        isEnabled = false;
    }

    public Vector2 tooltipPosition()
    {
        return transform.position;
    }

    public float getWidth()
    {
        return GetComponent<RectTransform>().rect.width;
    }

    public float getHeight()
    {
        return GetComponent<RectTransform>().rect.height;
    }

    public bool getEnabled()
    {
        return isEnabled;
    }

    
}
