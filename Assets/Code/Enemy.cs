using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject GG;
    public Admin Adm;
    [SerializeField] Rigidbody Rig;
    int Xpos;
    int Zpos;
    int Speed;
    void Awake()
    {
        Speed = 15;
    }
    void Update()
    {
        if (GG.transform.position.x > transform.position.x)
        {
            Xpos = 1;
        }
        else Xpos = -1;
        if (GG.transform.position.z > transform.position.z)
        {
            Zpos = 1;
        }
        else Zpos = -1;
    }
    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(Xpos, 0, Zpos);

        Rig.AddForce(Movement * Speed);
    }
    private void OnCollisionEnter(Collision body)
    {
        if (body.gameObject.tag == "Trap")
        {
            Adm.KillEnemy();
            Destroy(gameObject);
        }
    }
}
