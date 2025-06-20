using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private bool hasStartedLap = false;

    void Update()
    {
        if (hasStartedLap)
        {
            elapsedTime = Time.time - startTime;
            Debug.Log(elapsedTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hasStartedLap = true;
        startTime = Time.time;
    }
}
