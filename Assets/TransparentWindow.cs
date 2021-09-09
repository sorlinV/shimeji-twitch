using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SatorImaging.AppWindowUtility;
using UnityEngine.UI;

public class TransparentWindow : MonoBehaviour
{
    Text debugger;
    void Start()
    {
        debugger = GameObject.Find("debugger").GetComponent<Text>();
        AppWindowUtility.AlwaysOnTop = true;
        AppWindowUtility.Transparent = true;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            AppWindowUtility.ClickThrough = false;
            if(debugger) debugger.text = objectHit.gameObject.name + "is hit";
            // Do something with the object that was hit by the raycast.
        }
        else
        {
            AppWindowUtility.ClickThrough = true;
            if (debugger) debugger.text = "nothing is hit";
        }
    }
}
