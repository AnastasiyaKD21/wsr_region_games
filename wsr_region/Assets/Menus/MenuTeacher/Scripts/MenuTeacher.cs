using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuTeacher : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel;

    public void LogOut()
    {
        logOutPanel.SetActive(true);
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
}
