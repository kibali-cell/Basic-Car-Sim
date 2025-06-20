using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private bool hasStartedLap = false;

    // public GameObject lapText;
    public TMP_Text lapText;

    void Update()
    {
        // if (hasStartedLap)
        // {
        //     elapsedTime = Time.time - startTime;
        //     // Debug.Log(elapsedTime);

        //     lapText.GetComponent<Text>().text = "Lap Time:" + elapsedTime.ToString();
        // }

        if (!hasStartedLap || lapText == null)
            return;
        
        elapsedTime = Time.time - startTime;
        lapText.text = "Lap Time: " + elapsedTime.ToString("F2");
    }

    private void OnTriggerEnter(Collider other)
    {
        hasStartedLap = true;
        startTime = Time.time;
    }
}
