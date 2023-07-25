using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript2 : Shape
{
    public Material shape2Material;
    
    private void Update()
    {
          DisplayText();
          
    }

    protected override void DisplayText()
    {
        base.DisplayText();
        if (isTriggered)
        {        
                NewColor();                 
        }
    }

    

    void NewColor()
    {
        shape2Material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        
    }
}
