using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    [field: SerializeField]
    Canvas DialogCanvas { get; set; }

    [field: SerializeField]
    Image DialogBackground { get; set; }

    [field: SerializeField]
    Image CharacterImage { get; set; }

    [field: SerializeField]
    TextMeshProUGUI CharacterName { get; set; }

    [field: SerializeField]
    TextMeshProUGUI CharacterDialog { get; set; }

    [field: SerializeField]
    List<DialogLine> dialogLines;

    private int currentPage = 0;

    // Start is called before the first frame update
    void Start()
    {
        DialogCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if(DialogCanvas.isActiveAndEnabled)
            {
                NextPage();
            }
            else
            {
                Vector3 hitCoord = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(hitCoord, Vector2.zero);

                if (hit.collider != null)
                {
                    print("lepegaste a algo: " + hit.collider.name);
                    if (hit.collider.CompareTag("objeto"))
                    {
                        print("apretaste la al dialog manager, preparate para una charla");
                        currentPage = 0;
                        UpdateDialogData();
                        DialogCanvas.enabled = true;
                    }
                }
            }

        }
    }

    public void NextPage()
    {
        currentPage++;

        if (currentPage < dialogLines.Count)
        {
            UpdateDialogData();
        }
        else
        {
            DialogCanvas.enabled = false;

        }
    }

    private void UpdateDialogData()
    {
        //Color elcolordefondo = new Color(dialogLines[currentPage].BackgroundColor.r, dialogLines[currentPage].BackgroundColor.g, dialogLines[currentPage].BackgroundColor.b, dialogLines[currentPage].BackgroundColor.a);
        DialogBackground.color = dialogLines[currentPage].BackgroundColor;
        CharacterImage.sprite = dialogLines[currentPage].CharacterImage;
        CharacterName.SetText(dialogLines[currentPage].CharacterName);
        CharacterDialog.SetText(dialogLines[currentPage].CharacterDialog);
    }
}
