using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back*Time.deltaTime*speed,Space.World);
    }
}
