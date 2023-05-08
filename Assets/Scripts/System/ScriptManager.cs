using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


public class CSVReader
{
    // https://hungry2s.tistory.com/215
    // https://github.com/tikonen/blog/tree/master/csvreader

    static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
    static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    static char[] TRIM_CHARS = { '\"' };

    public static List<Dictionary<string, object>> Read(string file)
    {
        var list = new List<Dictionary<string, object>>();
        TextAsset data = Resources.Load(file) as TextAsset;

        var lines = Regex.Split(data.text, LINE_SPLIT_RE);

        if (lines.Length <= 1) return list;

        var header = Regex.Split(lines[0], SPLIT_RE);
        for (var i = 1; i < lines.Length; i++)
        {

            var values = Regex.Split(lines[i], SPLIT_RE);
            if (values.Length == 0 || values[0] == "") continue;

            var entry = new Dictionary<string, object>();
            for (var j = 0; j < header.Length && j < values.Length; j++)
            {
                string value = values[j];
                value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
                object finalvalue = value;
                int n;
                float f;
                if (int.TryParse(value, out n))
                {
                    finalvalue = n;
                }
                else if (float.TryParse(value, out f))
                {
                    finalvalue = f;
                }
                entry[header[j]] = finalvalue;
            }
            list.Add(entry);
        }
        return list;
    }
}

public class ScriptManager : MonoBehaviour
{
    List<Dictionary<string, object>> dialogueScript; // -> Awake에서 호출
    
    // use example
    // print("name" + dialogueScript[rowNum]["colName"]); // -> name col에 있는 0 번째 row 에 매치되는 데이터

    private void Awake()
    {
        // dialogueScript = CSVReader.Read("");  // -> Resoucres 폴더 내에 있는 경로와 파일명
    }

    public string GetScript(string colName, int rowNum)
    {
        return dialogueScript[rowNum][colName].ToString();
    }
}
