using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1Sender : MonoBehaviour
{
    public delegate void notification();
    public event notification OnCubeCollide;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject == cube)
        {
            OnCubeCollide?.Invoke();
        }
    }
}
