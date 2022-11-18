using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{
    public float velocityOfPlayer;

    private void FixedUpdate()
    {
        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * velocityOfPlayer;
    }
}
