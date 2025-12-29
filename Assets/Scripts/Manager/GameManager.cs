using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private LuaLaunch _luaLaunch;

    void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        _luaLaunch = gameObject.AddComponent<LuaLaunch>();
    }
}
