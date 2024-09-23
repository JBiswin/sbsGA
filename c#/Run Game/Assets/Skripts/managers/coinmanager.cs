using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmanager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> coins;
    [SerializeField] float offset = 2.5f;
    [SerializeField] int ceratecount = 16;
    [SerializeField] int positionX = 0;
    void Awake()
    {
        Create();
    }

    public void Create()
    {
        for(int i =0;  i < ceratecount; i++)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.SetParent(gameObject.transform);
            clone.transform.localPosition = new Vector3(0, 0, offset * i);
            
            clone.SetActive(false);
            
            coins.Add(clone);
            
        }

        
    }

    public void InitializePosition()
    {
        transform.localPosition = new Vector3(positionX*Random.Range(-1,2),0, 0);
    }
}
