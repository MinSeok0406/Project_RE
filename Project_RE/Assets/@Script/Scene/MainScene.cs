using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        Managers.UI.ShowPopupUI<UI_Popup>("Main/Main-Init");
    }

    public override void Clear()
    {
        throw new System.NotImplementedException();
    }

    
}
