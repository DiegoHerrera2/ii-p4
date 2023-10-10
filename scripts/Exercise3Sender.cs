using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3Sender : MonoBehaviour
{
    public delegate void Notification();
    public event Notification OnApproachCylinder;
    public float distanceForEvent = 10f;
    public GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cylinderDistance = Vector3.Distance(transform.position, cylinder.transform.position);

        if (cylinderDistance <= distanceForEvent) OnApproachCylinder?.Invoke();
    }
    

}
