using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectDetect : MonoBehaviour
{
    public Collider2D musk;
    public GameObject Grimes;
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D piece)
    {
        
  
        Vector3 newPosition = target.position;
        newPosition.x = newPosition.x + 6.23f;
        newPosition.y = newPosition.y + 1.03f;
        transform.position = newPosition;
        if (piece == musk)
        {
        Grimes.GetComponent<updateGrimes>().hitGrimes();
        }
    }
}
