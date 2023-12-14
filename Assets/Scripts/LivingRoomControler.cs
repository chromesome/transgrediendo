using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomControler : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogManager dialogoYasmin;
    public List<Canvas> dialogCanvases;
    private UiBarScript misionestbtn;
    public PileOfObjects piladeobjetos;

    void Start()
    {
        misionestbtn = FindObjectOfType<UiBarScript>();
        misionestbtn.ActivarMision(0);        
    }

    // Update is called once per frame
    void Update()
    {
        misionestbtn = FindObjectOfType<UiBarScript>();
        if(misionestbtn.MisionActiva(0) == true && misionestbtn.MisionCompleta(0) == false)
        {
            dialogoYasmin.enabled=true;
            //piladeobjetos.enabled = false;
            //misionestbtn.CompletarMision(0);           
        }
        else
        {
            dialogoYasmin.enabled=false;
            //piladeobjetos.enabled = true;              
        }                

    }
}
