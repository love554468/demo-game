 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line1 : MonoBehaviour
{
    // public float moveSpeed = 0.5f;
    public float xDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //type a return -1 sang trái , type d return   1 sang phải  
        xDir = Input.GetAxisRaw("Horizontal");
        //Debug.Log(xDir);
        float moveStep = 10f * xDir * Time.deltaTime; 
        if ((transform.position.x <= -8f && xDir < 0) || (transform.position.x >= 8f && xDir > 0)) // kiểm tra điều kiện 
            return;
            //di chuyển giá đỡ theo vector
        transform.position +=  new Vector3(moveStep, 0, 0);
    }
}
