using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    [field: SerializeField]
    PileOfObjects ViewingPile { get; set; }
    AudioSource mNextButton;

    // Start is called before the first frame update
    void Start()
    {
        mNextButton = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClicked()
    {
        ViewingPile.NextPage();
        mNextButton.Play();
    }
}
