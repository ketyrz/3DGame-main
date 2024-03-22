using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour
{
    public GameObject orangeModel;
    public Transform spawnPoint;

    public float force;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var orangeObject = Instantiate(orangeModel, spawnPoint.position, Quaternion.identity);
            Rigidbody orangeRB = orangeObject.GetComponent<Rigidbody>();

            orangeRB.AddForce(spawnPoint.forward * force);
        }
    }
}
