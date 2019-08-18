using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InputExtender;

public class Tester : MonoBehaviour
{

    public Text doubleClick;
    public Text longClick;

    private int dblClk;
    private int lngClick;


    private void Update()
    {
        if (Mouse_Extender.IsLongClick(0))
        {
            lngClick += 1;
            longClick.text = "Long Clicked: " + lngClick.ToString() + " times";
        }

        if (Mouse_Extender.IsDoubleClick(0))
        {
            dblClk += 1;
            doubleClick.text = "Double Clicked: " + dblClk.ToString() + " times";
        }

        if (Key_Extender.IsLongKeyPress(KeyCode.J))
        {
            Debug.Log("Long key press!!!");
        }

        if (Key_Extender.IsDoublekeyPress(KeyCode.L))
        {
            Debug.Log("Double key press!!!!");
        }

    }
}
