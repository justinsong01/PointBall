using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour {

	public float speed;
	private Rigidbody Sphere;
    private int count;
    public Text countText;
    public Text winMessage;

	// Use this for initialization
	void Start () {
		Sphere = GetComponent<Rigidbody>();
        count = 0;
        setCountBall ();
        winMessage.text = "";
	}

	// Update is called once per frame
	void Update () {
		float horizontalPoint = Input.GetAxis ("Horizontal");
		float verticalPoint = Input.GetAxis ("Vertical");
		Vector3 movePoint = new Vector3 (horizontalPoint, 1.0f, verticalPoint);
		speed = 5.3f;
		Sphere.AddTorque(movePoint * speed * Time.deltaTime);
		Sphere.AddForce (movePoint * speed);
        //Debug.Log ("Time" + Time.deltaTime);
        if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PointCapsule"))
        {
            other.gameObject.SetActive(false);
            count++;
            if (count == 5)
            {
                winMessage.text = "You Win!";
            }
        }
        setCountBall ();
    }

    void setCountBall ()
    {
        countText.text = "Point: " + count.ToString();

    }
}
