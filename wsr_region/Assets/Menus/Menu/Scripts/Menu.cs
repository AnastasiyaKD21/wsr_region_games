using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject authorizationPanel;
    [SerializeField] private GameObject registrationPanel;

    public void Authorization()
    {
        authorizationPanel.SetActive(true);
    }

    public void Registration()
    {
        registrationPanel.SetActive(true);
    }

    public void AuthorizationClose()
    {
        authorizationPanel.SetActive(false);
    }

    public void RegistrationClose()
    {
        registrationPanel.SetActive(false);
    }
}
