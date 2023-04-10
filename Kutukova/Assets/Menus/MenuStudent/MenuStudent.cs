using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Подключение библиотеки для работы с элементами пользовательского интерфейса
using UnityEngine.SceneManagement; //Подключение библиотеки для работы со сценами проекта

public class MenuStudent : MonoBehaviour
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

    //Теория
    public void Theory()
    {
        SceneManager.LoadScene(5);
    }

    //Тренировка
    public void Training()
    {
        SceneManager.LoadScene(6);
    }

    //Тестирование
    public void Testing()
    {
        SceneManager.LoadScene(7);
    }

    //Результаты
    public void Results()
    {
        SceneManager.LoadScene(8);
    }
}
