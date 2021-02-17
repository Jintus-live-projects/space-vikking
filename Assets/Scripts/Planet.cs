using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Planet : MonoBehaviour
{
    public Position positionInGalaxy;
    public int size;
    private Environment environement;

    public Loot[] resources;
    public int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
    }
}
