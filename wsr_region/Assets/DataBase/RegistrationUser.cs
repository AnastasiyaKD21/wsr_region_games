using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegistrationUser : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Dropdown roleField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        form.AddField("role", roleField.value);
        WWW www = new WWW("http://wsrregion/www/register.php", form);

        yield return www;

        if (www.text == "0")
        {
            Debug.Log("User create successfully.");
            if(roleField.value == 1)
            {
                SceneManager.LoadScene(1);
            }
            else if (roleField.value == 2)
            {
                SceneManager.LoadScene(3);
            }
            else if(roleField.value == 3) 
            {
                SceneManager.LoadScene(2);
            }
        }
        else
        {
            Debug.Log("User creation failed. Error: " + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 3);
    }
}
