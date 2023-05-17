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
    [Range(0, 30)]
    private float rotateSpeed;
    [SerializeField]
    Bullet bulletPrefab;
    [SerializeField]
    private Transform bulletPoint;
    private Vector3 firstPosition;
    [SerializeField]
    private float repeatTime;
    private Animator animator;
    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        firstPosition = transform.position;
    }
    private void Update()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        //rb.AddForce(moveDir * moveSpeed);
        //print(moveDir);
        //transform.position += moveSpeed * moveDir * Time.deltaTime;
        //transform.Translate(moveSpeed * moveDir * Time.deltaTime);
        // x : 1m/s   deltatime = 1/s 단위시간 한프레임당 걸리는 시간
        transform.Translate(Vector3.forward * moveDir.z * 0.01f);
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
    private void OnFire(InputValue value)
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
    }
    private Coroutine bulletRoutine;
    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
    }
    private void OnRepeatFire(InputValue value)
    {
        if(value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            StopCoroutine(bulletRoutine);
        }
    }
    public void ButtonFire()
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
    }
}
