using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysPlay1 : MonoBehaviour
{
    static AlwaysPlay1 _instance;
    public static AlwaysPlay1 instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AlwaysPlay1>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
     private void Awake() 
    {
    	//此脚本永不销毁，并且每次进入初始场景时进行判断，若存在重复的则销毁
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != _instance)
        {
            Destroy(gameObject);
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}