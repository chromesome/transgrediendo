using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalDemoController : MonoBehaviour
{
    public Canvas endGameCanvas;

    // Start is called before the first frame update
    void Start()
    {
        endGameCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            endGameCanvas.enabled = true;
        }
    }
}
