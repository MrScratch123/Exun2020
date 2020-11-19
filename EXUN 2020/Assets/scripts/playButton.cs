using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    
    public void play()
    {
        int sceneToLoad = PlayerPrefs.GetInt("savedScene", 2);
        SceneManager.LoadScene(sceneToLoad);
    }
    public void rePlay()
    {
        int sceneToLoad = 0;
        SceneManager.LoadScene(sceneToLoad);
    }
}
