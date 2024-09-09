using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Init : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(NextPrefab());
        }
    }

    IEnumerator NextPrefab()
    {
        yield return new WaitForSeconds(1.5f);

        Managers.UI.ClosePopupUI();
        Managers.UI.ShowPopupUI<UI_Popup>("Main/Main-Init-2");
    }
}
