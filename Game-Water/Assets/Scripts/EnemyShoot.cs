using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;

    float fireRate;
    float nextFire;

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    Rigidbody2D rb2d;

    bool playerInVision;

    // Start is called before the first frame update
    void Start()
    {// sätter fire rate till 1 skott i sekunden
        fireRate = 2f;
        nextFire = Time.time;
        playerInVision = false;

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hej!");
        if (collision.gameObject.name.Equals("player"))
        {
            playerInVision = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player")) ;
        {
            playerInVision = false;
            Debug.Log("Halloj!");
        }
    }

    void Update()
    {//gör att CheckIfTimeToFire voiden startar varje frame precis som i update

        if (playerInVision == true)
        { 
            CheckIfTimeToFire();
        } 

    }

    void CheckIfTimeToFire()
    { 
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}