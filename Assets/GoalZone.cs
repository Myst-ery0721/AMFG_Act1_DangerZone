using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GoalZone : MonoBehaviour
{
    public GameObject Text;
    public Transform target;
    void Update()
    {
        if (target != null)
        {
            var distance = Mathf.Sqrt(Mathf.Pow(target.position.x - this.transform.position.x, 2)
                + Mathf.Pow(target.position.y - this.transform.position.y, 2));
            var vectorDist = Vector3.Distance(target.position, this.transform.position);
            Debug.Log($"Distance {distance:F2}, Vector {vectorDist:F2}");
            
            if (distance <= 1)
            {
                Text.SetActive(true);
            }
        }
        

    }
}
