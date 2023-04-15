using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownArrow_Movement : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow) && transform.localPosition.y < 4.5f)
        Vec.y += Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.DownArrow) && transform.localPosition.y > -4.5f)
        Vec.y -= Time.deltaTime * speed;
            
        transform.localPosition = Vec;
    }
}
