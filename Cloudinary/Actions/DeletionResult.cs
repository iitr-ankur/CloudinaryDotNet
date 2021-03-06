﻿using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;


namespace CloudinaryDotNet.Actions
{
    /// <summary>
    /// Results of deletion
    /// </summary>
    //[DataContract]
    public class DeletionResult : BaseResult
    {
        /// <summary>
        /// Result description
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; protected set; }

        /// <summary>
        /// Parses HTTP response and creates new instance of this class
        /// </summary>
        /// <param name="response">HTTP response</param>
        /// <returns>New instance of this class</returns>
        internal static DeletionResult Parse(HttpWebResponse response)
        {
            return Parse<DeletionResult>(response);
        }
    }
}
