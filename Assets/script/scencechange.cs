using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scencechange : MonoBehaviour
{
    public void OnRetryButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnNextButton()
    {
        SceneManager.LoadScene("SampleScene2");
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene("MENU");
    }
 }
