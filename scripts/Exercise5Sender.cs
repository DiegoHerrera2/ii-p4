using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5Sender : MonoBehaviour
{
    public delegate void PointNotification(int points);

    public GameObject player;

    public event PointNotification OnHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null || collision.gameObject != player) return;
        OnHit?.Invoke(gameObject.CompareTag("GrupoEsfera1") ? 5 : 10);
        Destroy(gameObject);
    }
}
