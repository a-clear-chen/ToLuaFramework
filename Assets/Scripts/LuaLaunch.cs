using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class LuaLaunch : LuaClient
{
    protected override LuaFileUtils InitLoader()
    {
        return new LuaResLoader();
    }

    protected override void LoadLuaFiles()
    {
    #if UNITY_EDITOR
        luaState.AddSearchPath(Application.dataPath + "Scripts/Lua");
    #endif
        OnLoadFinished();
    }
}
