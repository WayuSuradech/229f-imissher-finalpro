using UnityEngine;
using UnityEngine.UI;

public class PinCount : MonoBehaviour
{
    public GameObject ball;
    public int score = 0;
    GameObject[] pins;

    public Text scoreUi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || ball.transform.position.y < -3)
        {
            CountPins();
        }
    }

    void CountPins()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            if (pins[i].transform.eulerAngles.z > 5 && pins[i].transform.eulerAngles.z < 355
                && pins[i].activeSelf)
            {
                score++;
                pins[i].SetActive(false);
            }
            scoreUi.text = score.ToString();
        }
    }
}
