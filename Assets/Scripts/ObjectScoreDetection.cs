using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScoreDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Fruit"))
        {
            GameManager.UpdateScore(1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Fruit"))
        {
            GameManager.UpdateScore(-1);
        }
    }
}
