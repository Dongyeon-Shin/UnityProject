using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(Rigidbody))]
//public class _2023_05_17 : MonoBehaviour
//{
//    [SerializeField]
//    private Shell shellPrefab;
//    private Transform tankTurret;
//    private Rigidbody rb;
//    private Vector3 muzzlePoint;
//    private Stack<Shell> shells = new Stack<Shell>();
//    private AudioSource fireSound;
//    public GameObject camera1;
//    public GameObject camera2;
//    private Animator animator;
//    private Vector3 moveDir;
//    private void Awake()
//    {
//        rb = GetComponent<Rigidbody>();
//        tankTurret = transform.GetChild(0).GetChild(3);
//        fireSound = GetComponent<AudioSource>();
//        animator = GetComponent<Animator>();
//    }
//    public void Fire()
//    {
//        muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);
//        animator.SetTrigger("Fire");
//        if (shells.Count == 0)
//        {
//            Instantiate(shellPrefab, muzzlePoint, tankTurret.rotation).GetFireer(this);
//        }
//        else
//        {
//            shells.Peek().transform.position = muzzlePoint;
//            shells.Peek().transform.rotation = tankTurret.rotation;
//            shells.Pop().EnableShellRanderer();
//        }
//        fireSound.Play();
//    }
//    private void OnFire(InputValue value)
//    {
//        Fire();
//    }
//    public void RetrieveShell(Shell shell)
//    {
//        shells.Push(shell);
//    }
//    private void OnAim(InputValue value)
//    {
//        if (value.isPressed)
//        {
//            camera2.SetActive(true);
//            camera1.SetActive(false);
//        }
//        else
//        {
//            camera2.SetActive(false);
//            camera1.SetActive(true);
//        }
//    }
//    private void Update()
//    {
//        Move();
//    }
//    public void Move()
//    {
//        transform.Translate(Vector3.forward * moveDir.z * 0.01f);
//        transform.Rotate(Vector3.up, moveDir.x * 30.0f * Time.deltaTime);
//    }
//    private void OnMove(InputValue value)
//    {
//        moveDir.x = value.Get<Vector2>().x;
//        moveDir.z = value.Get<Vector2>().y;
//    }
    // Build Setting ��Ȳ
    // 0. MainMenuScene
    // 1. Assignment
    // 2. SampleScene

    // �� ��ȯ �ڵ�
    //public void PressAssignmentButton()
    //{
    //    DontDestroyOnLoad(gameObject);
    //    SceneManager.LoadScene(1, LoadSceneMode.Single);
    //}

    // ��ź �ڵ�
    //public class Shell : MonoBehaviour
    //{
    //    [SerializeField]
    //    private float bulletSpeed;
    //    private Rigidbody rb;
    //    [SerializeField]
    //    private ParticleSystem explosionEffect;
    //    private AudioSource shellExplosionSound;
    //    private GameObject shellRanderer;
    //    //TODO: _2023_05_17�� Player ��ũ��Ʈ��
    //    private _2023_05_17 firer;
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
    //    //TODO: _2023_05_17�� Player ��ũ��Ʈ��
    //    public void GetFireer(_2023_05_17 fireer)
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

    // ��ź ����Ʈ �ڵ�
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
//}
