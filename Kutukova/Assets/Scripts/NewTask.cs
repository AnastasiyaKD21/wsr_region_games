using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Подключение библиотеки для работы с элементами пользовательского интерфейса
using UnityEngine.SceneManagement; //Подключение библиотеки для работы со сценами проекта

public class NewTask : MonoBehaviour
{
    //Возвращение в меню преподавателя
    public void Back()
    {
        SceneManager.LoadScene(2);
    }
}
