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

using IBM.Watson.DeveloperCloud.Connection;
using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Services.Conversation.v1;
using IBM.Watson.DeveloperCloud.Services.Discovery.v1;
using IBM.Watson.DeveloperCloud.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IBM.Watson.DeveloperCloud.Examples
{
    public class ExampleCatchError : MonoBehaviour
    {
        private string _conversationUsername = "";
        private string _conversationPassword = "";
        private string _conversationUrl = "https://gateway.watsonplatform.net/conversation/api";
        private string _workspaceId = "";

        private string _discoveryUsername = "";
        private string _discoveryPassword = "";
        private string _discoveryUrl = "https://gateway.watsonplatform.net/discovery/api";

        void Start()
        {
            LogSystem.InstallDefaultReactors();

            Credentials conversationCredentials = new Credentials(_conversationUsername, _conversationPassword, _conversationUrl);
            Conversation conversation = new Conversation(conversationCredentials);
            conversation.VersionDate = "2017-05-26";
            conversation.Message(OnSuccess<object>, OnFail, _workspaceId, "");

            Credentials discoveryCredentials = new Credentials(_discoveryUsername, _discoveryPassword, _discoveryUrl);
            Discovery discovery = new Discovery(discoveryCredentials);
            discovery.VersionDate = "2016-12-01";
            discovery.GetEnvironments(OnSuccess<GetEnvironmentsResponse>, OnFail);
        }

        private void OnSuccess<T>(T resp, string customData)
        {
            Log.Debug("ExampleCatchError.OnSuccess()", "Response received: {0}", customData);
        }

        private void OnFail(RESTConnector.Error error)
        {
            Log.Error("ExampleCatchError.OnFail()", "Error received: {0}", error.ToString());
        }
    }
}
