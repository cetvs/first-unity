using UnityEngine;

// namespace DefaultNamespace
// {
public class Move : MonoBehaviour {
    
    public GameObject Sphere;
    public Rigidbody2D rb;
    public Vector2 moveVector;

    void OnStart()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void OnUpdate()
    {
        MoveAction();
    }

    void MoveAction()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        
    }
}
// }