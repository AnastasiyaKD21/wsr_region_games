using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        WWW www = new WWW("http://config/register.php", form);

        yield return www;

        if(www.text == "0")
        {
            Debug.Log("Пользователь зарегестрирован!");
        }
        else
        {
            Debug.Log("Регистрация пользователя прервана. Ошибка: " + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 3);
    }
}
