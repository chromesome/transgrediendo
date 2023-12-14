using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchiveAudioItem : MonoBehaviour
{

    [field: SerializeField]
    List<InteractiveObject> objectsInPile { get; set; }

    AudioSource PileAudioSource;

    private UiBarScript misionestbtn;

    // Start is called before the first frame update
    void Start()
    {

        PileAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Vector3 hitCoord = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(hitCoord, Vector2.zero);

            if (hit.collider != null)
            {
                //misionestbtn = FindObjectOfType<UiBarScript>();
                //if(misionestbtn.MisionActiva(0) == false || misionestbtn.MisionCompleta(0) == true)
                {
                    print("lepegaste a algo: " + hit.collider.name);
                    if (hit.collider.tag.Equals("audios"))
                    {
                        print("apretaste la reproductora");
                        if (this.objectsInPile[0].AudioPrincipal != null && !PileAudioSource.isPlaying)
                        {
                            PileAudioSource.clip = this.objectsInPile[0].AudioPrincipal;
                            PileAudioSource.Play();
                        }
                    }
                }


            }

        }
    }
}
