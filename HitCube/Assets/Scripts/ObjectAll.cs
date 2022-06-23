using UnityEngine;


public class ObjectAll : MonoBehaviour
{
    MeshRenderer objectMR;
    public GameObject objectPrefab;


    private void Awake()
    {
        objectMR = objectPrefab.GetComponent<MeshRenderer>();


        if (objectPrefab.GetComponent<ObjectAll>() == null)
        {
            objectPrefab.AddComponent<ObjectAll>();
        }
        if (objectPrefab.GetComponent<Rigidbody>() == null)
        {
            objectPrefab.AddComponent<Rigidbody>();
            
        }
        objectPrefab.GetComponent<Rigidbody>().useGravity = false;
        objectPrefab.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        objectPrefab.GetComponent<Collider>().material = new PhysicMaterial();
        objectPrefab.GetComponent<Collider>().isTrigger = true;
    }


    private void Set_Color(Color color)
    {
        objectMR.material.color = color;
    }

    public void Color_Changer(ObjectAll obj)
    {
        obj.Set_Color(new Color(Random.value, Random.value, Random.value, 100f));
    }
}



