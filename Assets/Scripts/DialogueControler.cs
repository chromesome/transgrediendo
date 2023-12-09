using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogControler : MonoBehaviour
{
    public List<DilogoLinea>dialogoLineas;
    public Canvas ConetnedorDialogo;
    public TextMeshProUGUI textoAmostrar;
    public Image imagenPj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            
            Vector3 hitCoord= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(hitCoord, Vector2.zero);

            if(hit.collider != null )
            {
                print("lepegaste a algo: " + hit.collider.name);
                if (hit.collider.name.Equals("PilaDeFotos"))
                {
                    print("apretaste la fila de fotos");
                    currentPage = 0;
                    imagenPrincipal.sprite = objectsInPile[currentPage].ImagenPrincipal;
                    DescriptionText.SetText(objectsInPile[currentPage].TextoPrincipal);
                    ArchiveCanvas.enabled = true;
                }
            }

        }
    }
}
