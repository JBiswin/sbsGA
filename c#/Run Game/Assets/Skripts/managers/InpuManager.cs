using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpuManager : SingleTon<InpuManager>
{
    public Action action;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey == false)
        {
            return;
        }

        if(action != null)
        {
            action.Invoke();
        }
    }
}
