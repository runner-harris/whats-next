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
        SceneManager.LoadScene("Gallery");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
