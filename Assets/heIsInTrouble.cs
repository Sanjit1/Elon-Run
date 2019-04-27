using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heIsInTrouble : MonoBehaviour
{
    public Collider2D muskColider;
    public GameObject livestock;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D piece)
    {

        if (piece == muskColider)
        {
            livestock.GetComponent<LiveCounter>().removeAhHart();
            
        }
    }
}

