using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript1 : Shape
{
    protected override void DisplayText()
    {
        base.DisplayText();
        if (isTriggered)
        {
            shapeText.text = null;
            shapeText.text = "You clicked on the 1 shape";
            StartCoroutine(Timer());
        }
    }

    private void Update()
    {
        DisplayText();
    }

    IEnumerator Timer()
    { 
        yield return new WaitForSeconds(1f);
        shapeText.text = null;
        shapeText.gameObject.SetActive(false);
    }
}
