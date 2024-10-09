using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type int and set it to the number 5
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
        //if our gameobjects y value is below 5 we want to show a message on the console
        if(transform.position.y <= 5f)
            {
            Debug.Log("I'm about to hit the ground)
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }


}
