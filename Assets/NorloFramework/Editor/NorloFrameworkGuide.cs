using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NorloFrameworkGuide : EditorWindow
{
    [MenuItem("Tools/NorloFramework/导出 ")]
    private static void NorloFrameworkInfo()
    {
        var win = GetWindow<NorloFrameworkGuide>();
        win.name = "NorloFramework";
        win.minSize = new Vector2(400, 500);
        win.Show();
    }
    
    private const string _info = @"NorloFramework 是一个Unity3D的开发框架
主要包含一些休闲游戏基本的框架功能 ui管理，资源管理，事件管理，数据管理等
目前还在开发中，不断完善中

框架中的规范:
将 PascalCase 用于类名和方法名称。
将 camelCase 用于方法参数、局部变量和专用字段。
将 PascalCase 用于常量名，包括字段和局部常量。
专用实例字段以下划线（_）开头。
游戏中不推荐使用单例模式，并且也不使用单例模式 但是提供基本的单例模式的实现 推荐将游戏中的play mode options打开 这样可以加快游戏的开发速度

工具模块创建一个程序集 减少编译成本

框架中的代码都是基于Unity2019.4.0f1版本的

工具:
Full Serializer 用于序列化和反序列化 留意这个工具的枚举序列化之后是字符串 如果不喜欢这种可以尝试newtonsoft.json 替换接口即可
NPOI 用于excel的读取和写入 参考了一些luban 但是luban的代码太过于复杂了 所以自己写了一个简单的excel转数组的工具 满足基本的日常使用 需要再拓展即可

";
    
    protected void OnGUI()
    {
        GUILayout.BeginVertical();
        GUILayout.TextArea(_info);
        GUILayout.EndVertical();
    }
}