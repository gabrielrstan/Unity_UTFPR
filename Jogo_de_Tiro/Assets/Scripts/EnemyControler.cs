using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControler : MonoBehaviour
{
    private Rigidbody rb;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");

        }
    }
}
