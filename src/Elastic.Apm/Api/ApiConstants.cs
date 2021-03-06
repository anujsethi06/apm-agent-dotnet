// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

namespace Elastic.Apm.Api
{
	public struct ApiConstants
	{
		public const string TypeRequest = "request";

		public const string ActionExec = "exec";
		public const string ActionQuery = "query";

		public const string SubtypeHttp = "http";
		public const string SubtypeMssql = "mssql";
		public const string SubtypeSqLite = "sqlite";
		public const string SubtypeMySql = "mysql";
		public const string SubtypeOracle = "oracle";
		public const string SubtypePostgreSql = "postgresql";

		public const string TypeDb = "db";
		public const string TypeExternal = "external";
	}
}
