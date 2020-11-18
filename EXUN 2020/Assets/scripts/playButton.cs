using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    
    public void play()
    {
        int sceneToLoad = PlayerPrefs.GetInt("savedScene", 1);
        print(sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
