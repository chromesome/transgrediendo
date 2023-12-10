using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class audioEscenas : MonoBehaviour
{
    string nombreObjeto;
    public bool candadoabierto = false;
 
    AudioSource mMovimiento;


    // Start is called before the first frame update
    void Start()
    {

        mMovimiento = GetComponent<AudioSource>();


    }
    /*
    // Update is called once per frame
    void Update()
    {
        // Verifica si se ha hecho clic con el botón izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Obtiene la posición del puntero en el espacio del mundo
            Vector2 punteroPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Lanza un rayo desde la posición del puntero en dirección hacia la derecha
            RaycastHit2D hit = Physics2D.Raycast(punteroPos, Vector2.right);

            // Verifica si el rayo golpea un objeto
            if (hit.collider != null)
            {
                //if (hit.collider.GetType().typeof<GameMenuManager>()) chequear que le pegamos a GameMenuManager para que no tire error de que otros objetos no son escena
                {
                    Debug.Log("Golpeó un objeto: " + hit.collider.name);
                    nombreObjeto = hit.collider.name;
                    ChangeScene(nombreObjeto);

                }
            }
        }
    }

    public void ChangeScene(string lvlName)
    {
        //Cambia la escena
        SceneManager.LoadScene(lvlName);
        if (lvlName == "Kitchen")
        {
            Debug.Log("Play Ambiente Cocina");
            mBackBtn.Play();
        }

    }

    public void QuitGame()
    {
        // Cierra el juego
        Application.Quit();
    }
    */
}
    