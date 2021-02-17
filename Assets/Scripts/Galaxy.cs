using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
    public Planet[] planets;
    // Start is called before the first frame update
    void Start()
    {
        GameObject planetPrefab = (GameObject) Resources.Load("Prefabs/Planet", typeof(GameObject));
        Debug.Log(planetPrefab);
        Instantiate(planetPrefab, new Vector2(10, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
