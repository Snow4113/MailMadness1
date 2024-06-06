using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea1 : MonoBehaviour
{
    public ScoreController controller;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Package1"))
        {
            Destroy(collision.gameObject);
            controller.AddPoint();
        }
        if (collision.gameObject.CompareTag("Package2"))
        {
            Destroy(collision.gameObject);
            controller.RemovePoint();
        }
        if (collision.gameObject.CompareTag("Package3"))
        {
            Destroy(collision.gameObject);
            controller.RemovePoint();
        }
    }
}
