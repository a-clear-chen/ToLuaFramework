--主入口函数。从这里开始lua逻辑
function MainAwake()					
	print("logic start")	 		
    print("开始lua逻辑")
end

function MainUpdate()
	print("lua update")
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end