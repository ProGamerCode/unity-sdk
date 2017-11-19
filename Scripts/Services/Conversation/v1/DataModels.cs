/**
* Copyright 2015 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using FullSerializer;
using System.Collections.Generic;

namespace IBM.Watson.DeveloperCloud.Services.Conversation.v1
{
    /// <summary>
    /// The mesage response.
    /// </summary>
    #region MessageResponse
    [fsObject]
    public class MessageResponse
    {
        /// <summary>
        /// The input text.
        /// </summary>
        public InputData input { get; set; }
        /// <summary>
        /// Terms from the request that are identified as intents.
        /// </summary>
        public object intents { get; set; }
        /// <summary>
        /// Terms from the request that are identified as entities.
        /// </summary>
        public object entities { get; set; }
        /// <summary>
        /// Whether to return more than one intent. true indicates that all matching intents are returned. 
        /// </summary>
        public bool alternate_intents { get; set; }
        /// <summary>
        /// State information for the conversation .
        /// </summary>
        public object context { get; set; }
        /// <summary>
        /// Output from the dialog, including the response to the user, the nodes that were triggered, and log messages.
        /// </summary>
        public object output { get; set; }
    }

    /// <summary>
    /// User input data object
    /// </summary>
    [fsObject]
    public class InputData
    {
        /// <summary>
        /// The user's input.
        /// </summary>
        public string text { get; set; }
    }
    #endregion

    #region Message Request
    /// <summary>
    /// The user's input, with optional intents, entities, and other properties from the response.
    /// </summary>
    [fsObject]
    public class MessageRequest
    {
        /// <summary>
        /// The input text.
        /// </summary>
        public InputData input { get; set; }
        /// <summary>
        /// Whether to return more than one intent. true indicates that all matching intents are returned. 
        /// </summary>
        public bool alternate_intents { get; set; }
        /// <summary>
        /// State information for the conversation .
        /// </summary>
        public object context { get; set; }
        /// <summary>
        /// Terms from the request that are identified as entities.
        /// </summary>
        public object entities { get; set; }
        /// <summary>
        /// Terms from the request that are identified as intents.
        /// </summary>
        public object intents { get; set; }
        /// <summary>
        /// Output from the dialog, including the response to the user, the nodes that were triggered, and log messages.
        /// </summary>
        public object output { get; set; }
    }
    #endregion
}
