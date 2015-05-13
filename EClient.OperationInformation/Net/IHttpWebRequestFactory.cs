using System;
using System.Net;

namespace RegionOrebroLan.EClient.OperationInformation.Net
{
	public interface IHttpWebRequestFactory
	{
		#region Methods

		HttpWebRequest Create(Uri uri);

		#endregion
	}
}