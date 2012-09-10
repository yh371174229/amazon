/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SetIdentityNotificationTopicResult Unmarshaller
     /// </summary>
    internal class SetIdentityNotificationTopicResultUnmarshaller : IUnmarshaller<SetIdentityNotificationTopicResult, XmlUnmarshallerContext>, IUnmarshaller<SetIdentityNotificationTopicResult, JsonUnmarshallerContext> 
    {
        public SetIdentityNotificationTopicResult Unmarshall(XmlUnmarshallerContext context) 
        {
            SetIdentityNotificationTopicResult setIdentityNotificationTopicResult = new SetIdentityNotificationTopicResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return setIdentityNotificationTopicResult;
                }
            }
                        


            return setIdentityNotificationTopicResult;
        }

        public SetIdentityNotificationTopicResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SetIdentityNotificationTopicResultUnmarshaller instance;

        public static SetIdentityNotificationTopicResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SetIdentityNotificationTopicResultUnmarshaller();

            return instance;
        }
    }
}
    
