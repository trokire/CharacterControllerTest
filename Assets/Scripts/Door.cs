using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject effectPreafb;
    public Transform efectPosition;
    
    private bool isOpen;

    private void Start()
    {
        isOpen = false;
    }

    public void StartEffect()
    {
        if (isOpen == false)
        {
            isOpen = true;
            Instantiate(effectPreafb, efectPosition);
        }
    }
}
