using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(JermaShoot))]
public class BossLogic : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] float timeBeforeAttack = 10;
    float timer;

    private JermaShoot jermaShoot;

    // Start is called before the first frame update
    void Start()
    {
        jermaShoot = GetComponent<JermaShoot>();
    }

    // Update is called once per frame
    void Update()
    {   


        timer += Time.deltaTime;
        if (timer > timeBeforeAttack)
        {
            int randomAttack = Random.Range(0, 0);
            if (randomAttack == 0)
            {
                Attack1();
            }
            print(randomAttack);
            timer = 0;


        }
    }
    void Attack1()
    {
        animator.SetTrigger("Attack1");
        jermaShoot.Invoke("Boom", 2);
    }

    void Attack2()
    {
        animator.SetTrigger("Attack2");
        jermaShoot.Invoke("Boom", 2);
    }

    void Attack3()
    {
        animator.SetTrigger("Attack3");
        jermaShoot.Invoke("Boom", 2);
    }

    void JermaEnt()
    {
        animator.SetTrigger("JermaEnt");
    }
}
