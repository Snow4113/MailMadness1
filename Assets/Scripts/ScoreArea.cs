using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreArea : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Package"))
        {
            Destroy(collision.gameObject);
            ScoreController.instance.AddPoint();
        }
    }
}
