using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Подключение библиотеки для работы с элементами пользовательского интерфейса
using UnityEngine.SceneManagement; //Подключение библиотеки для работы со сценами проекта

public class MenuAdmin : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel; //Объявление объекта "Панель выхода"
    [SerializeField] private GameObject newUserPanel; //Объявление объекта "Создание нового пользователя"

    //Активация панели выхода
    public void LogOut()
    {
        logOutPanel.SetActive(true);
    }

    //Активация панели для добавления нового пользователя
    public void Users()
    {
        newUserPanel.SetActive(true);
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

    //Закрытие панели создания нового пользователя
    public void UsersClose()
    {
        newUserPanel.SetActive(false);
    }
}
