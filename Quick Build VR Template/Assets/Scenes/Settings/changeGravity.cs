using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGravity : MonoBehaviour
{
    public float gravity = 9.81f; // m/s

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -gravity, 0);
    }
}