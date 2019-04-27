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
        if (muskieBoi.position.y > -3.2 && muskieBoi.position.y < 0.4) { score = Mathf.RoundToInt(muskieBoi.position.x) + 5; }
        scB.text = "Score " + score.ToString();

    }

    void Update()
    {

    }
}
