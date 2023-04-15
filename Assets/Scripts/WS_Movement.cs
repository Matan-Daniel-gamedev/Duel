using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WS_Movement : MonoBehaviour
{
    Vector3 Vec;
    float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;

        if (Input.GetKey(KeyCode.W) && transform.localPosition.y < 4.5f)
        Vec.y += Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.S) && transform.localPosition.y > -4.5f)
        Vec.y -= Time.deltaTime * speed;
            
        transform.localPosition = Vec;
    }
}
