using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Transform[] walls;
    public AudioSource player;
    Vector startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput = Input.GetAxis("Horizontal"); //look left and right
        // 3 F's represent x,y,z which is vector3.
        if(Input.GetKeyDown("w")) {
            Debug.Log("w pressed");
            transform.position += new Vector3(0f,0f,1f); //move forward
        if(transform.position + Vector3(0f,0f,1f) != wall.position){
        }
        }
        if(Input.GetKeyDown("a")) {
            Debug.Log("a pressed");
            transform.position += new Vector3(-1f,0f,0f); //move left
             if(transform.position + Vector3(-1f,0f,0f) != wall.position){
        }
        }
        if(Input.GetKeyDown("s")) {
            Debug.Log("s pressed");
            transform.position += new Vector3(0f,0f,-1f); // move down
             if(transform.position + Vector3(0f,0f,-1f) != wall.position){
        }
        }
        if(Input.GetKeyDown("d")) {
            Debug.Log("d pressed");
            transform.position += new Vector3(1f,0f,0f); // move right
             if(transform.position + Vector3(1f,0f,0f) != wall.position){
        }
        }
        if (transform.position == new Vector3(1f,0f,-5f))
        {
            transform.position = new Vector3(0f,1f,0f);
        
        }
    }
}
       
