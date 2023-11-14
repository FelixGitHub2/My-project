using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCineTimer : MonoBehaviour
{
     [SerializeField] float time = 0;

    float timer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            SceneManager.LoadScene(8);
        }

    }
}
