using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Helathbar : MonoBehaviour
{
    public Slider healthslider;
    public float MaxHealth;
    public static float currenthealth;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = MaxHealth;
    }


    // Update is called once per frame
    void Update()
    {

        //healthslider.value = currenthealth;
    }

}