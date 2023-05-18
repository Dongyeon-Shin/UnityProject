using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class _2023_05_18_PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDir;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    public void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * 0.01f);
        transform.Rotate(Vector3.up, moveDir.x * 30.0f * Time.deltaTime);
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
