using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.2f;

    Vector3 mousePosFarClipPlane;
    Vector3 mousePosNearClipPlane;
    RaycastHit raycastHit;
    readonly int layerHitNumber = 1 << 8;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosFarClipPlane = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        mousePosNearClipPlane = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
    }

    void FixedUpdate()
    {
        Vector3 mousePosFarInWorld = Camera.main.ScreenToWorldPoint(mousePosFarClipPlane);
        Vector3 mousePosNearInWorld = Camera.main.ScreenToWorldPoint(mousePosNearClipPlane);
        //Debug.DrawRay(mousePosNearInWorld, mousePosFarInWorld - mousePosNearInWorld, Color.green);
        if (Physics.Raycast(new Ray(mousePosNearInWorld, mousePosFarInWorld - mousePosNearInWorld), out raycastHit, 1000f, layerHitNumber))
        {
            rb.MovePosition(new Vector3(raycastHit.point.x, transform.position.y, transform.position.z));
        }
    }
}
