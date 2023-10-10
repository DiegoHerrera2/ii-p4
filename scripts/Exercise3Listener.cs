using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exercise3Listener : MonoBehaviour
{
    // Start is called before the first frame update
    public Exercise3Sender cubeApproach;
    public GameObject target;
    
    private Renderer renderer;
    private Rigidbody rb;
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        rb = gameObject.GetComponent<Rigidbody>();
        cubeApproach.OnApproachCylinder += exercise;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
    }
    
    void exercise() {
        if (gameObject.CompareTag("GrupoEsfera1")) {
            renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f),Random.Range(0f, 1f), 1f);
            rb.AddForce(Vector3.up * 10);
        }
        else if (gameObject.CompareTag("GrupoEsfera2")) {
            transform.LookAt(target.transform);
        }
    }
}
