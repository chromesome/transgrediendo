using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMenuManager : MonoBehaviour
{
    string nombreObjeto;
    public bool candadoabierto = false;
    private UiBarScript mainCanvas;
 

    // Start is called before the first frame update
    void Start()
    {
        mainCanvas = UiBarScript.Instance;
        mainCanvas.enabled = true;
        
    }

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
                Debug.Log("Golpeó un objeto: " + hit.collider.name);
                nombreObjeto = hit.collider.name;       
                ChangeScene(nombreObjeto);
            }
        }
    }

    public void ChangeScene(string lvlName)
    {
        //Cambia la escena
        SceneManager.LoadScene(lvlName);
    }

    public void QuitGame()
    {
        // Cierra el juego
        Application.Quit();
    }

}
