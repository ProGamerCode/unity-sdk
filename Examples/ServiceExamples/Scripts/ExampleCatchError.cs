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

using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Services.Conversation.v1;
using IBM.Watson.DeveloperCloud.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IBM.Watson.DeveloperCloud.Examples
{
    public class ExampleCatchError : MonoBehaviour
    {
        private string _username;
        private string _password;
        private string _url;

        void Start()
        {
            LogSystem.InstallDefaultReactors();

            Credentials credentials = new Credentials(_username, _password, _url);
            Conversation conversation = new Conversation(credentials);
            conversation.VersionDate = "2017-05-26";

            try
            {
                if(!conversation.Message(OnMessage, OnMessageFail, null, ""))
                    Log.Debug("ExampleCatchError.Start()", "Message failed!");
            }
            catch (ArgumentNullException e)
            {
                Log.Error("ExampleCatchError.Start()", "ArgumentNullException: {0}", e.Message);
            }
            catch (Exception e)
            {
                Log.Error("ExampleCatchError.Start()", "Exception: {0}", e.Message);
            }
        }

        private void OnMessage(object resp, string customData)
        {
            Log.Debug("ExampleCatchError.OnMessage()", "Response received: {0}", customData);
        }

        private void OnMessageFail(string error)
        {
            Log.Error("ExampleCatchError.OnMessage()", "Error received: {0}", error);
        }
    }
}
