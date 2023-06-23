using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrapper : MonoBehaviour
{
    public EventDispatcher ed;


    void Start()
    {
        SceneManager.LoadScene("Playground", LoadSceneMode.Single);

        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
        SceneManager.LoadScene("GameLogic", LoadSceneMode.Additive);
        
        ed = new EventDispatcher();

    }

}
