using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public int velocity;
    private int count;
    public TMP_Text textContagem;
    public TMP_Text TextoFimDeJogo;
    public Button btnReiniciar;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        TextoFimDeJogo.gameObject.SetActive(false);
        btnReiniciar.gameObject.SetActive(false);
        
    }
        // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 vecFor = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(vecFor*velocity);

    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            textContagem.text = "Placar:" + count.ToString();
            ExibeFimDeJogo();
        }
    }
    
    private void ExibeFimDeJogo(){
        if(count==6){
            TextoFimDeJogo.gameObject.SetActive(true);
            btnReiniciar.gameObject.SetActive(true);
        }
    }

    public void reiniciaNivel(){
        SceneManager.LoadScene("MiniGame");
    }
}