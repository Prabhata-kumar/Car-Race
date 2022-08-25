using UnityEngine;

public class ObjectSpanwer : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public GameObject BlockPrefab;
    public float TimeBet1Wave = 1f;
    public float NextToSpawn = 2f;

    private void Update()
    {
        if (Time.time >= NextToSpawn)
        {
            SpanwingObject();
            NextToSpawn = Time.time + TimeBet1Wave;
        }

    }
    void SpanwingObject()
    {
        int Randomindex = Random.Range(0, SpawnPoint.Length);
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            if (Randomindex != i)
            {
                Instantiate(BlockPrefab, SpawnPoint[i].position, Quaternion.identity);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Get hit by box");

    }


}
