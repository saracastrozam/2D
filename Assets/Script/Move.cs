using UnityEngine;


public class Move : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction;
    
    
    void Start()
    {


    }

    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
         
       
}
