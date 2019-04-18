using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    
    private bool beingHandled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 50; i++)
            {
                Invoke("W", 0.05f);   
            }
            }
        if (Input.GetKeyDown(KeyCode.A)) { pos.x = pos.x - 2.5f; }
        if (Input.GetKeyDown(KeyCode.S)) { pos.y = pos.y - 2.5f; }
        if (Input.GetKeyDown(KeyCode.D)) { pos.x = pos.x + 2.5f; }
        transform.position = pos;

    }

    public void W() {
        Vector3 pos = transform.position;
        pos.y = pos.y + 0.05f;
        transform.position = pos;
    }

    private IEnumerator HandleIt()
    {
        Time.timeScale = 100;
        beingHandled = true;
        yield return new WaitForSeconds(1f);
        beingHandled = false;
       
    }

}
