using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void SceneChange(int i)
    {
        if(i == 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else if(i == 1)
        {
            SceneManager.LoadScene("RecipeConstructor");
        } else if(i == 2)
        {
            SceneManager.LoadScene("RecipeLoad");
        }
    }
}
