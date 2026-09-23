using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comp2 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Comp1.Cubo.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
