using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Transform target;
    void Update()
    {
        if (target != null)
        {
            var distance = Mathf.Sqrt(Mathf.Pow(target.position.x - this.transform.position.x, 2)
                + Mathf.Pow(target.position.y - this.transform.position.y, 2));
            var vectorDist = Vector3.Distance(target.position, this.transform.position);
            Debug.Log($"Distance {distance:F2}, Vector {vectorDist:F2}");

            if (distance <= 2)
            {
                sprite.color = Color.red;
                Shake();
            }
            else
            {
                sprite.color = Color.black;
            }

            if (distance <= 1)
            {
                target.transform.position = Vector3.zero;
            }

        }
    }

    //private void Shake()
    //{
    //    //var newVector = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1));
    //    //this.transform.position += newVector * Time.deltaTime * 1;
    //    //this.transform.position -= newVector * Time.deltaTime * 1;


    //    //float RandomY = Random.Range(0, 5f);
    //    //this.transform.rotation = Quaternion.Lerp(transform.rotation, RandomY, 0);
    //}

    private void Shake()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        Quaternion targetRot = Quaternion.Euler(x, y, z);
        this.transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRot, Time.deltaTime * 10f);
    }
}
