using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    [SerializeField] float raidius;
    [SerializeField] float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f )
        {
            InRadius(transform.position, raidius);
            timer = 0f;
        }
    }

    void InRadius(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
                {
                Debug.Log(hitCollider.gameObject.name);
                }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, raidius);
    }
}