using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //����������� ���������� ��� ������ � ���������� ����������������� ����������
using UnityEngine.SceneManagement; //����������� ���������� ��� ������ �� ������� �������

public class Training : MonoBehaviour
{
    //����������� � ���� ��������
    public void Back()
    {
        SceneManager.LoadScene(3);
    }
}
