using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public Transform bulletSpawn;
    public  GameObject bulletPrefab;
    private Rigidbody rb;
    public Transform player;
    public TMP_Text textContagem;
    public int count = 0;

    public void score(int x)
    {
        if(x == 0)
        {
            count += 100;
        }
        else
        {
            count += 50;
        }

        textContagem.text = "Score: " + count.ToString();

    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Trap")
        {

            player.gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");

        }
       
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal") * 150.0f * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * 9.0f * Time.deltaTime;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space)){
            Fire();
        }

        void Fire(){
            var bullet = (GameObject) Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 15;
            AudioSource sound = GetComponent < AudioSource >();
            sound.Play();

            Destroy(bullet, 2.0f);
        }
         
    }

    
    
}
