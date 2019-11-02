using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject Object;
        

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(Object);
        }
    }
}


