using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveSceneManager : MonoBehaviour
{
    void Update()
    {
        // the real saving shtuff happenes in playRespawn
        PlayerPrefs.SetInt("savedScene", SceneManager.GetActiveScene().buildIndex);
    }
}
