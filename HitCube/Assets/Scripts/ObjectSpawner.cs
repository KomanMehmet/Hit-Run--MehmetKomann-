using UnityEngine;


public class ObjectSpawner : MonoBehaviour
{
    public ObjectAll objectAll;


    public float projectileSpeed;
    [SerializeField] private int row;
    [SerializeField] private int col;
    [SerializeField] Color[] objectColors;

    [HideInInspector] public bool isChange = false;

    [SerializeField] private Transform initialPoint;



    private void Start()
    {
        Spawner();
        objectAll = FindObjectOfType<ObjectAll>();

    }

    public void Spawner()
    {

        Vector3 tempVector = Vector3.zero;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                tempVector.x = initialPoint.transform.position.x + j * initialPoint.transform.localScale.x;
                tempVector.y = initialPoint.transform.position.y + i * initialPoint.transform.localScale.y;
                tempVector.z = 0;

                ObjectAll objectSpawner = Instantiate(objectAll.objectPrefab, tempVector, Quaternion.identity, transform).GetComponent<ObjectAll>();
                objectSpawner.Color_Changer(objectSpawner);
            }
        }
    }
}
