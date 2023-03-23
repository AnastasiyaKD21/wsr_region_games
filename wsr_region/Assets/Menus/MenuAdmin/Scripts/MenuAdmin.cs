using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuAdmin : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel;
    [SerializeField] private GameObject usersPanel;

    public void LogOut()
    {
        logOutPanel.SetActive(true);
    }

    public void Users()
    {
        usersPanel.SetActive(true);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitClose()
    {
        logOutPanel.SetActive(false);
    }

    public void LogOutClose()
    {
        logOutPanel.SetActive(false);
    }

    public void UsersClose()
    {
        usersPanel.SetActive(false);
    }
}
