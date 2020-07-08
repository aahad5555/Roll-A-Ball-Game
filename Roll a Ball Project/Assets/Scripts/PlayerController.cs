
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        else if(other.gameObject.CompareTag("Text"))
        {
            other.gameObject.SetActive(false);
        }
    }
    void SetCountText()
    {
       // Regex r = new Regex(@" [a-z]{1,5}");
        countText.text = "Count: " + count.ToString();
        if (count >= 11)
        {
            
            winText.text = "Your score is: " + count;

        }
    }
}
