using UnityEngine;

public class Rindik : MonoBehaviour
{

    [SerializeField] AudioManager am;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pukulanrindik"))
        {
            am.playSFX(am.rindik);
        }
    }
}
