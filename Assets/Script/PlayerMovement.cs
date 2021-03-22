using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    public bool isTrue = false;
    public bool isTrue1 = false;
    public GameObject image;
    int life = 2;
    //public GameObject obj;
   
    public GameObject fire;
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed *horizontalInput);
        if(isTrue == true)
        {
            Destroy(image);
        }
        if(life<=0)
        {
            Invoke("delayui", 2);
            for (int i = 0;i<=59;i++)
            {
                Destroy(objects[i]);
                Instantiate(fire, objects[i].transform.position, Quaternion.identity);
            }

           
        }
    }
   public void delayui()
    {
        SceneManager.LoadScene("UI");

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            isTrue = true;
            life--;
            
        }
       
       
    }
}
