using UnityEngine;

public class GameMenger : MonoBehaviour
{
    public GameObject ball;
    int score = 0;
    private GameObject[] pins;
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
        if (Input.GetKeyDown(KeyCode.Space) || ball.transform.position.y < -20)
        {
            CountPinsDown();
        }
    }
    void MoveBall()
    {
        Vector3 position = ball.transform.position;
        position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -7f, 7f); 
        ball.transform.position = position;
        //ball.transform.Translate(Vector3.right * Input.GetAxis("Horizontal")* Time.deltaTime);
    }

    void CountPinsDown()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            if (pins[i].transform.eulerAngles.z > 5 && pins[i].transform.eulerAngles.z < 355)
            {
                score++;
            }
        }
        Debug.Log(score);
    }
}
