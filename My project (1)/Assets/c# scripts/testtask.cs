using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpenWindowsTMP : MonoBehaviour
{
    public TMP_InputField tmpInputField;
    public GameObject window1; // окно, которое открывается при вводе 45
    public GameObject window2; // окно, которое открывается при любом другом вводе
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

        // Проверяем введенное значение
        if (input == "45")
        {
            // Открываем окно 1 и закрываем окно 2
            window1.SetActive(true);
            window2.SetActive(false);
        }
        else
        {
            // Открываем окно 2 и закрываем окно 1
            window1.SetActive(false);
            window2.SetActive(true);
        }
    }
}
