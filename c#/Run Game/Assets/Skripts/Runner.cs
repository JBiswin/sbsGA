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

   
    void Update()
    {
        LineState();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        body.position = new Vector3(positionX * (int)line, 0, 0);
    }

    //    public void LineState()
    //    {
    //       if(Input.GetKeyDown(KeyCode.LeftArrow))
    //        {
    //            if(line == RoadLine.MIDDLE)
    //            {
    //                linestate = linestate - 1;
    //   
    //                line = RoadLine.LEFT;
    //            }
    //   
    //            else if (line == RoadLine.RIGHT)
    //            {
    //                linestate = linestate - 1;
    //   
    //                line = RoadLine.MIDDLE;
    //            }
    //        }
    //   
    //        if(Input.GetKeyDown(KeyCode.RightArrow))
    //        {
    //            if(line == RoadLine.MIDDLE)
    //            {
    //                linestate = linestate + 1;
    //   
    //                line = RoadLine.RIGHT;
    //            }
    //   
    //            else if ( line == RoadLine.LEFT)
    //            {
    //                linestate = linestate + 1;
    //   
    //                line = RoadLine.MIDDLE;
    //            }
    //            
    //        }
    //    }

    public void LineState()
    {

        if (linestate >= -1 || linestate <= 1)
        {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                line = line - 1;
                linestate = linestate - 1;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                line = line + 1;

                linestate = linestate + 1;
            }
        }
        
    }
}
