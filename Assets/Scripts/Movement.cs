using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float MaxSpeedX = 10;
    public float MaxForceX = 10;
    public float MaxForceY = 20;
    public float EnergyAccumRate = 100;
    public float MaxJumpSpeed = 15;
    public string HorizontalAxis = "Horizontal";
    public string JumpAxis = "Jump";


    private Rigidbody2D rgBody;
    private SpriteRenderer sprRenderer;
    private MoveX moveX;
    private Jump jump;

    void Start()
    {
        rgBody = gameObject.GetComponent<Rigidbody2D>();
        sprRenderer = gameObject.GetComponent<SpriteRenderer>();
        moveX = gameObject.AddComponent<MoveX>();
        jump = gameObject.AddComponent<Jump>();
    }

    void FixedUpdate()
    {
        moveX.Physics(rgBody, Input.GetAxis(HorizontalAxis) * MaxForceX, MaxSpeedX);
        moveX.Graphics(sprRenderer, Input.GetAxis(HorizontalAxis));

        jump.Physics(rgBody, Input.GetAxis(JumpAxis), EnergyAccumRate, MaxJumpSpeed);
        jump.Graphics();
    }
}
