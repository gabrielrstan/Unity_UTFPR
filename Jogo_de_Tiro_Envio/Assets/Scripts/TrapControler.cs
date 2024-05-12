using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapControler : MonoBehaviour
{
    public GameObject cubetrap;
    public GameObject Lava;
    public GameObject InstaKill;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();

            other.gameObject.GetComponent<PlayerControler>().score(1);
            for (int i = 0; i < 7; i++)
            {
                float randomX = UnityEngine.Random.Range(-20, 20);
                float randomZ = UnityEngine.Random.Range(-20, 20);

                var cube = (GameObject)Instantiate(cubetrap, new Vector3(randomX, 15, randomZ), Quaternion.identity);

                Destroy(cube, 5.0f);

            }

            for (int i = 0; i < 15; i++)
            {
                float randomX2 = UnityEngine.Random.Range(-25, 25);
                float randomZ2 = UnityEngine.Random.Range(-25, 25);

                var lava = (GameObject)Instantiate(Lava, new Vector3(randomX2, 0.04f, randomZ2), Quaternion.identity);

                Destroy(lava, 30.0f);

            }

            float randomX3 = UnityEngine.Random.Range(-40, 40);
            float randomZ3 = UnityEngine.Random.Range(-40, 40);
            Renderer rend;
            var instaKill = (GameObject)Instantiate(InstaKill, new Vector3(randomX3, 0.5f, randomZ3), Quaternion.identity);
            rend = instaKill.GetComponent<Renderer>();
            rend.enabled = false;
            Destroy(instaKill, 180.0f);

            
        }



    }
}