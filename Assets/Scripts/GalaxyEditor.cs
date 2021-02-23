using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class GalaxyEditor : MonoBehaviour
{
    [Expandable]
    public Galaxy galaxy;

    List<(GameObject, Planet)> planets = new List<(GameObject, Planet)>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject planetPrefab = (GameObject)Resources.Load("Prefabs/Planet", typeof(GameObject));

        foreach (Planet planet in galaxy.planets)
        {
            planets.Add((GeneratePlanet(planetPrefab, planet), planet));
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach ((GameObject gameObject, Planet planet) value in planets)
        {
            value.gameObject.transform.position = GetPlanetPosition(value.planet);
            value.gameObject.transform.localScale = new Vector3(value.planet.size, value.planet.size, 1);
        }
    }

    GameObject GeneratePlanet(GameObject prefab, Planet planet)
    {
        GameObject planetObject = Instantiate(prefab, GetPlanetPosition(planet), Quaternion.identity);
        planetObject.transform.localScale = new Vector3(planet.size, planet.size, 1);
        return planetObject;
    }

    Vector2 GetPlanetPosition(Planet planet)
    {
        float x = Mathf.Cos(Mathf.Deg2Rad * planet.positionInGalaxy.angle) * planet.positionInGalaxy.radius;
        float y = Mathf.Sin(Mathf.Deg2Rad * planet.positionInGalaxy.angle) * planet.positionInGalaxy.radius;
        return new Vector2(x, y);
    }
}
