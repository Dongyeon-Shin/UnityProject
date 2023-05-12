using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _2023_05_11 : MonoBehaviour
{
    private Rigidbody rigidBody;
    [SerializeField]
    [Range(0, 10)]
    private float jumpPower = 5.0f;
    private void Awake()
    {
        if (rigidBody == null)
        {
            rigidBody = GetComponent<Rigidbody>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene(1);
        }
        gameObject.name = "Player";
        rigidBody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
