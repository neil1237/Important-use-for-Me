using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    
	void Start () {
		
	}
	
	void Update () {
		
	}

    public void LoadNewScene(string sceneLevel)
    {
        SceneManager.LoadScene(sceneLevel);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
