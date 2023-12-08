using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
