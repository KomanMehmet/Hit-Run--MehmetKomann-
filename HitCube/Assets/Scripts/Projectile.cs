using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public static Projectile Instance;
    public InputManager inputManager;
    public ObjectSpawner spawner;


    public GameObject[] createdObject;
    int i = 0;

    private void Awake()
    {
        Instance = this;

        ProjecTiles_Properties();
    }


    public void Created_Projectile()
    {
        inputManager.fingerPosition = Input.GetTouch(0).position;
        inputManager.fingerPosition.z = 5;

        Ray ray = Camera.main.ScreenPointToRay(inputManager.fingerPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit));
        {
            if (hit.collider == null)
            {
                return;
            }
            else
            {
                if (hit.transform.CompareTag("Untagged"))
                {
                    if (i <= createdObject.Length)
                    {
                        createdObject[i].SetActive(true);
                        createdObject[i].transform.position = hit.point + new Vector3(0, 0, -5);
                        i++;
                    }
                    if (i == createdObject.Length)
                    {
                        i = 0;
                        createdObject[i].SetActive(true);
                        createdObject[i].transform.position = hit.point + new Vector3(0, 0, -5);
                    }
                }
            }
        }
    }

    private void ProjecTiles_Properties()
    {
        for (int i = 0; i < createdObject.Length; i++)
        {
            if (createdObject[i].GetComponent<ProjectileCollision>() == null)
            {
                createdObject[i].AddComponent<ProjectileCollision>();
            }

            if (createdObject[i].GetComponent<ProjectileMovement>() == null)
            {
                createdObject[i].AddComponent<ProjectileMovement>();              
            }
            if (createdObject[i].GetComponent<ProjectileMovement>() != null)
            {
                createdObject[i].GetComponent<ProjectileMovement>().projectileSpeed = spawner.GetComponent<ObjectSpawner>().projectileSpeed;

                float scaleX = createdObject[i].transform.localScale.x;
                float scaleY = createdObject[i].transform.localScale.y;
                float scaleZ = createdObject[i].transform.localScale.z;

                Vector3 objectScale = new Vector3(scaleX / 10, scaleY / 10, scaleZ / 2);
                createdObject[i].transform.localScale = objectScale;
            }          
        }
    }
}
