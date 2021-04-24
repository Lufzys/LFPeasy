using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace LCU
{
	public class LCU
	{
		public static tRequest Request(RestSharp.Method method, string url, object parameter = null, DataFormat dataFormat = DataFormat.None)
		{
			string[] parameters = Parameters();
			if (parameters[0] != null || parameters[1] != null)
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(RemoteCertificate.Certificate.CertificateObj));
				RestClient restClient = new RestClient("https://127.0.0.1:" + parameters[1])
				{
					Authenticator = new HttpBasicAuthenticator("riot", parameters[0])
				};
				RestRequest request = new RestRequest(url, method, dataFormat);
				if (parameter != null)
				{
					switch (dataFormat)
					{
						case DataFormat.None:
							request.AddBody(parameter);
							break;

						case DataFormat.Json:
							request.AddJsonBody(parameter);
							break;

						case DataFormat.Xml:
							request.AddXmlBody(parameter);
							break;
					}
				}
				var result = restClient.Execute(request);
				tRequest req = new tRequest();
				req.URL = url;
				req.Content = result.Content;
				req.Status = result.StatusCode;
				return req;
			}
			return default(tRequest);
		}

		public class tRequest
        {
			public string URL;
			public string Content;
			public HttpStatusCode Status;
			public bool IsAvaible()
            {
				if(Status == HttpStatusCode.OK || Status == HttpStatusCode.Created || Status == HttpStatusCode.Accepted)
                {
					return true;
                }
                else
                {
					return false;
                }
            }
        }

		private static readonly string regexStructure = "\"--remoting-auth-token=(?'token'.*?)\" | \"--app-port=(?'port'|.*?)\"";
		public static ValueTuple<string, string> GetParameters()
		{
			string port = string.Empty, token = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_Process");
			foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject["Name"].Equals("LeagueClientUx.exe"))
				{
					foreach (object obj in Regex.Matches(managementObject["CommandLine"].ToString(), regexStructure, RegexOptions.Multiline))
					{
						Match match = (Match)obj;
						if (!string.IsNullOrEmpty(match.Groups["port"].ToString()))
						{
							port = match.Groups["port"].ToString();
						}
						else if (!string.IsNullOrEmpty(match.Groups["token"].ToString()))
						{
							token = match.Groups["token"].ToString();
						}
					}
				}
			}
			if (string.IsNullOrEmpty(port) || string.IsNullOrEmpty(token))
			{
				Console.WriteLine("[LCU] League Client is not founded!");
			}
			return new ValueTuple<string, string>(token, port);
		}

		public static string[] Parameters()
		{
			ValueTuple<string, string> parameters = GetParameters();
			string[] listParams = new string[2];
			listParams[0] = parameters.Item1;
			listParams[1] = parameters.Item2;
			return listParams;
		}

		public static bool CheckParams()
		{
			string[] LCUParams = Parameters();
			if (LCUParams[0] != string.Empty || LCUParams[1] != string.Empty)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
