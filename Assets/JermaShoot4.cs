using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JermaShoot4 : MonoBehaviour
{
    public Transform jerma4shootingPoint;
    public GameObject jerma4bulletPrefab;

    public void Boom()
    {
        


        Instantiate(jerma4bulletPrefab, jerma4shootingPoint.position, transform.rotation);



        print("BOOM");
    }
}
