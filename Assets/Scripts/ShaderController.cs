using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();
        particleSystem.GetComponent<Renderer>().sortingOrder = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
