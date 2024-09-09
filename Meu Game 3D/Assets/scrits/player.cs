using System;
using System.Collections;
using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.SceneManagement;
using vector3 = UnityEngine.Vector3;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    public bool nochao;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!!nochao && collision.gameObject.tag == "chão") 
        {
            nochao = true;
        }

}

// Update is called once per frame
    void Update()
    {
 Debug.Log("UPDATE");       
float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
float v = Input.GetAxis("Vertical");// -1 pra tras, 0 nada, 1 pra frente

Vector3 direcao = new Vector3(h, 0, v);
rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode. Impulse);
    
   if (Input.GetKeyDown(KeyCode.Space) && nochao) 
   {
     rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
     nochao = false;
   }
   
if (transform. position.y <= -10)
{
    //jogador caiu
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
  }
}