using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake Called.");
    }

    // Update is called once per frame
    void start()
    {
        Debug.Log("start called.");
    }
}
