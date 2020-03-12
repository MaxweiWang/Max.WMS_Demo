﻿using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace Max.Core.Utils.Json
{
    /// <summary>
    /// https://github.com/neuecc/MessagePack-CSharp
    /// </summary>
    public static class MessagePackUtil
    {
        public static string MpToJson(this object obj)
        {
            return MessagePackSerializer.ToJson(MessagePackSerializer.Serialize(obj)); ;
        }

        public static string MpToJson2<T>(this T t)
        {
            return MessagePackSerializer.ToJson(t);
        }

        public static T MpToObj<T>(this string obj)
        {
            return MessagePackSerializer.Deserialize<T>(MessagePackSerializer.FromJson(obj)); ;
        }
    }
}