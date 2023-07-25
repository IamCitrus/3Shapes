using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeText;
    public bool isTriggered { get; set; } // ENCAPSULATION


    private void OnMouseDown()
    {
        isTriggered = true;
    }

    protected virtual void DisplayText()
    {
        if (isTriggered)
        {
            shapeText.text = "You clicked on the shape";
            StartCoroutine(TimerCoroutine());
        }
    }

    private void Update()
    {
        DisplayText();
    }
    protected virtual IEnumerator TimerCoroutine()
    {

        yield return new WaitForSeconds(1f);

        shapeText.text = " ";
    }
}
