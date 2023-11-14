using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonui : MonoBehaviour
{   
    [SerializeField] private string newGameLevel = "Intro";
    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
