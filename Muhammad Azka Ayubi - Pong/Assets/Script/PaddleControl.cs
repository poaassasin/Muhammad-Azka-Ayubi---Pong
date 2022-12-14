using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{   
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MoveObject(GetInput());
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return Vector2.up*speed;
        }
        else if (Input.GetKey(KeyCode.S)) {
            return Vector2.down*speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
