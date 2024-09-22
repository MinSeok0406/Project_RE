using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBlink : MonoBehaviour
{
    TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        StartCoroutine("Blink");
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            _text.text = "";
            yield return new WaitForSeconds(0.3f);
            _text.text = "아무 키나 눌러주세요";
            yield return new WaitForSeconds(1.0f);
        }
    }
}
