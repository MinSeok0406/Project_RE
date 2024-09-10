using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

// UI Text 깜빡임 효과
public class BlinkAnim : MonoBehaviour
{
    Text flashingText;

    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(0.3f);
            flashingText.text = "아무 키나 눌러주세요";
            yield return new WaitForSeconds(1.0f);
        }
    }
}
