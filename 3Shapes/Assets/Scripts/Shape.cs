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
    protected bool isTriggered = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        isTriggered = true;
    }

    protected virtual void DisplayText()
    {
        if (isTriggered)
        {
            shapeText.SetText("You clicked on the shape");
        }
    }
}
