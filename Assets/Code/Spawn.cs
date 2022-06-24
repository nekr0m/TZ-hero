using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Lwl lwl;
    [SerializeField] Admin Adm;
    [SerializeField] GameObject GG;
    [SerializeField] GameObject _enemy;
    [SerializeField] Enemy Enm;
    [SerializeField] Transform[] _points;
    float SpawnTimer;
    int SpawnCount;
    int CountLimit;
    void Awake()
    {
        Enm.GG = GG;
        Enm.Adm = Adm;
        SpawnTimer = 1;
        CountLimit = 5;
    }
    void Update()
    {
        if (Time.timeScale > 0 && SpawnCount < CountLimit)
        {
            SpawnTimer -= Time.deltaTime;
            if (SpawnTimer <= 0)
            {
                if (CountLimit - SpawnCount >= lwl.MyLwl)
                {
                    for (int i = 0; i < lwl.MyLwl; i++)
                    {
                        SpawnEnemy();
                    }
                }
                else
                {
                    int NewLimit = CountLimit - SpawnCount;
                    for (int i = 0; i < NewLimit; i++)
                    {
                        SpawnEnemy();
                    }
                }
                SpawnTimer = 1;
            }
        }
    }
    void SpawnEnemy()
    {
        Instantiate(_enemy, _points[SpawnCount]);
        SpawnCount++;
        Adm.AddEnemy();
    }
}
