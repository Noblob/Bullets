using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAnimation : MonoBehaviour
{

    public GameObject Bullet;
    public bool isShooting = false;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (isShooting == false)
            {
                StartCoroutine(Shoot());
            }
        }
    }


    IEnumerator Shoot()
    {
        isShooting = true;
        Bullet.GetComponent<Animator>().Play("Bullet Animation");
        yield return new WaitForSeconds(0.0f);
        yield return new WaitForSeconds(0.70f);
        Bullet.GetComponent<Animator>().Play("New State");
        isShooting = false;
    }
}

