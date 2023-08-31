using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("settei", LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
