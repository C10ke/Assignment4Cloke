using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    public float rotatorSpeed = 10f;
    

    public void SetSpeed()
    {

    }

    void Start()
    {
        rotatorSpeed = PlayerPrefs.GetFloat("NEWROTATORSPEED", 50);
        
    }
    void Update()
    {
        transform.Rotate(0f, 0f, rotatorSpeed * Time.deltaTime);
    }

    public void GoGoRotator(float newSpeed)
    {
        rotatorSpeed = newSpeed;
        PlayerPrefs.SetFloat("NEWROTATORSPEED", rotatorSpeed);
    }
}

