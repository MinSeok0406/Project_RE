using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Popup
{
    enum Buttons
    {
        
    }

    public enum Texts
    {
        GoldText,
    }

    enum GameObjects
    {
        
    }

    enum Images
    {
        
    }

    public override void Init()
    {
        base.Init();

        Bind<Button>(typeof(Buttons));
		Bind<Text>(typeof(Texts));
		Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));

        //GetText((int)Texts.GoldText).text = $"Gold : {_stat.Gold}";
        //GetButton((int)Buttons.PointButton).gameObject.BindEvent(OnButtonClicked);

        // Images을 뽑아오고 GameObject에 집어넣는 과정
        //GameObject go = GetImage((int)Images.ItemIcon).gameObject;

        // 람다식 문법 : (입력 파라미터) => { 실행문장 블럭 };
        // 입력 파라미터 : (PointerEventData data)
        // 실행문장 : go.transform.position = data.position
        // UI을 드래그하기 위한 메서드 실행
        //BindEvent(go, (PointerEventData data) => { go.transform.position = data.position; }, Define.UIEvent.Drag);
    }

    /*int _score = 0;*/

    /*public void OnButtonClicked(PointerEventData data)
    {
        _score++;
        GetText((int)Texts.ScoreText).text = $"점수 : {_score}";
    }*/

    public override void ClosePopupUI()
    {
        base.ClosePopupUI();
    }

}
