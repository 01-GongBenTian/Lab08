using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position;

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        position = transform.position;

        position.y = Mathf.Clamp(position.y, -4f, 4f);

        transform.position = position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
