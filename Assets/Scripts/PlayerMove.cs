using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDir;
    [SerializeField]
    [Range(0, 10)]
    private float moveSpeed;
    [SerializeField]
    [Range(0, 10)]
    private float jumpPower;
    [SerializeField]
    [Range(0, 30)]
    private float rotateSpeed;
    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }
    public void Move()
    {
        //rb.AddForce(moveDir * moveSpeed);
        //print(moveDir);
        //transform.position += moveSpeed * moveDir * Time.deltaTime;
        //transform.Translate(moveSpeed * moveDir * Time.deltaTime);
        // x : 1m/s   deltatime = 1/s 단위시간 한프레임당 걸리는 시간
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed);
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }
}
