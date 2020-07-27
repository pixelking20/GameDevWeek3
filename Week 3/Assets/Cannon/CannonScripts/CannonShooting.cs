using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphereTemplate;
    public GameObject spawnedSphere;
    public float sphereSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when the fire control is spressed, we spawn the prefab infront of the Cannon. We then add a force to it's physics body.
        if (Input.GetButtonDown("Fire1")){
            spawnedSphere  = Instantiate(sphereTemplate, transform.position + transform.forward*2, Quaternion.identity);
            spawnedSphere.GetComponent<Rigidbody>().AddForce(transform.forward * sphereSpeed);
            spawnedSphere = null;
        }
    }
}
