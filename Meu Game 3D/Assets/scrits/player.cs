using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using vector3 = UnityEngine.Vector3;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;
     // Start is called before the first frame update
    void Start()
    {
    TryGetComponent(out rb);  
    }

    // Update is called once per frame
    void Update()
    {
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");

Vector3 direcao = new Vector3(h, 0, v);
rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode. Impulse);
    
   if(Input,GetKeyDown(KeyCode.Space)) 



if (transform. position.y < - 5)
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
  }
}