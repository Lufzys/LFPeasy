using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LCU
{
	class RemoteCertificate
	{
		internal bool CertificateObj(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		public static readonly RemoteCertificate Certificate = new RemoteCertificate();
		static RemoteCertificateValidationCallback callback;
	}
}
