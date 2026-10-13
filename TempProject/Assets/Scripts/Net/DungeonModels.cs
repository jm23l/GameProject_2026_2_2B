using System;

[Serializable]
public class DungeonPlayerDate
{
    public int id;

    public string name;

    public int level;
    public int hp;
    public int maxhp;
    public int attack;
    public int gold;

}

[Serializable]
public class DungeonRoomDate
{
    public int index;
    public string type;
    public string state;
    public string monsterName;
    public int monsterHp;
    public int monsterAttack;
    public int rewardGold;

}

[Serializable]
public class DungeonStateData
{
    public DungeonPlayerDate player;
    public DungeonRoomDate room;
}

[Serializable]
public class DungeonResponse
{
    public bool success;
    public string code;
    public string message;

}

[Serializable]
public class DungeonActionRequest
{
    public string action;
}