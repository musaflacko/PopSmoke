using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour
{

    public Text questIcon;

    public Text questName;
    // Start is called before the first frame update
    void Start()
    {
        questIcon.canvasRenderer.SetAlpha(1.0f);
        questName.canvasRenderer.SetAlpha(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        panelFade();
        openTab();

    }

    void panelFade()
    {
        questIcon.CrossFadeAlpha(0, 1, false);
        questName.CrossFadeAlpha(0, 1, false);
    }

    void openTab()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            questIcon.canvasRenderer.SetAlpha(1.0f);
            questName.canvasRenderer.SetAlpha(1.0f);
        }
    }
}
