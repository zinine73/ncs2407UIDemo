using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private TextMeshProUGUI orderText;

    private string coffee;
    private string bean;
    private int ice;

    // Start is called before the first frame update
    void Start()
    {
        coffee = "에스프레소";
        bean = dropdown.captionText.text;
        ice = 0;
        slider.minValue = 0;
        slider.maxValue = 100;
    }

    public void OnSliderMoved()
    {
        ice = (int)slider.value;
        inputField.text = ice.ToString();
    }

    public void OnInputFieldChanged()
    {
        ice = Convert.ToInt32(inputField.text);
        slider.value = ice;
    }

    public void OnOrderBtnClicked()
    {
        orderText.text += $"주문 : {coffee}({bean})";
        if (ice > 0)
        {
            orderText.text += $" with Ice {ice}%";
        }
        orderText.text += "<br>";
    }

    public void OnDropdownChanged()
    {
        bean = dropdown.captionText.text;
    }

    public void OnToggleChanged(Text name)
    {
        coffee = name.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
