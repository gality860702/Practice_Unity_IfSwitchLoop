
using UnityEngine;
using UnityEngine.UI;

public class drink : MonoBehaviour
{
    [Header("生命值"), Range(0, 100)]
    public int hp;
    [Header("魔量"), Range(0, 100)]
    public int mp;

    public Text text;
    public Text text2;




    private void Update()
    {
        text.text = (hp <= 50) ? "恢復血量" : "喝了也不起作用";





        text2.text = (mp <= 50) ? "恢復魔力" : "你會吃太補的";
    }
}
