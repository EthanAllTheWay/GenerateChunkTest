// Copyright (c) 2023 All Rights Reserved
// <author>EthanAllTheWay</author>
// <date>09/20/2023</date>
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateChunk : MonoBehaviour
{

    public List<GameObject> gameObjects = new List<GameObject>();
    private List<GameObject> chunkList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GenerateNewChunk(5, 5);
    }

    /// <summary>
    /// Method to generate a chunk using the x and z axises.
    /// </summary>
    /// <param name="length">The length along the z axis</param>
    /// <param name="width">The width along the x axis</param>
    private void GenerateNewChunk(int length, int width)
    { 
        for (int z = 0; z < length; z++) 
        {
            for (int x = 0; x < width; x++)
            {

                int randomIndex = Random.Range(0, gameObjects.Count);
                GameObject newRandomObject = Instantiate(gameObjects.ElementAt(randomIndex), 
                    new Vector3(x, 0, z), 
                    new Quaternion());
                chunkList.Add(newRandomObject);
            }
        }
    }
}
