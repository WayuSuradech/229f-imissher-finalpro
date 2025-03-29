using UnityEngine;

public class Contact : MonoBehaviour
{
    public AudioSource pinsAudio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bowling")
        {
            pinsAudio.Play();
        }
    }
}
