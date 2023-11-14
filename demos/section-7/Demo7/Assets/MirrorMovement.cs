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
        Vector3 playerToMirror = mirror.position - playerTarget.position;

        // Reflect the player's position across the mirror plane
        Vector3 reflectedPlayerPos = mirror.position + Vector3.Reflect(playerToMirror, mirror.forward);

        // Set the mirror's position to the reflected player position
        playerTarget.position = reflectedPlayerPos;

        // Calculate the rotation difference between the player and the mirror
        Quaternion relativeRotation = Quaternion.Inverse(playerTarget.rotation) * mirror.rotation;

        // Apply the reflected rotation to the player
        playerTarget.rotation = Quaternion.LookRotation(-mirror.forward, mirror.up) * relativeRotation;
    }
}