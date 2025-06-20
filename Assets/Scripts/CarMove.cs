using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] float speed = 3.0f;

    void Update()
    {
        float rotateMouse = Input.GetAxis("Mouse X");

        transform.Rotate(0, rotateMouse, 0);  

        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
     
    }
}
