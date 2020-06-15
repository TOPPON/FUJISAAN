using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    Vector3 firstposition;
    float rolltime;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(2f,2.1f), 0, 0);
        firstposition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rolltime += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.position = firstposition;
            rb.velocity = new Vector3(Random.Range(2f, 2.1f), 0, 0);
            rolltime = 0;
        }
    }
    public float nowtime()
    {
        return rolltime;
    }
}
