using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //����������� ���������� ��� ������ � ���������� ����������������� ����������
using UnityEngine.SceneManagement; //����������� ���������� ��� ������ �� ������� �������

public class MenuAdmin : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel; //���������� ������� "������ ������"
    [SerializeField] private GameObject newUserPanel; //���������� ������� "�������� ������ ������������"

    //��������� ������ ������
    public void LogOut()
    {
        logOutPanel.SetActive(true);
    }

    //��������� ������ ��� ���������� ������ ������������
    public void Users()
    {
        newUserPanel.SetActive(true);
    }

    //����� � ������� ����
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    //�������� ������ ������
    public void LogOutClose()
    {
        logOutPanel.SetActive(false);
    }

    //�������� ������ �������� ������ ������������
    public void UsersClose()
    {
        newUserPanel.SetActive(false);
    }
}
