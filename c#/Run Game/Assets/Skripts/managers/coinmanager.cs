using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmanager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float offset = 2.5f;
    [SerializeField] int ceratecount = 16;
    void Awake()
    {
        Create();
    }

    public void Create()
    {
        for(int i =0;  i < ceratecount; i++)
        {
            prefab = Instantiate(prefab);
            prefab.transform.SetParent(gameObject.transform);
            prefab.transform.localPosition = new Vector3(0, 0, offset * i);
        }

        
    }

    
}
