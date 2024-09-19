using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    [SerializeField] int createcount = 4;
    [SerializeField] float speed = 5f;
    [SerializeField] List<GameObject> list = new List<GameObject>();
    [SerializeField] float offset = 40.0f;

    private void Awake()
    {
        
    }
    void Start()
    {
        list.Capacity = 10;
    }

    
    void Update()
    {
        for(int i =0; i<createcount; i++)
        {
            list[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        
    }

    public void AddRoad()
    {
        GameObject newroad = list[0];

        list.Remove(newroad);

        float newZ = list[list.Count -1].transform.position.z + offset;

        newroad.transform.position = new Vector3(0,0, newZ);

        list.Add(newroad);

         
    }

    
}
