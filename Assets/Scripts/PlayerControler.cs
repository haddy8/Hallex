using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]private int speed;
    [SerializeField]private int speedRotate;
    private float vertical;
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical=Input.GetAxis("Vertical");
        horizontal=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*vertical);
        transform.Rotate(Vector3.up*Time.deltaTime*speedRotate*horizontal);
       /* if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
        }
                if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back*Time.deltaTime*speed);
        }
                if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*Time.deltaTime*speed);
        }
                if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*Time.deltaTime*speed);
        }*/
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Coin")
        {
              Destroy(other.gameObject);
        }
        if (other.gameObject.tag=="Up")
        {
            transform.localScale=transform.localScale+new Vector3(1,1,1);
              Destroy(other.gameObject);        
        }
        if (other.gameObject.tag=="Died")
        {
              Destroy(other.gameObject) ;        
                SceneManager.LoadScene("Game");
        }
    }
}
