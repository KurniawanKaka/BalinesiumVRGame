using UnityEngine;

public class ceng : MonoBehaviour
{

    [SerializeField] AudioManager am;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ceng"))
        {
            am.playSFX(am.ceng);
        }
    }
}
