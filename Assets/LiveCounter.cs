using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveCounter : MonoBehaviour
{
    public int lives = 5;
    public Transform muskTransform;
    public Transform[] livesObject = new Transform[5];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void removeAhHart()
    {
        lives--;
        Vector3 hartPos = livesObject[lives].position;
        hartPos.y = -50;
        livesObject[lives].position = hartPos;
        if (lives == 0) { justKillHim(); }
    }

    public void justKillHim()
    {
        Vector3 newPosition = muskTransform.position;
        newPosition.x = 15f;
        newPosition.y = 72.5f;
        muskTransform.position = newPosition;
        lives = 5;
        for (int i = 0; i < 5; i++){
            Vector3 livePos = livesObject[i].position;
            livePos.y = 5.39f;
            livesObject[i].position = livePos;
        }
    }
}
