using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedController : MonoBehaviour
{
    public Sprite spriteDesbloqueado;
    public Sprite spriteBloqueado;   
    public bool locked = true;         

    void Start()
    {   
    }

    void Update()
    {        
        CambiarSpriteSegunEstado();
    }

    void CambiarSpriteSegunEstado()
    {
        // Obtiene el componente SpriteRenderer del objeto
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Verifica si el objeto está bloqueado
        if (locked)
        {
            // Cambia el sprite al sprite bloqueado
            if (spriteRenderer != null)
            {
                spriteRenderer.sprite = spriteBloqueado;
            }
        }
        else
        {
            // Cambia el sprite al sprite desbloqueado
            if (spriteRenderer != null)
            {
                spriteRenderer.sprite = spriteDesbloqueado;
            }
        }
    } 
}
