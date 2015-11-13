﻿﻿/*
     Copyright 2015 Terso Solutions, Inc.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

using System;
using System.Web;

namespace TersoSolutions.Jetstream.SDK.Application.Model
{
    /// <summary>
    /// RemoveLogicalDevice removes a logical device from the Jetstream. 
    /// Devices removed will no longer publish events or allow commands to be queued. 
    ///
    /// Request class for RemoveLogicalDeviceRequest
    /// </summary>
    /// <remarks></remarks>
    public class RemoveLogicalDeviceRequest : JetstreamRequest
    {
        private const string _removeLogicalDevice = "v1.5/application/?action=removelogicaldevice&accesskey={0}&logicaldeviceid={1}";

        /// <summary>
        /// The LogicalDeviceId of the device you want to remove from Jetstream
        /// </summary>
        public string LogicalDeviceId { get; set; }

        internal override string BuildUri(string baseUri, string accesskey)
        {
            // build the uri
            return String.Concat(baseUri, String.Format(_removeLogicalDevice,
                accesskey, HttpUtility.UrlEncode(LogicalDeviceId)));
        }
    }
}