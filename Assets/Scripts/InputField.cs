using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputField : MonoBehaviour
{
    //private Text text;
    private InputField inputField;

    private GameObject textInputField;

    void Start()
    {
        // Ищем объект с именем "Text_InputField" среди дочерних объектов
        textInputField = FindChildObjectByName("Text_InputField");

        if (textInputField != null)
        {
            Debug.Log("Найден объект с именем 'Text_InputField'!");
        }
        else
        {
            Debug.Log("Объект с именем 'Text_InputField' не найден.");
        }
    }

    private GameObject FindChildObjectByName(string name)
    {
        // Ищем среди дочерних объектов
        foreach (Transform child in transform)
        {
            if (child.name == name)
            {
                return child.gameObject;
            }

            // Если объект имеет дочерние объекты, рекурсивно вызываем эту функцию для поиска
            GameObject foundObject = FindChildObjectByNameRecursive(child, name);
            if (foundObject != null)
            {
                return foundObject;
            }
        }

        return null;
    }
}
