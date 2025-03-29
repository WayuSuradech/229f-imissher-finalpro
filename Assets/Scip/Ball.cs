using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] public float power;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * power);
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }
}
