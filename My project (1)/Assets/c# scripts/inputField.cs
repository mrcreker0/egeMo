// // inputField
using UnityEngine;
using UnityEngine.UI;

public class inputField : MonoBehaviour
{
    // Ссылка на компонент Text
    public Text textField;

    // Функция для получения текста
    public string GetText()
    {
        return "Привет, мир!"; // Здесь может быть ваш текст
    }

    // Функция для вывода текста на поле
    public void DisplayText()
    {
        // Установка текста компонента Text равным тексту из GetText()
        textField.text = GetText();
    }
}


