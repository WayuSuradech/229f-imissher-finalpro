using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameMenger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    Rigidbody rb;
    [SerializeField] public float power;
    public AudioSource ballAudio;

    [SerializeField]
    float force;

    bool isShooting = false;
    bool isGoingRight = true;

    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);
            ballAudio.Play();
            isShooting = true;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(!isShooting)
        {
            MoveBall();
        }
    }

    void MoveBall()
    {
        if(isGoingRight)
        {
            ball.transform.Translate(Vector3.right * power );
        }
        else
        {
            ball.transform.Translate(Vector3.left * power );
        }

        if (ball.transform.position.x > 7f)
        {
            isGoingRight = false;
        }


        if(ball.transform.position.x < -7f)
        {
            isGoingRight = true;
        }

    }
}
