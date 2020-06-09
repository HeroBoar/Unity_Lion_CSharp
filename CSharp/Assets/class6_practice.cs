using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class6_practice : MonoBehaviour
{
    //public GameObject obj1;
    public SpriteRenderer sr;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 2;

        sr.flipX = true;

        print(Mathf.Floor(1.23456f));

        rb.AddForce(0, 800, 1500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
