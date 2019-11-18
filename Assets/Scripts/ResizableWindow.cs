using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResizableWindow : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localPosition = text.gameObject.transform.localPosition;
        UpdateWindowSize();
    }

    void UpdateWindowSize()
    {
        gameObject.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, text.preferredHeight);
    }

    public void IncreaseTextSize()
    {
        text.fontSize++;
        UpdateWindowSize();
    }

}
