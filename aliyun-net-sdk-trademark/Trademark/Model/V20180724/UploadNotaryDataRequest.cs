/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class UploadNotaryDataRequest : RpcAcsRequest<UploadNotaryDataResponse>
    {
        public UploadNotaryDataRequest()
            : base("Trademark", "2018-07-24", "UploadNotaryData", "trademark", "openAPI")
        {
        }

		private string uploadContext;

		private string bizOrderNo;

		private int? notaryType;

		public string UploadContext
		{
			get
			{
				return uploadContext;
			}
			set	
			{
				uploadContext = value;
				DictionaryUtil.Add(QueryParameters, "UploadContext", value);
			}
		}

		public string BizOrderNo
		{
			get
			{
				return bizOrderNo;
			}
			set	
			{
				bizOrderNo = value;
				DictionaryUtil.Add(QueryParameters, "BizOrderNo", value);
			}
		}

		public int? NotaryType
		{
			get
			{
				return notaryType;
			}
			set	
			{
				notaryType = value;
				DictionaryUtil.Add(QueryParameters, "NotaryType", value.ToString());
			}
		}

        public override UploadNotaryDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadNotaryDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
