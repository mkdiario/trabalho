using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform alvo;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("player").transform;
        offset = alvo.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posFinl = alvo.position + offset;
        transform.position = alvo.position
    }
}
