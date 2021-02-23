using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    Vector3 direction = new Vector3(0,0, 0);

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = new Vector3(0, 0, 0);
        
    }

    private void Update()
    {
        direction = new Vector3(1 * Input.GetAxis("Horizontal"), 1 * Input.GetAxis("Vertical"), 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.transform.position += Time.deltaTime * speed * direction;
    }
}