using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiBarScript : MonoBehaviour
{


    private static UiBarScript _instance;

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
}
