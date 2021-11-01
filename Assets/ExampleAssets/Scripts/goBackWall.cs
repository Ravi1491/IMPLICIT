using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBackWall : MonoBehaviour
{
    // Start is called before the first frame update
    int SceneIndex;
    public void Start()
    {
        SceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
}
