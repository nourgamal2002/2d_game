using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{ 
  public void GoToLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
