using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollBehaviour : MonoBehaviour
{
    private Rigidbody[] rg;
    private Collider[] rgColliders;

    public bool isRagdoll;
    void Start()
    {
        rg = GetComponentsInChildren<Rigidbody>();
        rgColliders = GetComponentsInChildren<Collider>();
    }

    void Update()
    {
        SetRagDollEnable(isRagdoll);
    }

    public void SetRagDollEnable(bool enabled)
    {
        foreach (Rigidbody rb in rg)
        {
            rb.isKinematic = enabled;
        }
        foreach (Collider col in rgColliders)
        {
            col.enabled = !enabled;
        }
    }
}
