using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFuctions : MonoBehaviour
{
    //create a variable of type int and set it to the number 5
    int myInt = 5;

    
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    } 
}
