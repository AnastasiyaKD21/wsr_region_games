using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //����������� ���������� ��� ������ � ���������� ����������������� ����������
using UnityEngine.SceneManagement; //����������� ���������� ��� ������ �� ������� �������

public class MenuStudent : MonoBehaviour
{
    [SerializeField] private GameObject logOutPanel; //���������� ������� "������ ������"

    //��������� ������ ������
    public void LogOut()
    {
        logOutPanel.SetActive(true);
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

    //������
    public void Theory()
    {
        SceneManager.LoadScene(5);
    }

    //����������
    public void Training()
    {
        SceneManager.LoadScene(6);
    }

    //������������
    public void Testing()
    {
        SceneManager.LoadScene(7);
    }

    //����������
    public void Results()
    {
        SceneManager.LoadScene(8);
    }
}
