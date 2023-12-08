using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{

    [field: SerializeField]
    public AudioClip ManipularObjetoAudio { get; set; } // Audio reproducido al manipular el objeto

    [field: SerializeField]
    public AudioClip AudioPrincipal { get; set; }       // Audio o grabacion relacionada con el objeto

    [field: SerializeField]
    public string TextoPrincipal { get; set; }          // Texto de archivo o narrativa relacionado al objeto

    [field: SerializeField]
    public Sprite ImagenPrincipal { get; set; }         // Imagen o foto del objeto

    [field: SerializeField]
    public Sprite ImagenDeFondo { get; set; }           // Imagen que se muestra por detras de todo lo demás


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mostrar()
    {

    }
}
