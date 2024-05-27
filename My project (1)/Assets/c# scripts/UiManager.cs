using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public TMP_InputField tmpInputField;
    public TMP_Text outputText; // TMP Text элемент для отображения текста
    public Button submitButton; // кнопка для подтверждения ввода

    void Start()
    {
        // Добавляем слушатель для кнопки
        submitButton.onClick.AddListener(OnSubmitButtonClicked);
    }

    void OnSubmitButtonClicked()
    {
        // Получаем введенное значение из TMP Input Field
        string input = tmpInputField.text;

        // Переносим текст в TMP Text элемент
        outputText.text = input;
    }
}
