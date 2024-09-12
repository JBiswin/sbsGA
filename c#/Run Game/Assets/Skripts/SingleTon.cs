using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTon<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T insTance
    {
        set { }
        get { return instance; }
    }

    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = (T)FindObjectOfType(typeof(T));
        }

        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
