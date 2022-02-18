using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationBack : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animatedImageObj;
    void Start()
    {
        
    }

    void Update()
    {
        animatedImageObj.sprite = animatedImages [(int)(Time.time*10)%animatedImages.Length];
    }
}
