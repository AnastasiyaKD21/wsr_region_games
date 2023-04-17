using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginUser());
    }

    IEnumerator LoginUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://config/login.php", form);

        yield return www;

        /*
        DBManager.role = www.text;

        if (DBManager.role[0] == '0')
        {
            string r = DBManager.role;
            Debug.Log(r);
        }
        */

        if (www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.role = www.text;

            Debug.Log(DBManager.role);
            //string ad = DBManager.role

            //Debug.Log(DBManager.role);

            /*
            if (DBManager.role =)
            {
                Debug.Log(DBManager.role);
            }
            
            //Debug.Log(DBManager.role);
            
            DBManager.role = ;
            if (DBManager.role[0] == '0') 
            {
                string r = DBManager.role;
                Debug.Log(r);
                //SceneManager.LoadScene(1);
            }
            
            else 
            {
                /if (DBManager.role[1] == '1')
                {
                    //Debug.Log(DBManager.role);
                    //SceneManager.LoadScene(2);
                }
                else
                {
                    //Debug.Log(DBManager.role);
                    SceneManager.LoadScene(3);
                }
                    
            }
            */
        }
        else
        {
            Debug.Log("Ошибка авторизации. Ошибка: " + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 3);
    }
}
