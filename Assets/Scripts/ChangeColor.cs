using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Image conditionBox;
    [SerializeField] private Color boxColor;

    private void Start()
    {
        boxColor.a = 1;
    }

    public void OnClick()
    {
        conditionBox.color = boxColor;
    }
}
