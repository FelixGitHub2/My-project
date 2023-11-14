using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jermahealth3 : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            deadbody.SetActive(true);
            Destroy(gameObject);
            SceneManager.LoadScene(9);
            
        }
    }
}
