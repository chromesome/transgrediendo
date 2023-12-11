using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mManagerLiving : MonoBehaviour
{
    string nombreObjeto;
    public bool candadoabierto = false;
    public AudioClip pasos;
    public AudioClip ambiente;


    AudioSource mLiving;

    DayController dayController;


    // Start is called before the first frame update
    void Start()
    {
        dayController = FindObjectOfType<DayController>();
        mLiving = GetComponent<AudioSource>();
        mLiving.PlayOneShot(pasos);
        mLiving.PlayOneShot(ambiente, 0.5F);
       

        

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
                    
                    mLiving.Stop();
                 


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