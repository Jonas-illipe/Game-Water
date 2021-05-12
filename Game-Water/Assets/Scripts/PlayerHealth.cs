using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int Maxhealth = 200;
    public int currenthealth;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = Maxhealth;
    }

    // Update is called once per frame

    void Update()
    {
        if (currenthealth == 0)
        {
            GameObject.Destroy(Player);



            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


        }

    }

    private void OnTriggerEnter2D(Collider2D collisio)
    {
        if (collisio.gameObject.tag.Equals("EnemyBullet"))
        {
            currenthealth -= 20;

        }
        Debug.Log("tkdmg");

    }
    


}