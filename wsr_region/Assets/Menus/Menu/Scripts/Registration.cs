using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField] private Button BtnReg;
    [SerializeField] private Dropdown Roles;

    public void InputRoles()
    {
        if(Roles.value == 0)
        {
            print("Роль");
        }

        if(Roles.value == 1)
        {
            print("Администратор");
        }

        if(Roles.value == 2)
        {
            print("Преподаватель");
        }

        if(Roles.value == 3)
        {
            print("Студент");
        }
    }
}
