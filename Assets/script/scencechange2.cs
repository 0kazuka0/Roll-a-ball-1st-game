using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scencechange2 : MonoBehaviour
{
    public void OnRetryButton()
    {
        SceneManager.LoadScene("SampleScene2");
    }

   
    public void OnMenuButton()
    {
        SceneManager.LoadScene("MENU");
    }
}
