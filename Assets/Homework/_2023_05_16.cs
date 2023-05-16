using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class _2023_05_16 : MonoBehaviour
{
    [SerializeField]
    private Bullet bulletPrefab;
    private Transform tankTurret;
    private Rigidbody rb;
    private Vector3 muzzlePoint;
    private Stack<Bullet> bullets = new Stack<Bullet>();
    private AudioSource fireSound;
    public GameObject camera1;
    public GameObject camera2;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        tankTurret = transform.GetChild(0).GetChild(3);
        fireSound = GetComponent<AudioSource>();
    }

    private void OnFire(InputValue value)
    {
        muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);
        if (bullets.Count == 0)
        {
            bullets.Push(Instantiate(bulletPrefab, muzzlePoint, tankTurret.rotation));
            bullets.Peek().GetFireer(this);
        }
        else
        {
            bullets.Peek().transform.position = muzzlePoint;
            bullets.Peek().transform.rotation = tankTurret.rotation;
            bullets.Pop().gameObject.SetActive(true);
        }
        fireSound.Play();
    }
    public void RetrieveBullet(Bullet bullet)
    {
        bullets.Push(bullet);
    }
    private void OnAim(InputValue value)
    {
        if (value.isPressed)
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
        }
        else
        {
            camera2.SetActive(false);
            camera1.SetActive(true);
        }
    }
    // ��ź �÷��̾�� ��ź �浹 ����
    // �÷��̾�� ��ź�� ���̾ ���� ����
    // project settings > physics �� layer collision matrix bullet �� bullet �׸��� bullet player �κ� üũ ����

    // ��ź �ڵ�
    //[RequireComponent(typeof(Rigidbody))]
    //public class Bullet : MonoBehaviour
    //{
    //    [SerializeField]
    //    private float bulletSpeed;
    //    private Rigidbody rb;
    //    [SerializeField]
    //    private ParticleSystem explosionEffect;
    //    private AudioSource shellExplosionSound;
    //    //TODO: _2023_05_16�� Player ��ũ��Ʈ��
    //    private _2023_05_16 firer;
    //    private void Awake()
    //    {
    //        rb = GetComponent<Rigidbody>();
    //        explosionEffect = GetComponentInChildren<ParticleSystem>();
    //        shellExplosionSound = GetComponent<AudioSource>();
    //    }
    //    private void Start()
    //    {
    //        rb.velocity = transform.forward * bulletSpeed;
    //        StartCoroutine(DeswpawnBullet());
    //    }
    //    private void OnEnable()
    //    {
    //        rb.velocity = transform.forward * bulletSpeed;
    //        StartCoroutine(DeswpawnBullet());
    //    }
    //    IEnumerator DeswpawnBullet()
    //    {
    //        yield return new WaitForSeconds(5f);
    //        firer.RetrieveBullet(this);
    //        gameObject.SetActive(false);
    //    }
    //    private void OnCollisionEnter(Collision collision)
    //    {
    //        explosionEffect.gameObject.SetActive(true);
    //        explosionEffect.Play();
    //        AudioSource.PlayClipAtPoint(shellExplosionSound.clip, transform.position);
    //        firer.RetrieveBullet(this);
    //        gameObject.SetActive(false);
    //    }
    //    //TODO: _2023_05_16�� Player ��ũ��Ʈ��
    //    public void GetFireer(_2023_05_16 fireer)
    //    {
    //        this.firer = fireer;
    //    }
    //}
}
