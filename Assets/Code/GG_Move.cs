using UnityEngine;

public class GG_Move : MonoBehaviour
{
    [SerializeField] Admin Adm;
    [SerializeField] Rigidbody Rig;
    Vector2 StartMove;
    int Xpos;
    int Ypos;
    int Speed;
    void Awake()
    {
        Speed = 15;
        StartMove = new Vector2(-1, -1);
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (StartMove.x == -1)
            {
                StartMove = touch.position;
            }
            if (StartMove.x > touch.position.x)
            {
                Xpos = -1;
            }
            else Xpos = 1;
            if (StartMove.y > touch.position.y)
            {
                Ypos = -1;
            }
            else Ypos = 1;
        }
        if (Input.touchCount == 0 && StartMove.x != -1)
        {
            StartMove = new Vector2(-1, -1);
            Xpos = 0;
            Ypos = 0;
        }
    }
    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(Xpos, 0, Ypos);

        Rig.AddForce(Movement * Speed);
    }
    private void OnCollisionEnter(Collision body)
    {
        if (body.gameObject.tag == "Trap" || body.gameObject.tag == "Enemy")
        {
            Adm.YouLose();
        }
    }
}
