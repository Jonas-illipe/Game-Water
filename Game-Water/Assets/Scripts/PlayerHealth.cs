using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Maxhealth = 200;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = Maxhealth;        
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("AcidPool"))
        {
            currenthealth -= 20;
        }
    }
}
