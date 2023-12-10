using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiBarScript : MonoBehaviour
{


    private static UiBarScript _instance;
    public ButtonCntroller btnayuda;
    public ButtonCntroller btnrecursos;
    public ButtonCntroller btncocina;
    
    public static UiBarScript Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UiBarScript>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    _instance = go.AddComponent<UiBarScript>();
                }
            }
            return _instance;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool MisionActiva( int numeroMision)
    {
        //pasar numero entre 0 y 2 gili
        if(numeroMision == 0)
        {
            return btnrecursos.objetivoActivo;
        }
        else if(numeroMision == 1)
        {
             return btnayuda.objetivoActivo;
        }
        else  if(numeroMision == 2)
        {
             return btncocina.objetivoActivo;
        }

        return false;
    }

    public bool MisionCompleta( int numeroMision)
    {
        //pasar numero entre 0 y 2 gili
        if(numeroMision == 0)
        {
            return btnrecursos.objetivoCumplido;
        }
        else if(numeroMision == 1)
        {
             return btnayuda.objetivoCumplido;
        }
        else  if(numeroMision == 2)
        {
             return btncocina.objetivoCumplido;
        }

        return false;
    }

    public void ActivarMision(int numeroMision)
    {
        if(numeroMision == 0)
        {
            btnrecursos.objetivoActivo = true;
        }
        else if(numeroMision == 1)
        {
            btnayuda.objetivoActivo = true;
        }
        else  if(numeroMision == 2)
        {
            btncocina.objetivoActivo = true;
        }
    }

    public void CompletarMision(int numeroMision)
    {
        if(numeroMision == 0)
        {
            btnrecursos.objetivoCumplido = true;
        }
        else if(numeroMision == 1)
        {
            btnayuda.objetivoCumplido = true;
        }
        else  if(numeroMision == 2)
        {
             btncocina.objetivoCumplido = true;
        }
    }
}
