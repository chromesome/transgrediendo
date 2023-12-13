using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class DayController : MonoBehaviour
{   
    public bool isAtNight = false;
    public Sprite fondoNoche;
    public Sprite fondoDefault;
    ButtonCntroller ayudarbtn;
    ButtonCntroller cocinarbtn;
    ButtonCntroller Recursosbtn;

    bool ayudarbtnCumplido;
    bool recursosbtnCumplido;
    bool cocinarbtnCumplido;
    public Button botondelScript;
    public TextMeshPro textoBoton;



    // Start is called before the first frame update
    void Start()
    {
        //UiBarScript missionbtns = FindObjectOfType<UiBarScript>();  
        botondelScript.image.enabled = false;
        //textoBoton.enabled = false;

        //gameObject.SetActive(false);
        //ayudarbtn = missionbtns.btnayuda;
        //cocinarbtn = missionbtns.btncocina;
        //Recursosbtn = missionbtns.btnrecursos;  
        InitMissionButtons();
    }

    // Update is called once per frame
    void Update()
    {  
        PasarDia();        
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

    public void CambiarFondo()
    {       

        if(!isAtNight)
        {
            CambiarFondo(fondoDefault);
        }
        else
        {
            CambiarFondo(fondoNoche);
        }

    }

    public void PasarDia()
    {

        //Debug.Log("Var de Ayudarbtn: ", ayudarbtn);

        //bool ayudarbtnCumplido = ayudarbtn.objetivoCumplido;
        //bool recursosbtnCumplido = Recursosbtn.objetivoCumplido;
        // bool cocinarbtnCumplido = cocinarbtn.objetivoCumplido;
        InitMissionButtons();

         ayudarbtnCumplido = ayudarbtn.objetivoCumplido;
        recursosbtnCumplido = Recursosbtn.objetivoCumplido;
        cocinarbtnCumplido = cocinarbtn.objetivoCumplido;

        if(cocinarbtnCumplido && recursosbtnCumplido && ayudarbtnCumplido)
        {           
            botondelScript.image.enabled = true;
            //textoBoton.enabled = true;    
            isAtNight = !isAtNight;
            //CambiarFondo();
            SceneManager.LoadScene("FinalDemo");            
        }

    }

    void InitMissionButtons()
    {
        if (ayudarbtn == null || Recursosbtn == null || cocinarbtn == null)
        {
            UiBarScript missionbtns = FindObjectOfType<UiBarScript>();

            ayudarbtn = missionbtns.btnayuda;
            cocinarbtn = missionbtns.btncocina;
            Recursosbtn = missionbtns.btnrecursos;
        }
    }
}
