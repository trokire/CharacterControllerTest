using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject effectPreafb;
    public Transform efectPosition;
    public bool isOpen;

    private void Start()
    {
        isOpen = false;
    }

    public void StartEffect()
    {
        if (isOpen == false)
        {
            GameObject effect = Instantiate(effectPreafb, efectPosition);
        }
    }
}
