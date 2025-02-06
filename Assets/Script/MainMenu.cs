using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Netcode;
using Unity.Services.Lobbies.Models;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine;
using Unity.Services.Lobbies;
using UnityEditor;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SinglePlayer ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MultiPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public virtual void QuitGame ()
    {
        Debug.Log ("QUIT!!!");
        Application.Quit();
    }

}
