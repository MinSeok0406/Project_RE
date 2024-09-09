using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public abstract class UI_Base : MonoBehaviour
{
	// Type이 결정되면 그 Type들로 연결해주는 역할
	protected Dictionary<Type, UnityEngine.Object[]> _objects = new Dictionary<Type, UnityEngine.Object[]>();
	public abstract void Init();

    private void Awake()
    {
		Init();
    }

    private void Start()
	{
		
	}

	// UI 자동화, 다른 UI클래스끼리 연동
	public void Bind<T>(Type type) where T : UnityEngine.Object
	{
		// UI_Button 클래스에 있는 enum타입들을 가져오기
		string[] names = Enum.GetNames(type);

		// enum의 배열 길이를 가져와서 추가하는 부분
		UnityEngine.Object[] objects = new UnityEngine.Object[names.Length];
		_objects.Add(typeof(T), objects);


		for (int i = 0; i < names.Length; i++)
		{
			// UIManager에서 ResourceManager을 사용해 GameObject의 경로와 타입을 찾는 과정
			if (typeof(T) == typeof(GameObject))
				objects[i] = Util.FindChild(gameObject, names[i], true);
			else
				objects[i] = Util.FindChild<T>(gameObject, names[i], true);

			// 경로가 존재하지 않으면 로그를 찍음
			if (objects[i] == null)
				Debug.Log($"Failed to bind({names[i]})");
		}
	}

	// UI를 가져와서 사용하는 메서드
	protected T Get<T>(int idx) where T : UnityEngine.Object
	{
		UnityEngine.Object[] objects = null;
		if (_objects.TryGetValue(typeof(T), out objects) == false)
			return null;

		return objects[idx] as T;
	}

	protected GameObject GetObject(int idx) { return Get<GameObject>(idx); }
	public TextMeshProUGUI GetText(int idx) { return Get<TextMeshProUGUI>(idx); }
	protected Button GetButton(int idx) { return Get<Button>(idx); }
	protected Image GetImage(int idx) { return Get<Image>(idx); }
	protected Toggle GetToggle(int idx) { return Get<Toggle>(idx); }
	protected Slider GetSlider(int idx) { return Get<Slider>(idx); }

	public static void BindEvent(GameObject go, Action<PointerEventData> action, Define.UIEvent type = Define.UIEvent.Click)
	{
		UI_EventHandler evt = Util.GetOrAddComponent<UI_EventHandler>(go);

		switch (type)
		{
			case Define.UIEvent.Click:
				evt.OnClickHandler -= action;
				evt.OnClickHandler += action;
				break;
			case Define.UIEvent.Drag:
				evt.OnDragHandler -= action;
				evt.OnDragHandler += action;
				break;
		}
	}
}
