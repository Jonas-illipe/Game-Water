using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
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
        
    }
}
