//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2019年5月27日 13:13:10
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using MongoDB.Bson.Serialization;
using UnityEngine;

namespace ET
{
    public class UnitAttributesDataRepositoryComponent : Entity, IAwake
    {
        public Dictionary<long, UnitAttributesDataSupportor> AllUnitAttributesBaseDataDic =
            new Dictionary<long, UnitAttributesDataSupportor>();
    }
}