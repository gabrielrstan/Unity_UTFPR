using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControler : MonoBehaviour
{
    private GameObject player;


    void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;

        if (hit.CompareTag("Enemy"))
        {
            player = GameObject.Find("Darrak");
            player.GetComponent<PlayerControler>().score(0);
            Destroy(hit);


            float randomX = UnityEngine.Random.Range(-20, 20);
            float randomZ = UnityEngine.Random.Range(-20, 20);

            GameObject zombie = Instantiate(Resources.Load("Erdan", typeof(GameObject))) as GameObject;
            zombie.transform.position = new Vector3(randomX, 1, randomZ);
            zombie.transform.rotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
        }

        Destroy(gameObject);
    }
   

}