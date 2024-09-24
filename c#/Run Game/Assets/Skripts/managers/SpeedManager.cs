using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : SingleTon<SpeedManager>
{
    [SerializeField] float speed = 30f;
    [SerializeField] float limitSpeed = 75f;
    [SerializeField] float incraseValue = 5f;

    WaitForSeconds waitforSeconds = new WaitForSeconds(10);

    public float Speed
    {
        get {return speed;}
    }

    public IEnumerator Increase()
    {
        while(speed < limitSpeed)
        {
            yield return waitforSeconds;

            speed += incraseValue;
        }
    }

}
