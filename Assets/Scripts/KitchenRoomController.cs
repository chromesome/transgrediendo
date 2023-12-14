using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenRoomController : MonoBehaviour
{
    public DialogManager dialogoCocina;

    public Canvas dialogCanvas;
    private UiBarScript misionestbtn;

    // Start is called before the first frame update
    void Start()
    {
        dialogCanvas.enabled = false;

        misionestbtn = FindObjectOfType<UiBarScript>(); //GetComponent<UiBarScript>();


        SpriteRenderer lacociNera = dialogoCocina.GetComponent<SpriteRenderer>();
        
        if (misionestbtn.MisionActiva(2))
        {
            dialogoCocina.enabled = true;
            lacociNera.color = new Color(lacociNera.color.r, lacociNera.color.g, lacociNera.color.b, 1);
        }
        else
        {
            dialogoCocina.enabled = false;
            lacociNera.color = new Color(lacociNera.color.r, lacociNera.color.g, lacociNera.color.b, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
