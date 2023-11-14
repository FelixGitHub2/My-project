using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonMenuUICT : MonoBehaviour
{
   [SerializeField] private string newGameLevel = "Start";
    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
