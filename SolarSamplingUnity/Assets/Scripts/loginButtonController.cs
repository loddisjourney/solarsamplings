using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loginButtonController : MonoBehaviour
{
    public void ButtonPressed()
    {
        Scene thisMenu = SceneManager.GetActiveScene();

        SceneManager.LoadSceneAsync("MenuQR");
        SceneManager.UnloadSceneAsync(thisMenu);
    }
}
