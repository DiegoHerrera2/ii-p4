using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2Listener : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Exercise2Sender cubeCollision;
    public GameObject cylinder;
    public float force = 30f;
    
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        cubeCollision.OnCollideNotWithTag1 += group1Move;
        cubeCollision.OnCollideWithTag1 += growGroup2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void group1Move() {
        if (gameObject.CompareTag("GrupoEsfera1")) rb.AddForce((cylinder.transform.position - transform.position) * force);
    }
    
    void growGroup2() {
        if (gameObject.CompareTag("GrupoEsfera2")) transform.localScale += new Vector3(1,1,1);
    }
}
