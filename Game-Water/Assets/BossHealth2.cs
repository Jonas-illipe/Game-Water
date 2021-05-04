using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth2 : MonoBehaviour
{
    public int bossMaxHealth = 400;
    public int currentBossHealth;
    public GameObject Boss;

    // Start is called before the first frame update
    void Start()
    {
        currentBossHealth = bossMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBossHealth == 0)
        {
            GameObject.Destroy(Boss);
            

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("PlayerBullet"))
        {
            currentBossHealth -= 40;
            Destroy(collision.gameObject);
        }


    }

}

