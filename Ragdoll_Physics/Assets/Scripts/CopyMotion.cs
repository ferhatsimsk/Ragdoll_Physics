using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint cj;

    void Start()
    {
        cj = GetComponent<ConfigurableJoint>();
    }

    void Update()
    {
        cj.targetRotation = targetLimb.rotation;
    }
}
