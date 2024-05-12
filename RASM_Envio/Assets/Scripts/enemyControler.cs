using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("changeDirection");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 2f * Time.deltaTime);
    }

    IEnumerator changeDirection()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            transform.eulerAngles += new Vector3(0f, 180f, 0f);
        }
    }
}
