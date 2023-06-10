using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
   
    // Update is called once per frame
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
   

}
