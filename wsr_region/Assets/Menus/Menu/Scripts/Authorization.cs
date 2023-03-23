using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Authorization : MonoBehaviour
{
    [SerializeField] private Button BtnLog;
    [SerializeField] private Dropdown Roles;

    public void InputRoles()
    {
        if(Roles.value == 0)
        {
            print("Роль");
        }

        if(Roles.value == 1)
        {
            SceneManager.LoadScene(1);
        }

        if(Roles.value == 2)
        {
            SceneManager.LoadScene(3);
        }

        if(Roles.value == 3)
        {
            SceneManager.LoadScene(2);
        }
    }
}
