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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Define.main_scene)
        {
            Managers.UI.ClosePopupUI();
            Managers.UI.ShowPopupUI<UI_Popup>("Main/Main-Init-2");
        }
    }

    public override void Clear()
    {
        
    }

    public void inSetting()
    {
        Managers.UI.ClosePopupUI();
        Managers.UI.ShowPopupUI<UI_Popup>("Main/Main-Setting");
    }

}
