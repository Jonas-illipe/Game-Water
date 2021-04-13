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



    // Start is called before the first frame update
    void Start()
    {// sätter fire rate till 1 skott i sekunden
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {//gör att CheckIfTimeToFire voiden startar varje frame precis som i update
        CheckIfTimeToFire ();
    }

    void CheckIfTimeToFire()
    { 
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
