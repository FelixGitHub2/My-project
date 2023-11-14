using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JermaShoot3 : MonoBehaviour
{
    public Transform jerma3shootingPoint;
    public GameObject jerma3bulletPrefab;

    public void Boom()
    {
        


        Instantiate(jerma3bulletPrefab, jerma3shootingPoint.position, transform.rotation);



        print("BOOM");
    }
}
