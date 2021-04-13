using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 120;
    public int currentEnemyHealth;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        currentEnemyHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEnemyHealth == 0) 
        {
            GameObject.Destroy(Enemy);
        }
    }
}
