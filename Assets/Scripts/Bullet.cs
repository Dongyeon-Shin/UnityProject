using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    private Rigidbody rb;
    [SerializeField]
    private ParticleSystem explosionEffect;
    private AudioSource shellExplosionSound;
    //TODO: _2023_05_16을 Player 스크립트로
    private _2023_05_16 firer;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        explosionEffect = GetComponentInChildren<ParticleSystem>();
        shellExplosionSound = GetComponent<AudioSource>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        StartCoroutine(DeswpawnBullet());
    }
    private void OnEnable()
    {
        rb.velocity = transform.forward * bulletSpeed;
        StartCoroutine(DeswpawnBullet());
    }
    IEnumerator DeswpawnBullet()
    {
        yield return new WaitForSeconds(5f);
        firer.RetrieveBullet(this);
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        explosionEffect.gameObject.SetActive(true);
        explosionEffect.Play();
        AudioSource.PlayClipAtPoint(shellExplosionSound.clip, transform.position);
        firer.RetrieveBullet(this);
        gameObject.SetActive(false);
    }
    //TODO: _2023_05_16을 Player 스크립트로
    public void GetFireer(_2023_05_16 fireer)
    {
        this.firer = fireer;
    }
}
