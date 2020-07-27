using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFacing : MonoBehaviour
{
    
    RaycastHit RayHit;
    public float ZLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //raycast form the mouse screen position. If the raycast hits an object and the object is further away from the camera than ZLimit, point the Cannon towards it.
        if (Physics.Raycast(ray, out RayHit))
            if (RayHit.point.z > ZLimit)
                transform.forward = new Vector3(RayHit.point.x, RayHit.point.y, 0) - transform.position;
    }
}
