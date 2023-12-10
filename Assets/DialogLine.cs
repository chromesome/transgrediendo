using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogLine : MonoBehaviour
{

    [field: SerializeField]
    public Sprite CharacterImage { get; set; }

    [field: SerializeField]
    public string CharacterDialog { get; set; }

    [field: SerializeField]
    public string CharacterName { get; set; }

    [field: SerializeField]
    public Color BackgroundColor { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
