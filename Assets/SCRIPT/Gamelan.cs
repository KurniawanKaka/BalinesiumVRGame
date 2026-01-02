using UnityEngine;

public class Gamelan : MonoBehaviour
{

    [SerializeField] AudioManager am;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pukulangamelan"))
        {
            am.playSFX(am.gamelan);
        }
    }
}
