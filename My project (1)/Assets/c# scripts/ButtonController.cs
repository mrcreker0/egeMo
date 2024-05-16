using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public TextMeshProUGUI answerText; // Ссылка на текстовый элемент, где будет отображаться ответ
    private int answer = 0; // Начальное значение ответа

    public void OnButtonClick()
    {
        // Получаем текст кнопки, который должен быть цифрой
        string buttonText = GetComponentInChildren<Text>().text;

        // Пробуем преобразовать текст в целое число
        int number;
        bool isNumber = int.TryParse(buttonText, out number);

        if (isNumber)
        {
            // Если текст кнопки - цифра, то добавляем её к ответу
            answer += number;
        }
        else
        {
            // Если текст кнопки не является цифрой, выводим сообщение об ошибке
            Debug.LogError("Button text is not a number!");
        }

        // Обновляем отображение ответа
        UpdateAnswerText();
    }

    private void UpdateAnswerText()
    {
        // Обновляем текстовый элемент с ответом
        answerText.text = answer.ToString();
    }
}
