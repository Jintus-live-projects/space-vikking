using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[System.Serializable]
public class Planet
{
    public Position positionInGalaxy = new Position(0, 0);
    public int size = 0;
    public int difficulty = 0;
}
