using System;

[Serializable] // 직렬화

public class Data
{
    // 각 챕터의 잠금여부를 저장할 배열
    public bool[] ChapterUnlock = new bool[5];
    public bool[] StoneList = new bool[8];
    public bool[] TutorialBooll = new bool[1];
}