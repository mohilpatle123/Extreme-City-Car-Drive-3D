using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 80f;
    public float brakePower = 5f;

    float move;
    float turn;

    void Update()
    {
        move = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * move * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space))
        {
            speed -= brakePower * Time.deltaTime;
        }
    }
}
