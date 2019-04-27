using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public Text scB;
    public int score = 0;
    public Transform muskieBoi;
    public GameObject grimesCounter;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void FixedUpdate()
    {
        if (muskieBoi.position.y > -3.2 && muskieBoi.position.y < 3.0 ) { score = Mathf.RoundToInt(muskieBoi.position.x) + 5; }
        if (muskieBoi.position.y > 3.05 && muskieBoi.position.y < 8.5 ) { score = 80 - Mathf.RoundToInt(muskieBoi.position.x) + 100; }
        if (muskieBoi.position.y > 9.00 && muskieBoi.position.y < 14.0) { score = Mathf.RoundToInt(muskieBoi.position.x) + 205; }
        if (muskieBoi.position.y > 14.0 && muskieBoi.position.y < 40.0) { score = 80 - Mathf.RoundToInt(muskieBoi.position.x) + 305; }
        scB.text = "Score " + score.ToString();

    }

    void Update()
    {

    }
}
