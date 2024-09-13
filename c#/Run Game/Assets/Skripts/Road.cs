using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Road : MonoBehaviour
{
  [SerializeField] public UnityEvent callback;

    public void Activate()
    {
        if(callback != null)
        {
            callback.Invoke();
        }
    }
}
