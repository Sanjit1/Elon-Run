using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectDetect : MonoBehaviour
{
    public Collision2D musk;
    public GameObject Grimes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 


    void OnCollisionEnter2D(Collision2D piece)
    {
        //if (piece == musk)
        //{
            Grimes.GetComponent<updateGrimes>().hitGrimes();
        //}
    }
}
