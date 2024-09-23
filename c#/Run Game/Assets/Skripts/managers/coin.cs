using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour , Icolliderable
{
    [SerializeField] float speed = 15f;
    [SerializeField] GameObject rotationgameobject;

    [SerializeField] ParticleSystem particleSystem;

    public void Activate()
    {
        particleSystem.Play();

        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnEnable()
    {
        rotationgameobject = GameObject.Find("rotation Gameobject");

        speed = rotationgameobject.GetComponent<RotationObject>().Speed;

        transform.localRotation = rotationgameobject.transform.localRotation;
    }


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }

    }
}
