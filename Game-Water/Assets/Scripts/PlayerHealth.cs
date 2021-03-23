using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthslider;
    // Start is called before the first frame update
    public void SetMax(int health)
    {
        healthslider.maxValue = health;
        healthslider.value = health;
    }

    // Update is called once per frame
    public void SetHealth(int health)
    {
        healthslider.value = health;
    }
}
