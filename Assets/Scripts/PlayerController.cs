using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            gm.AddCoin();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Up"))
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }

        if (other.CompareTag("Down"))
        {
            Destroy(other.gameObject);
            transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        }

        Debug.Log(other.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gm.Damage();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            gm.Win();
        }

        Debug.Log(collision.gameObject);

    }
}
