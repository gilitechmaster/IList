﻿using System;
using System.Collections;
public class IListTestExample
{
    public static void 결과(String info, ICollection c)
    {
        Console.Write("{0} 요소 갯수 : {1}\t", info, c.Count);
        foreach(Object o in c)
        {
            Console.Write("{0}", o);
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] 행렬 = { 0, 0, 1, 0, 0 };
        ArrayList array = new ArrayList(행렬);
        IList 수처리 = array;
        결과("1. 목록 : ", 수처리);

        수처리.Add(1);
        결과("2. 추가 : ", 수처리);

        수처리.RemoveAt(2);
        결과("3. 인덱스 [2] 삭제 : ", 수처리);

        수처리.Insert(0, 1);
        결과("5. 인덱스 [1]에 추가 : ", 수처리);

        Console.WriteLine("6. 값 2의 존재 확인 : {0}", 수처리.Contains(2));
        Console.WriteLine("7. 값 1의 위치 확인 : {0}", 수처리.IndexOf(1));

        수처리.Clear();
        결과("8. 데이터 전부 삭제 : ", 수처리);

    }
}

//https://blanedil.tistory.com/19
