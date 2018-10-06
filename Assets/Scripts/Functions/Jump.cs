using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float time = 0;
    private float energy = 0;

    public void Physics(Rigidbody2D rb, float axis, float energyAccumRate, float maxSpeed)
    {
        //TODO if foot touch something
        float speed = Mathf.Sqrt(2*Charge(axis,energyAccumRate)/rb.mass);
        speed = Mathf.Min(speed, maxSpeed);
        rb.velocity = rb.velocity + new Vector2(0, speed);
    }

    public void Graphics()
    {
    }

    private float Charge(float axis, float AccumRate)
    {
        if(axis > 0)
        {
            time += axis*Time.fixedDeltaTime;
        }
        else
        {
            energy = AccumRate * time;
            time = 0;
        }
        return energy;
    }
}
