using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
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
    [Range(0, 10)]
    private float rotateSpeed;
    private Vector3 firstPosition;
    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }
    private void Start()
    {
        firstPosition = transform.position;
    }
    private void Update()
    {
        Move();
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(firstPosition, transform.position);
    }
    private void Move()
    {
        rb.AddForce(moveDir * moveSpeed);
        print(moveDir);
        //transform.position += moveSpeed * moveDir * Time.deltaTime;
        // transform.Translate(moveSpeed * moveDir * Time.deltaTime);
        // x : 1m/s   deltatime = 1/s 단위시간 한프레임당 걸리는 시간
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
        transform.Rotate(Vector3.up,moveDir.x * rotateSpeed * Time.deltaTime);
    }
}
