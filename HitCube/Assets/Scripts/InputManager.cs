using UnityEngine;


public class InputManager : MonoBehaviour
{
    Touch touch;
    public Projectile projectile;

    [HideInInspector] public bool isShotAvailable = true;

    [HideInInspector] public Vector3 fingerPosition;

    public void All_Input()
    {
        
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            

            if (touch.phase == TouchPhase.Began && isShotAvailable)
            {
                Projectile.Instance.Created_Projectile();
            }
        }
     }
}
