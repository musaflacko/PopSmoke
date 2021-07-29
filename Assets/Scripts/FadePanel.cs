using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour
{

    [SerializeField]
    public Text questIcon;
    // Start is called before the first frame update
    void Start()
    {
        questIcon.canvasRenderer.SetAlpha(1.0f);
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
    }

    void openTab()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            questIcon.canvasRenderer.SetAlpha(1.0f);
        }
    }
}
