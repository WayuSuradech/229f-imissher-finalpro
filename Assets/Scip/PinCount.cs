using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PinCount : MonoBehaviour
{
    public GameObject ball;
    public int score = 0;
    GameObject[] pins;
    public Text scoreUi;
    public GameObject panel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.SetActive(false);
        pins = GameObject.FindGameObjectsWithTag("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < 0)
        {
            CountPins();
        }

        if (ball.transform.position.y < -1)
        {
            ShowPins();
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

    void ShowPins()
    {
        panel.SetActive(true);
    }
}
