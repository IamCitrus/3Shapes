using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript3 : Shape
{
    
    public Material Shape3Material;

    private void Update()
    {
        DisplayText();
    }
    protected override void DisplayText()
    {
        base.DisplayText();
        if(isTriggered)
        {
            Shape3Material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }
    }
}
