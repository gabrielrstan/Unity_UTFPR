using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WebCamControler : MonoBehaviour
{
    public GameObject webCamPlane;
    public Button fireButton1;
    public Button fireButton2;
    public TMP_Text textContagem;
    public int count = 0;

    public void score(int x)
    {
        if (x == 0)
        {
            count += 100;
        }
        

        textContagem.text = "Score: " + count.ToString();

    }

    void Start()
    {
        WebCamTexture texture = new WebCamTexture();
        webCamPlane.GetComponent<MeshRenderer>().material.mainTexture = texture;
        texture.Play();
        Input.gyro.enabled = true;
        fireButton1.onClick.AddListener(Fire1);
        fireButton2.onClick.AddListener(Fire2);
    }

    void Update()
    {
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x,
            Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w);
        transform.localRotation = cameraRotation;
    }

    void Fire1()
    {
        GameObject bullet1 = Instantiate(Resources.Load("Bullet1", typeof(GameObject))) as GameObject;
        bullet1.transform.position = Camera.main.transform.position;
        bullet1.transform.rotation = Camera.main.transform.rotation;
        Rigidbody rb = bullet1.GetComponent<Rigidbody>();
        rb.AddForce(Camera.main.transform.forward * 500f);
        AudioSource aud = bullet1.GetComponent<AudioSource>();
        aud.Play();
        Destroy(bullet1,3f);

    }
    void Fire2()
    {
        GameObject bullet2 = Instantiate(Resources.Load("Bullet2", typeof(GameObject))) as GameObject;
        bullet2.transform.position = Camera.main.transform.position;
        bullet2.transform.rotation = Camera.main.transform.rotation;
        Rigidbody rb = bullet2.GetComponent<Rigidbody>();
        rb.AddForce(Camera.main.transform.forward * 500f);
        AudioSource aud = bullet2.GetComponent<AudioSource>();
        aud.Play();
        Destroy(bullet2, 3f);

    }
}
