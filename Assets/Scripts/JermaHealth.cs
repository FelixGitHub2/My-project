using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.SceneManagement;
public class JermaHealth : MonoBehaviour
{

    public int hp = 5;

    [SerializeField]
    GameObject deadbody;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            hp--;
        }

    }
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

}
