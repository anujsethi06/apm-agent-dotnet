// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using Elastic.Apm.DiagnosticSource;
using Elastic.Apm.Logging;

namespace Elastic.Apm.AspNetFullFramework
{
	public static class AgentDependencies
	{
		public static IApmLogger Logger { get; set; }

		public static List<IDiagnosticsSubscriber> Subscribers = new List<IDiagnosticsSubscriber>();
	}
}
