using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    private Vector3 firstPosition;
    
    PlayerMove move;
    private void Awake()
    {
        move = GetComponent<PlayerMove>();
        
    }
    private void Start()
    {
        firstPosition = transform.position;
    }
    private void Update()
    {
        move.Move();
        move.Rotate();
    }

   
}
