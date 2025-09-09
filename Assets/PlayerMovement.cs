using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(h * speed * Time.deltaTime, 0, 0);
        transform.Translate(0 , v * speed * Time.deltaTime, 0);

    }
}
