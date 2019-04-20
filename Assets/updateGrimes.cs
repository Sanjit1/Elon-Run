using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGrimes : MonoBehaviour
{
    public Text grimes;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void hitGrimes()
    {
        score++;
        grimes.text = score.ToString();

    }
    
    void Update()
    {
        
    }
}
