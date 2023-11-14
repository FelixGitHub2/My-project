using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallingBullet : MonoBehaviour
{
    public GameObject fallingbulletprefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(bulletWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(fallingbulletprefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.y * -2, Random.Range(-screenBounds.y, screenBounds.x));
    }

    IEnumerator bulletWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
        
    }
}
