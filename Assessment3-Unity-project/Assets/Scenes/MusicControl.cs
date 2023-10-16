using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private AudioSource au;//音频组件
    // Start is called before the first frame update
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        au = GetComponent<AudioSource>();//获取音频组件
    }
    public void Control(){
        if (au.isPlaying)//正在播放背景音乐时
            {
                au.enabled = false;//取消该组件
                //方式二 au.Stop();
            }
            else//未播放背景音乐时
            {
                au.enabled = true;//激活该组件
            	//方式二 au.Play();
            }
    }

    }