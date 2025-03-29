using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 3f; // ความเร็วในการเคลื่อนที่
    public float distance = 5f; // ระยะทางที่เคลื่อนที่ไปซ้ายและขวา

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(startPosition.x + movement, transform.position.y, transform.position.z);
    }
}
