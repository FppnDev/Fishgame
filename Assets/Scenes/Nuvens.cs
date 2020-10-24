using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvens : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.3f;
    public float limiteX;
    public float inicioX;
    public float inicioY;

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
        
        if(gameObject.transform.position.x <= limiteX)
        {
            gameObject.transform.position = new Vector2(inicioX, inicioY); 
        }

    }


}
