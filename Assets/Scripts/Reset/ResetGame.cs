using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetGame : MonoBehaviour
{
    public void ResetMyGame(){
        PlayerPrefs.DeleteAll();
        LoadMyScene();
       
    }

    public void LoadMyScene(){
        SceneManager.LoadScene(0);
    }
}
