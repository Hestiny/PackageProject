using System.Collections;
using System.Collections.Generic;
using Norlo.ExcelToArray;
using Norlo.ExcelToCS;
using TableDataConfig;
using UnityEditor;
using UnityEngine;

public class GM
{
    [MenuItem("Tools/ExcelToArray/导出 ", priority = -200)]
    private static void OpenInfo()
    {
        var eta = ExcelToArray.ExportExcels();
        var c = eta.GetSheetNames();
    }

    [MenuItem("Tools/ExcelToCS/导出 ", priority = -200)]
    private static void OpenCS()
    {
        ExcelToCS.ExportExcels();
    }

    [MenuItem("Tools/ExcelToCS/测试 ", priority = -200)]
    private static void TestCS()
    {
        var table = new TableCfg();
        var a = table.testData;
    }
}