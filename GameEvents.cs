﻿namespace ACT.DFAssist
{
    public enum GameEvents
    {
        None,

        InstanceEnter,  // [0] = instance code
        InstanceLeave,  // [0] = instance code

        FateBegin,      // [0] = fate code
        FateProgress,   // [0] = fate code, [1] = progress
        FateEnd,        // [0] = fate code, [1] = status(?)

        MatchBegin,     // [0] = match type(0,1), [1] = roulette code or instance count, [...] = instance
        MatchOrder,     // [0] = order
        MatchStatus,    // [0] = match type(2,3), [1] = instance code, [2] = status 
                        //  Deprecate   [3] = tank, [4] = healer, [5] = dps
                        //  Current     [6] = maxtank, [7] = maxhealer, [8] = maxdps
        MatchDone,      // [0] = roulette code, [1] = instance code
        MatchEnd,       // [0] = end reason <MatchEndType>
        MatchCancel,
    }

    public enum MatchResult
    {
        Cancel = 0,
        Enter = 1,
    }

    public enum MatchType
    {
        Roulette = 0,
        Assignment = 1,

        ShortStatus = 2,    // 사실상 5.1 이전 정보 Deprecated
        LongStatus = 3,     // 사실상 5.1 부터 정보 Current
    }

    public enum MatchStatus
    {
        Idle,
        Queued,
        Matched,
    }

    public enum ClientType
    {
        Global,
        Korea,
        China,
    }
}
