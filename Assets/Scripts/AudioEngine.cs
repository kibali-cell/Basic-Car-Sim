using UnityEngine;

public class AudioEngine : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();

        source.pitch = Random.Range(-1.2f, 1.2f);
    }
}
