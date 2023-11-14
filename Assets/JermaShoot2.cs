using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
public class JermaShoot2 : MonoBehaviour
{
    public Transform jerma2shootingPoint;
    public GameObject jerma2bulletPrefab;

    public void Boom()
    {
        


        Instantiate(jerma2bulletPrefab, jerma2shootingPoint.position, transform.rotation);



        print("BOOM");
    }
}
