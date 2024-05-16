using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public InputField field;
    [SerializeField] TextMeshProUGUI name;

    // Строка, которую мы хотим отобразить в TextMeshPro
    public void UpdateTextMeshProText()
    {
        // Получаем текст из поля ввода
        string inputText = field.text;
        
        // Присваиваем полученный текст полю Text у объекта TextMeshProUGUI
        name.text = inputText;
    }
    

}
