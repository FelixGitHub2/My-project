using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

[RequireComponent(typeof(JermaShoot2))]

[RequireComponent(typeof(JermaShoot3))]

[RequireComponent(typeof(JermaShoot4))]
public class BossLogic2 : MonoBehaviour
{
    
    [SerializeField] Animator animator;

    [SerializeField] float timeBeforeAttack = 10;
    float timer;

    private JermaShoot2 JermaShoot2;

    private JermaShoot3 JermaShoot3;

   private JermaShoot4 JermaShoot4;
    void Start()
    {
        JermaShoot2 = GetComponent<JermaShoot2>();
        JermaShoot3 = GetComponent<JermaShoot3>();
        JermaShoot4 = GetComponent<JermaShoot4>();
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeBeforeAttack)
        {
            int randomAttack = Random.Range(0, 0);
            if (randomAttack == 0)
            {
                Attack2();
            }
            print(randomAttack);
            timer = 0;


        }
    }
    void Attack2()
    {
        animator.SetTrigger("Attack2");
        JermaShoot2.Invoke("Boom", 3);
        JermaShoot3.Invoke("Boom", 4);
        JermaShoot4.Invoke("Boom", 5);
    }
}
