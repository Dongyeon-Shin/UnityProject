using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class _2023_05_12 : MonoBehaviour
{
    private Rigidbody rb;
    private bool isBall = false;
    private Vector3 moveDir;
    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
        isBall = gameObject.name == "PlayableBall";
    }
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (isBall)
        {
            rb.AddForce(moveDir * 3.0f);
        }
        else
        {
            transform.Translate(Vector3.forward * moveDir.z * 0.01f);
            transform.Rotate(Vector3.up, moveDir.x * 30.0f * Time.deltaTime);
        }
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    private void OnJump(InputValue value)
    {
        rb.AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
    }
}
