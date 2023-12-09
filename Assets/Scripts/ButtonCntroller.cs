using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCntroller : MonoBehaviour
{

    public Button botonDefault; // boton predefinido - inactivo
    public Sprite iconoCumplido;
    public Sprite iconoActivo;
    public bool objetivoCumplido = false;
    public bool objetivoActivo = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if(objetivoCumplido == true || objetivoActivo == true) 
        {
            CambiarIcono();
        }
    }

    public void CambiarIcono()
    {
        if(objetivoCumplido)
        {
            // Accede al componente Image del botón
            Image imagenBoton = botonDefault.GetComponent<Image>();

            // Cambia la imagen del botón al nuevo icono
            if (imagenBoton != null)
            {
                imagenBoton.sprite = iconoCumplido;
            }
        }
        else if(objetivoActivo)
        {
            // Accede al componente Image del botón
            Image imagenBoton = botonDefault.GetComponent<Image>();

            // Cambia la imagen del botón al nuevo icono
            if (imagenBoton != null)
            {
                imagenBoton.sprite = iconoActivo;
            }
        }

    }
}
