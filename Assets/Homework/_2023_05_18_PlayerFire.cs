using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class _2023_05_18_PlayerFire : MonoBehaviour
{
    public UnityEvent OnFired;
    private Transform tankTurret;
    private Vector3 muzzlePoint;
    private Stack<Shell> shells = new Stack<Shell>();
    [SerializeField]
    private Shell shellPrefab;
    public void Awake()
    {
        tankTurret = transform.GetChild(0).GetChild(3);
    }
    public void Fire()
    {
        muzzlePoint = new Vector3(tankTurret.position.x, tankTurret.position.y + 0.5f, tankTurret.position.z);

        if (shells.Count == 0)
        {
            Instantiate(shellPrefab, muzzlePoint, tankTurret.rotation).GetFireer(this);
        }
        else
        {
            shells.Peek().transform.position = muzzlePoint;
            shells.Peek().transform.rotation = tankTurret.rotation;
            shells.Pop().EnableShellRanderer();
        }
        GameManager.Data.AddShootCount(1);
        OnFired?.Invoke();
    }
    private void OnFire(InputValue value)
    {
        Fire();
    }
    public void RetrieveShell(Shell shell)
    {
        shells.Push(shell);
    }
}
