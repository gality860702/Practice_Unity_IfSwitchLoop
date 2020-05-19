
using UnityEngine;
using UnityEngine.UI;

public class SliderUI : MonoBehaviour
{
    [Header("訊息拉霸")]
    public  Slider detailslider;
    [Header("訊息顯示")]
    public Text word;

   
    
      public float Hp { get { return detailslider.value; } }

    private void Update()
    {
        
       
        if (Hp >= 70)
        {
            word.text ="安全";

        }
        else if (Hp >= 20)
        {
            word.text = "警告";
        }
        else
        {
            word.text = "危險"; 
        }
     
        
    }


}
    
