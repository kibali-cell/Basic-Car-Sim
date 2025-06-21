using UnityEngine;

public class AudioEngine : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();

        // source.pitch = Random.Range(-1.2f, 1.2f, 0.22f);

        source.pitch = Mathf.Lerp(-1.2f, 1.2f, Random.Range(-1.2f, 1.2f));
    }
}
