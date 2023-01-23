using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTranceform : MonoBehaviour
{
    public Vector3 scalechange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scalechange;
    
    }
}
