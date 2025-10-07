using UnityEngine;

public class EnemyPingPong : MonoBehaviour
{
    [SerializeField] float min = 2f;
    [SerializeField] float max = 3f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 3;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 4, max - min) + min, transform.position.y, transform.position.z);
    }
}
