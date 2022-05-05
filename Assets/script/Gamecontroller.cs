using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnExitButton()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
