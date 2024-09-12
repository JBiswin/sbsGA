using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

enum RoadLine
{
    LEFT = -1,
    MIDDLE,
    RIGHT,
    
}
public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine line;
    [SerializeField] Rigidbody body;
    [SerializeField] float positionX = 2.0f;

    int linestate = 0;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        InpuManager.insTance.action += OnkeyUpdate;
    }


    private void OnDisable()
    {
        InpuManager.insTance.action -= OnkeyUpdate;
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        body.position = new Vector3(positionX * (int)line, 0, 0);
    }

    

    public void OnkeyUpdate()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(line != RoadLine.LEFT)
            {
                line--;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (line != RoadLine.RIGHT)
            {
                line++;
            }
        }



    }
}
