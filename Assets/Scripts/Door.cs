using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject effectPreafb;
    public Transform efectPosition;
    public GameObject door2;
    
    public bool isOpen;

    private void Start()
    {
        isOpen = false;
    }

    public void StartEffect()
    {
        if (isOpen == false && door2.GetComponent<Door>().isOpen == false)
        {
            isOpen = true;
            Instantiate(effectPreafb, efectPosition);
        }
    }
}
