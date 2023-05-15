using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        StartCoroutine(DeswpawnBullet());
    }
    IEnumerator DeswpawnBullet()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
