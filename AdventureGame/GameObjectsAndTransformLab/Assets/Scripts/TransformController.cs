using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var y = Mathf.PingPong(Time.time, 6);
        var p = new Vector3(y, x, 0);
        
        transform.position = p;
        

        // Rotate the target GameObject
        transform.Rotate(new Vector3(60, 90, 30) * Time.deltaTime);
    }
}