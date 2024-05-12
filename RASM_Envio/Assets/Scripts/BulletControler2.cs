using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler2 : MonoBehaviour
{
    private GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy2"))
        {
            GameObject explosion = Instantiate(Resources.Load("ExplosionMobile", typeof(GameObject))) as GameObject;
            explosion.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(explosion.gameObject, 1.5f);
            player = GameObject.Find("Main Camera");
            player.GetComponent<WebCamControler>().score(0);
            if (GameObject.FindGameObjectsWithTag("Enemy2").Length == 0)
            {
                GameObject enemy21 = Instantiate(Resources.Load("Enemy21", typeof(GameObject))) as GameObject;
                GameObject enemy22 = Instantiate(Resources.Load("Enemy22", typeof(GameObject))) as GameObject;

            }
            Destroy(gameObject);
        }
        
    }
}
