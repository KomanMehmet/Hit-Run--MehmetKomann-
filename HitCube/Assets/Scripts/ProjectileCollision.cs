using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        float randomValue = Random.Range(-40f, 40f);
        Vector3 randomDirection = Vector3.one * randomValue;

        if (gameObject.transform.CompareTag("Untagged"))
        {
            gameObject.SetActive(false);
            
            other.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection);
            other.gameObject.GetComponent<Collider>().attachedRigidbody.AddExplosionForce(50, Vector3.forward, 5f);
            Destroy(other.gameObject, 1.5f);
        }
    }
}
