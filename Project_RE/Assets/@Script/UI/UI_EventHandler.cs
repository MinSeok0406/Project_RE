using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_EventHandler : MonoBehaviour, IPointerClickHandler, IDragHandler
{
    public Action<PointerEventData> OnClickHandler = null;
    public Action<PointerEventData> OnDragHandler = null;

	// 유니티에서 제공하는 메서드
	public void OnPointerClick(PointerEventData eventData)
	{
		if (OnClickHandler != null)
			OnClickHandler.Invoke(eventData);
	}

	// 유니티에서 제공하는 메서드, transform.position을 이용해 UI위치 변경 가능
	public void OnDrag(PointerEventData eventData)
    {
		if (OnDragHandler != null)
            OnDragHandler.Invoke(eventData);
	}
}
