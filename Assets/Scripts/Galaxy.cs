using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "Galaxy", menuName = "Galaxy")]
public class Galaxy : ScriptableObject
{
    public List<Planet> planets = new List<Planet>();
}
