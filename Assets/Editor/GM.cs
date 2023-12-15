using System.Collections;
using System.Collections.Generic;
using Norlo.ExcelToArray;
using Norlo.ExcelToCS;
using UnityEditor;
using UnityEngine;

public class GM
{
    [MenuItem("Tools/ExcelToArray/导出 ", priority = -200)]
    private static void OpenInfo()
    {
      var eta=  ExcelToArray.ExportExcels();
      var c = eta.GetSheetNames();
    }
}
