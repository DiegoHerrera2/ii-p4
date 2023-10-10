using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2Sender : MonoBehaviour
{
    public delegate void Notification();
    public event Notification OnCollideWithTag1;
    public event Notification OnCollideNotWithTag1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.CompareTag("GrupoEsfera1"))
        {
            OnCollideWithTag1?.Invoke();
        }
        else OnCollideNotWithTag1?.Invoke();
    }
}
