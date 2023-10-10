using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1Listener : MonoBehaviour
{
    public Exercise1Sender cylinderCollision;
    public float force = 30f;
    
    private Renderer renderer;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        rb = gameObject.GetComponent<Rigidbody>();
        cylinderCollision.OnCubeCollide += exercise;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void exercise() {

        if (gameObject.CompareTag("GrupoEsfera1")) renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        else if (gameObject.CompareTag("GrupoEsfera2")) {
            rb.AddForce((cylinderCollision.gameObject.transform.position - transform.position) * force);
        }
    }
}
