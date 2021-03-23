using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public int Maxhealth = 200;
    public int currenthealth;

    public PlayerHealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = Maxhealth;
        healthBar.SetMax(Maxhealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
