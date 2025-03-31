using UnityEngine;
using UnityEngine.SceneManagement;

public class HitWall : MonoBehaviour
{
    public GameObject hitwall;
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitwall.SetActive(false);
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Wall")
        {
            hitwall.SetActive(true);
            ball.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
