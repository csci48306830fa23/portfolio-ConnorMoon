using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;

    void Update()
    {
        // Calculate the distance between the player and the mirror
        Vector3 localPlayer = mirror.InverseTransformPoint(playerTarget.position);

        transform.position = mirror.TransformPoint(new Vector3(localPlayer.x, localPlayer.y, -localPlayer.z));

        Vector3 lookatmirror = mirror.TransformPoint(new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z));
        transform.LookAt(lookatmirror);
    }
}