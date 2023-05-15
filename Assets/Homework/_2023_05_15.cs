using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class _2023_05_15 : MonoBehaviour
{
    [SerializeField]
    private Bullet bulletPrefab;
    private Transform tankTurret;
    private Rigidbody rb;
    private Vector3 muzzlePoint;
    private Coroutine autoFireRoutine;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        tankTurret = transform.GetChild(0).GetChild(3);
    }

    private void OnFire(InputValue value)
    {
        muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);
        Instantiate(bulletPrefab, muzzlePoint, tankTurret.rotation);
    }
    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            autoFireRoutine = StartCoroutine(AutoFireRoutine());
        }
        else
        {
            StopCoroutine(autoFireRoutine);
        }
    }
    IEnumerator AutoFireRoutine()
    {
        while (true)
        {
            muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);
            Instantiate(bulletPrefab, muzzlePoint, tankTurret.rotation);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
