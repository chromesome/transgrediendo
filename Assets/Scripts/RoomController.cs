using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomController : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogManager dialogoVieja01;
    public DialogManager dialogoVieja02;
    private UiBarScript misionestbtn;

    void Start()
    {
        misionestbtn = GetComponent<UiBarScript>();


        Debug.Log("misionestbtn.MisionCompleta(0)" + misionestbtn);
        if(misionestbtn.MisionCompleta(0) == true && misionestbtn.MisionActiva(1) == true)
        {
            dialogoVieja02.enabled = true;
            dialogoVieja01.enabled = false;
            
        }
        else
        {
            dialogoVieja01.enabled = true;
            dialogoVieja02.enabled = false;
        }            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
