﻿using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudinaryDotNet.Actions
{
    //[DataContract]
    public class DelResResult : BaseResult
    {
        [JsonProperty(PropertyName = "deleted")]
        public Dictionary<string, string> Deleted { get; protected set; }

        [JsonProperty(PropertyName = "next_cursor")]
        public string NextCursor { get; protected set; }

        [JsonProperty(PropertyName = "partial")]
        public bool Partial { get; protected set; }

        /// <summary>
        /// Parses HTTP response and creates new instance of this class
        /// </summary>
        /// <param name="response">HTTP response</param>
        /// <returns>New instance of this class</returns>
        internal static DelResResult Parse(HttpWebResponse response)
        {
            return Parse<DelResResult>(response);
        }
    }
}
