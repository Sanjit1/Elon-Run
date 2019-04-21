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
        newPosition.x = 100f;
        newPosition.y = newPosition.y + 100f;
        if (piece == musk)
        {
            transform.position = newPosition;
            Grimes.GetComponent<updateGrimes>().hitGrimes();
        }
    }
}
