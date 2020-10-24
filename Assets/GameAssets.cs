using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;
    private static GameObject gameObjectInstance;

    public static GameAssets GetInstance()
    {
        return instance;
    }

    public static GameObject GetgameObjectInstance()
    {
        return gameObjectInstance;
    }

    private void Awake()
    {
        instance = this;
    }

    public Sprite []PeixeSpritesLaranja;
    public GameObject PeixeLaranjaGO;
    public GameObject CarangueijoLaranjaGO;

}
