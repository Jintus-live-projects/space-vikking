using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class GameManager : MonoBehaviour
{
    [Expandable]
    public Galaxy galaxy;

    // Start is called before the first frame update
    void Start()
    {
        GameObject planetPrefab = (GameObject)Resources.Load("Prefabs/Planet", typeof(GameObject));

        foreach (Planet planet in galaxy.planets)
        {
            GeneratePlanet(planetPrefab, planet);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject GeneratePlanet(GameObject prefab, Planet planet)
    {
        float x = Mathf.Cos(Mathf.Deg2Rad * planet.positionInGalaxy.angle) * planet.positionInGalaxy.radius;
        float y = Mathf.Sin(Mathf.Deg2Rad * planet.positionInGalaxy.angle) * planet.positionInGalaxy.radius;
        GameObject planetObject = Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
        planetObject.transform.localScale = new Vector3(planet.size, planet.size, 1);
        return planetObject;
    }
}
