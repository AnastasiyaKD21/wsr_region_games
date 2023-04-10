using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Подключение библиотеки для работы с элементами пользовательского интерфейса
using UnityEngine.SceneManagement; //Подключение библиотеки для работы со сценами проекта

public class MenuTeacher : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel; //Объявление объекта "Панель выхода"

    //Активация панели выхода
    public void LogOut()
    {
        logOutPanel.SetActive(true);
    }

    //Выход в главное меню
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    //Закрытие панели выхода
    public void LogOutClose()
    {
        logOutPanel.SetActive(false);
    }

    //Запуск сцены для добавления нового задания
    public void NewTask()
    {
        SceneManager.LoadScene(4);
    }
}
