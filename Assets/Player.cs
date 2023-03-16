using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MeshRenderer _meshRenderer;


    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        float movementY = Input.GetAxis("Horizontal")*Time.deltaTime*10;
        float movementX = Input.GetAxis("Vertical")*Time.deltaTime*10;

        //challenge 01
        transform.position+=new Vector3(movementY,0,movementX);

        //challenge 02
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -1*Time.deltaTime*10,0));
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 1 * Time.deltaTime * 10, 0));
        }

        //challenge 03
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale=new Vector3(transform.localScale.x+0.1f, transform.localScale.y+0.1f, transform.localScale.z+0.1f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.1f, transform.localScale.y - 0.1f, transform.localScale.z - 0.1f);
        }

        //challenge 04
        if (Input.GetKeyDown(KeyCode.R))
        {
            _meshRenderer.material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            _meshRenderer.material.color = Color.red;
        }

    }

    //challenge 05
    private void OnCollisionEnter(Collision collision)
    {
        MeshRenderer objectMesh=collision.gameObject.GetComponent<MeshRenderer>();

        _meshRenderer.material.color = objectMesh.material.color;
    }
}
