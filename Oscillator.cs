using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 0f,0f);
    [SerializeField] float period = 2F;

     float movementFactor; //0 nem mozog, 1 maxra mozgatott

    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;    //aktuális pozívió
      

    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return;  }  //védelem a period nulla ellen, ha nulla vagy majdnem nulla akkor nem folytatja

        float cyrcles = Time.time / period;  //folyamatosan növekszik nullától

        const float tau = Mathf.PI * 2f;   //6.28 
        float rawSinWave = Mathf.Sin(cyrcles * tau);  //megy -1-től +1-ig 

        movementFactor = rawSinWave / 2f + 0.5f;
        //
        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset;
    }
}
