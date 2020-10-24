using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   
    private void Start()
    {
        CreatePeixe(4f, -2f);
    }





    private void CreatePeixe(float posicaoX, float posicaoY)
    {

        GameObject peixe = Instantiate(GameAssets.GetInstance().PeixeLaranjaGO);
        peixe.transform.position = new Vector2(posicaoX, posicaoY);
    }

}
