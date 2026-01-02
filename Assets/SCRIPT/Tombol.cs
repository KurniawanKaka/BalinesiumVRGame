using UnityEngine;
using UnityEngine.UI;

public class Tombol : MonoBehaviour
{

    [SerializeField] GameObject gambar;
    bool playermasuk = false;

    public void pencettombol()
    {
        if (!gambar.activeSelf && playermasuk)
        {
            gambar.SetActive(true);
        }
        else
        {
            gambar.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Playermasuk");
            playermasuk = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Playerkeluar");
            playermasuk = false;
            gambar.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
