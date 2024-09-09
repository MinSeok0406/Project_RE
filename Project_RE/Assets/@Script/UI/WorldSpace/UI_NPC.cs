using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_NPC : UI_Base
{
    enum NPCs
    {
        NPC,
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(NPCs));
    }

    void Update()
    {
        Transform parent = transform.parent;
        transform.position = parent.position + Vector3.right;
        transform.rotation = Camera.main.transform.rotation;

        if (transform.parent.Find("UI_NPC_Text") != null)
        {
            return;
        }
    }
}
