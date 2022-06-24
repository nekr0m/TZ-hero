using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    [SerializeField] Lwl lwl;
    public void LoadScene(int num)
    {
        lwl.MyLwl = num + 1;
        SceneManager.LoadScene(num);
    }
}
