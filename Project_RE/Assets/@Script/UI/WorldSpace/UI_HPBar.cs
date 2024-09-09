using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HPBar : UI_Base
{
    enum GameObjects
    {
        HPBar,
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));
    }

    private void Update()
    {
        Transform parent = transform.parent;
        transform.position = parent.position + Vector3.up * (parent.GetComponent<Collider>().bounds.size.y);
        transform.rotation = Camera.main.transform.rotation;

        if (transform.parent.Find("UI_NPC_Text") != null || transform.parent.Find("UI_Box_Text") != null || transform.parent.Find("UI_TP_Text") != null || transform.parent.Find("UI_ROKET_Text") != null)
        {
            return;
        }

    }

    public void SetHpRatio(float ratio)
    {
        GetObject((int)GameObjects.HPBar).GetComponent<Slider>().value = ratio;
    }

}