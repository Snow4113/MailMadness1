using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorBelt : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;

    void Update()
    {
        for (int i = 0; i <= onBelt.Count -1; i++)
        {
            onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }

}

