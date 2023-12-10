using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mManagerOutside : MonoBehaviour
{
    string nombreObjeto;
    public bool candadoabierto = false;
    public AudioClip woosh;
    public AudioClip noche;
    public AudioClip dia;

    AudioSource mOutside;

    DayController dayController;


    // Start is called before the first frame update
    void Start()
    {
        dayController = FindObjectOfType<DayController>();
        mOutside = GetComponent<AudioSource>();
        mOutside.PlayOneShot(woosh);
        mOutside.PlayOneShot(noche);
        Debug.Log(mOutside.clip.length);

        

    }
    
    // Update is called once per frame
    void Update()
    {
        // Verifica si se ha hecho clic con el bot�n izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Obtiene la posici�n del puntero en el espacio del mundo
            Vector2 punteroPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Lanza un rayo desde la posici�n del puntero en direcci�n hacia la derecha
            RaycastHit2D hit = Physics2D.Raycast(punteroPos, Vector2.right);

            // Verifica si el rayo golpea un objeto
            if (hit.collider != null)
            {
                //if (hit.collider.GetType().typeof<GameMenuManager>()) chequear que le pegamos a GameMenuManager para que no tire error de que otros objetos no son escena
                {
                    Debug.Log("Cambio de cuarto");
                    
                    mOutside.Stop();
                 


                }
            }
        }
    }
    /*
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