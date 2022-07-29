using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float flySpeed = 5;

    public float yawAmount = 120;

    private float yaw;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += transform.forward * flySpeed * Time.deltaTime;

        float hortizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        yaw += hortizontalInput * yawAmount * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(hortizontalInput)) * -Mathf.Sign(hortizontalInput);

        transform.localRotation = Quaternion.Euler(Vector3.up * yaw);
        transform.localRotation = Quaternion.Euler(Vector3.up * yaw + Vector3.right * pitch);
        

    }
}
