using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    [SerializeField] int createcount = 4;
    [SerializeField] float speed = 5f;
    [SerializeField] List<GameObject> roads = new List<GameObject>();
    [SerializeField] float offset = 40.0f;

    private void Awake()
    {
        
    }
    void Start()
    {
        roads.Capacity = 10;
    }

    void AddRoad()
    {
        for(int i =0; i< roads.Count; i++)
        {
            roads.Add(transform.GetChild(i).gameObject);
        }
    }

    
    void Update()
    {
        for(int i =0; i<createcount; i++)
        {
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        
    }

    public void NewPosition()
    {
        GameObject newroad = roads[0];

        roads.Remove(newroad);

        float newZ = roads[roads.Count - 1].transform.position.z + offset;

        newroad.transform.position = new Vector3(0, 0, newZ);

        roads.Add(newroad);
    }

   

    
}
