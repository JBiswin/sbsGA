using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] GameObject rotationgameobject;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        rotationgameobject = GameObject.Find("rotation Gameobject");

        
    }


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
