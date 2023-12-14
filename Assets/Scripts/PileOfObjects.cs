using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PileOfObjects : MonoBehaviour
{

    [field: SerializeField]
    Canvas ArchiveCanvas;

    [field: SerializeField]
    TextMeshProUGUI DescriptionText { get; set; }

    [field: SerializeField]
    Image imagenPrincipal { get; set; }

    
    [field: SerializeField]
    List<InteractiveObject> objectsInPile { get; set; }

    int currentPage = 0;
    AudioSource PileAudioSource;

    private UiBarScript misionestbtn;

    // Start is called before the first frame update
    void Start()
    {
       
        PileAudioSource = GetComponent<AudioSource>();
        ArchiveCanvas.enabled = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            
            Vector3 hitCoord= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(hitCoord, Vector2.zero);

            if(hit.collider != null)
            {
                //misionestbtn = FindObjectOfType<UiBarScript>();
                //if(misionestbtn.MisionActiva(0) == false || misionestbtn.MisionCompleta(0) == true)
                {
                    print("lepegaste a algo: " + hit.collider.name);
                    if (hit.collider.tag.Equals("fotos"))
                    {
                        if(objectsInPile[currentPage].ManipularObjetoAudio != null && !PileAudioSource.isPlaying)
                        {
                            PileAudioSource.clip = objectsInPile[currentPage].ManipularObjetoAudio;
                            PileAudioSource.Play();
                        }
                        print("apretaste la fila de fotos");
                        currentPage = 0;
                        imagenPrincipal.sprite = objectsInPile[currentPage].ImagenPrincipal;
                        DescriptionText.SetText(objectsInPile[currentPage].TextoPrincipal);


                        ArchiveCanvas.enabled = true;
                    }
                    else if (hit.collider.tag.Equals("audios"))
                    {
                        print("apretaste la reproductora");
                        if (objectsInPile[currentPage].AudioPrincipal != null && !PileAudioSource.isPlaying)
                        {
                            PileAudioSource.clip = objectsInPile[currentPage].AudioPrincipal;
                            PileAudioSource.Play();
                        }
                    }
                }
                

            }

        }
    }

    public void NextPage()
    {
        currentPage++;
        if(currentPage <objectsInPile.Count)
        {
            imagenPrincipal.sprite = objectsInPile[currentPage].ImagenPrincipal;
            DescriptionText.SetText(objectsInPile[currentPage].TextoPrincipal);
        }
        else
        {
            ArchiveCanvas.enabled = false;

        }
    }

}
