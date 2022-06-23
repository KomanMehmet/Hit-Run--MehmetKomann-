using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public InputManager inputManager;
    public float projectileSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }
}
