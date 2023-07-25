using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript1 : Shape //INHERITANCE
{
    protected override void DisplayText() // POLYMORPHISM
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
        DisplayText(); // ABSTRACTION
    }

    IEnumerator Timer()
    { 
        yield return new WaitForSeconds(1f);
        shapeText.text = null;
        shapeText.gameObject.SetActive(false);
    }
}
