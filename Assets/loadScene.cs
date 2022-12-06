using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void modelScene() {
        SceneManager.LoadScene("Model Screen");
    }

    public void galleryScene()
    {
        for (int i = 0; i < SaveStyle.savedStyles.Count; i++) {
            SaveStyle.savedStyles[i].SetActive(false);
        }
        SceneManager.LoadScene("Gallery");
    }

    public void menuScene()
    {
        SceneManager.LoadScene("Menu Screen");
    }

    public void creditsScene() {
        SceneManager.LoadScene("Credits");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
