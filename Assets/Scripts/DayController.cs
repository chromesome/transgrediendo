using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DayController : MonoBehaviour
{    public bool isAtNight = false;
    public Sprite fondoNoche;
    public Sprite fonfoDefault;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if(isAtNight == true)
        {
            CambiarFondo(fondoNoche);
        }
        else
        {
            CambiarFondo(fonfoDefault);
        }
    }

    void CambiarFondo(Sprite nuevoFondo)
    {
        // Encuentra todos los objetos en la escena con SpriteRenderer (pueden ser múltiples)
        SpriteRenderer[] renderizadores = FindObjectsOfType<SpriteRenderer>();

        // Itera sobre los objetos SpriteRenderer encontrados
        foreach (SpriteRenderer renderizador in renderizadores)
        {
            // Obtén las dimensiones del sprite actual
            Vector2 dimensionesActuales = renderizador.bounds.size;

            // Cambia el sprite al nuevo fondo
            renderizador.sprite = nuevoFondo;

            // Ajusta las dimensiones del nuevo sprite para que coincidan con las del anterior
            Vector2 dimensionesNuevas = nuevoFondo.bounds.size;
            renderizador.transform.localScale *= new Vector2(dimensionesActuales.x / dimensionesNuevas.x, dimensionesActuales.y / dimensionesNuevas.y);
        }
    }
}
