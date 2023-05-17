using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class _2023_05_16 : MonoBehaviour
{
    //[SerializeField]
    //private Shell shellPrefab;
    //private Transform tankTurret;
    //private Rigidbody rb;
    //private Vector3 muzzlePoint;
    //private Stack<Shell> shells = new Stack<Shell>();
    //private AudioSource fireSound;
    //public GameObject camera1;
    //public GameObject camera2;
    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    tankTurret = transform.GetChild(0).GetChild(3);
    //    fireSound = GetComponent<AudioSource>();
    //}

    //private void OnFire(InputValue value)
    //{
    //    muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);
    //    if (shells.Count == 0)
    //    {
    //        Instantiate(shellPrefab, muzzlePoint, tankTurret.rotation).GetFireer(this);
    //    }
    //    else
    //    {
    //        shells.Peek().transform.position = muzzlePoint;
    //        shells.Peek().transform.rotation = tankTurret.rotation;
    //        shells.Pop().EnableShellRanderer();
    //    }
    //    fireSound.Play();
    //}
    //public void RetrieveShell(Shell shell)
    //{
    //    shells.Push(shell);
    //}
    //private void OnAim(InputValue value)
    //{
    //    if (value.isPressed)
    //    {
    //        camera2.SetActive(true);
    //        camera1.SetActive(false);
    //    }
    //    else
    //    {
    //        camera2.SetActive(false);
    //        camera1.SetActive(true);
    //    }
    //}
    // 포탄 플레이어와 포탄 충돌 방지
    // 플레이어와 포탄의 레이어를 각각 지정
    // project settings > physics 에 layer collision matrix bullet 과 bullet 그리고 bullet player 부분 체크 해제

    // 포탄 코드
    //public class Shell : MonoBehaviour
    //{
    //    [SerializeField]
    //    private float bulletSpeed;
    //    private Rigidbody rb;
    //    [SerializeField]
    //    private ParticleSystem explosionEffect;
    //    private AudioSource shellExplosionSound;
    //    private GameObject shellRanderer;
    //    //TODO: _2023_05_16을 Player 스크립트로
    //    private _2023_05_16 firer;
    //    private Coroutine despawnRoutine;
    //    private void Awake()
    //    {
    //        rb = GetComponent<Rigidbody>();
    //        if (explosionEffect != null)
    //        {
    //            explosionEffect = GetComponentInChildren<ParticleSystem>();
    //        }
    //        shellExplosionSound = GetComponent<AudioSource>();
    //        shellRanderer = transform.GetChild(0).gameObject;
    //    }
    //    private void OnEnable()
    //    {
    //        rb.velocity = transform.forward * bulletSpeed;
    //        despawnRoutine = StartCoroutine(Deswpawn());
    //    }
    //    IEnumerator Deswpawn()
    //    {
    //        yield return new WaitForSeconds(5f);
    //        firer.RetrieveShell(this);
    //        rb.velocity = Vector3.zero;
    //        shellRanderer.SetActive(false);
    //    }
    //    private void OnCollisionEnter(Collision collision)
    //    {
    //        StopCoroutine(despawnRoutine);
    //        explosionEffect.Play();
    //        shellExplosionSound.Play();
    //        rb.velocity = Vector3.zero;
    //        shellRanderer.SetActive(false);
    //    }
    //    //TODO: _2023_05_16을 Player 스크립트로
    //    public void GetFireer(_2023_05_16 fireer)
    //    {
    //        this.firer = fireer;
    //    }
    //    public void EnableShellRanderer()
    //    {
    //        shellRanderer.SetActive(true);
    //        rb.velocity = transform.forward * bulletSpeed;
    //        despawnRoutine = StartCoroutine(Deswpawn());
    //    }
    //    internal void RetrieveShell()
    //    {
    //        firer.RetrieveShell(this);
    //    }
    //}
    //public class ShellExplosionEffect : MonoBehaviour
    //{
    //    private Shell shell;
    //    private void Awake()
    //    {
    //        shell = GetComponentInParent<Shell>();
    //    }
    //    private void OnParticleSystemStopped()
    //    {
    //        shell.RetrieveShell();
    //    }
    //}
}
