using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler1 : MonoBehaviour
{
    private GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy1"))
        {
            GameObject explosion = Instantiate(Resources.Load("ExplosionMobile", typeof(GameObject))) as GameObject;
            explosion.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(explosion.gameObject, 1.5f);
            player = GameObject.Find("Main Camera");
            player.GetComponent<WebCamControler>().score(0);
            if (GameObject.FindGameObjectsWithTag("Enemy1").Length == 0)
            {
                GameObject enemy11 = Instantiate(Resources.Load("Enemy11", typeof(GameObject))) as GameObject;
                GameObject enemy12 = Instantiate(Resources.Load("Enemy12", typeof(GameObject))) as GameObject;
               
            }
            Destroy(gameObject);
        }
    }
}
