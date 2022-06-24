using UnityEngine;
using UnityEngine.UI;

public class Admin : MonoBehaviour
{
    [SerializeField] GameObject _win;
    [SerializeField] GameObject _lose;
    [SerializeField] Text _enemyCount;
    int EnemysNow;
    int MaxEnemys;
    void Awake()
    {
        Time.timeScale = 0;
        MaxEnemys = 5;
        _enemyCount.text = EnemysNow + "/" + MaxEnemys + " enemys"; 
    }
    public void RunGame()
    {
        Time.timeScale = 1;
    }
    void YouWin()
    {
        Time.timeScale = 0;
        _win.SetActive(true);
    }
    public void YouLose()
    {
        Time.timeScale = 0;
        _lose.SetActive(true);
    }
    public void AddEnemy()
    {
        EnemysNow++;
        _enemyCount.text = EnemysNow + "/" + MaxEnemys + " enemys";
    }
    public void KillEnemy()
    {
        EnemysNow--;
        MaxEnemys--;
        _enemyCount.text = EnemysNow + "/" + MaxEnemys + " enemys";
        if (MaxEnemys < 1)
        {
            YouWin();
        }
    }
}
