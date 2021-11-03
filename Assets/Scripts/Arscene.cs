using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Arscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex +3);
    }

    void previous(){
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(1);
    }

}
