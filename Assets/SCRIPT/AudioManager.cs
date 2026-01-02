using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource musik, sfx;
    public AudioClip bg, gamelan, rindik, ceng;

    public static AudioManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musik.clip = bg;
        musik.Play();
    }

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playSFX(AudioClip name)
    {
        sfx.PlayOneShot(name);
    }
}
