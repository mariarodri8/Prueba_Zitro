using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject generator;
    public GameObject[] prefabs = new GameObject[3];
    private GameObject prefabClon;

    void Start()
    {
        prefabClon = Instantiate(prefabs[General.game - 1], generator.transform.position, Quaternion.identity);
    }
}
