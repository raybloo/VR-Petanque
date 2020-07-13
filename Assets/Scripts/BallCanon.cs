using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCanon : MonoBehaviour
{
    public GameObject ball;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.N))
        {
            float angle = Random.Range(30f, 75f);
            Debug.Log(angle);
            GameObject projectile = Instantiate(ball, transform.position, transform.rotation, transform);
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, Mathf.Sin(2f * Mathf.PI * angle / 360f) * speed, Mathf.Cos(2f * Mathf.PI * angle / 360f) * speed);
        }
    }
}
