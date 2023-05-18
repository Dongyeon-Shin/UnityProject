using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    private Rigidbody rb;
    [SerializeField]
    private ParticleSystem explosionEffect;
    private AudioSource shellExplosionSound;
    private GameObject shellRanderer;
    //TODO: _2023_05_18_PlayerFire을 Player 스크립트로
    private _2023_05_18_PlayerFire firer;
    private Coroutine despawnRoutine;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (explosionEffect != null)
        {
            explosionEffect = GetComponentInChildren<ParticleSystem>();
        }
        shellExplosionSound = GetComponent<AudioSource>();
        shellRanderer = transform.GetChild(0).gameObject;
    }
    private void OnEnable()
    {
        rb.velocity = transform.forward * bulletSpeed;
        despawnRoutine = StartCoroutine(Deswpawn());
    }
    IEnumerator Deswpawn()
    {
        yield return new WaitForSeconds(5f);
        firer.RetrieveShell(this);
        rb.velocity = Vector3.zero;
        shellRanderer.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        StopCoroutine(despawnRoutine);
        explosionEffect.Play();
        shellExplosionSound.Play();
        rb.velocity = Vector3.zero;
        shellRanderer.SetActive(false);
    }
    //TODO: _2023_05_18_PlayerFire을 Player 스크립트로
    public void GetFireer(_2023_05_18_PlayerFire fireer)
    {
        this.firer = fireer;
    }
    public void EnableShellRanderer()
    {
        shellRanderer.SetActive(true);
        rb.velocity = transform.forward * bulletSpeed;
        despawnRoutine = StartCoroutine(Deswpawn());
    }
    internal void RetrieveShell()
    {
        firer.RetrieveShell(this);
    }
}
