using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed változó 8
    [SerializeField]
    private float _speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //laser lövedék megy felfelé
        transform.Translate(Vector3.up * _speed* Time.deltaTime);

        //ha a lövedék pozíciója > mint 8 akkor el kell puszíteni
        if (transform.position.y > 8) {
            Destroy(this.gameObject);
        }
    }
}
