using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float speed;
    public float maxSize;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one * speed * Time.deltaTime;
        if (transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();

        if (rb == null)
        {
            return;
        }

        var vector = other.transform.position - transform.position;
        rb.AddForce(vector * force * (1 / vector.magnitude));
    }
}
