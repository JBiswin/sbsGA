using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameobject : MonoBehaviour
{
    [SerializeField] float speed = 15f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
