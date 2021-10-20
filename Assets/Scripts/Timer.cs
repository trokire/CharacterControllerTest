using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class Timer : MonoBehaviour
{
    public ThirdPersonController player;
    public float maxTimeValue;
    public float timeValue;
    public GameObject gameOver;
    public Slider remainingTimeSlider;
    private float pauseTime;
    private float nextTime;

    // Start is called before the first frame update
    void Start()
    {
        pauseTime = 1f;  // 1 segon
        nextTime = 0;
    }

    private void Update()
    {            
        if ((Time.time > nextTime) &&  timeValue>0)
        {
           nextTime = Time.time + pauseTime;
           timeValue = timeValue - 1;
           Debug.Log (timeValue);
           remainingTimeSlider.value = timeValue / maxTimeValue;
           if (timeValue == 0)
           {
               gameOver.SetActive(true);
               player.enabled = false;
           }
        }
    }
}
