using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class JermaShoot : MonoBehaviour
{

    public Transform jermashootingPoint;
    public GameObject jermabulletPrefab;

    [SerializeField] GameObject player;


    public void Boom()
    {
        Vector2 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);


        Instantiate(jermabulletPrefab, jermashootingPoint.position, rot);



        print("BOOM");
    }


}
