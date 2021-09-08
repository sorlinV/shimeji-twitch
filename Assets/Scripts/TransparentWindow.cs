using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SatorImaging.AppWindowUtility;
public class TransparentWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppWindowUtility.AlwaysOnTop = true;
        AppWindowUtility.Transparent = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
