using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosionEffect : MonoBehaviour
{
    private Shell shell;
    private void Awake()
    {
        shell = GetComponentInParent<Shell>();
    }
    private void OnParticleSystemStopped()
    {
        shell.RetrieveShell();
    }
}
