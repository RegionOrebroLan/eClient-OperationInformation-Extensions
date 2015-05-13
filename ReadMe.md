# eClient-OperationInformation-Extensions
A solution with adds/extensions to **eKlient - Driftinformation.exe**. For the moment only a **HttpWebRequestFactory** implementing System.Net.IWebRequestCreate to create a HttpWebRequest with DefaultCredentials and CookieContainer.

## To sign the EClient.OperationInformation assembly
By default the **EClient.OperationInformation** assembly is signed with the public **StrongName.Development.snk** file. If you want to sign it with another strong-name key file, put a strong-name key file named **StrongName.snk** in the **Signing** directory. The **StrongName.snk** file is git-ignored for security reasons.

## Configuration example
<pre>
&lt;?xml version="1.0" encoding="utf-8" ?&gt;
&lt;configuration&gt;
	&lt;system.net&gt;
		&lt;webRequestModules&gt;
			&lt;remove prefix="http" /&gt;
			&lt;remove prefix="http:" /&gt;
			&lt;remove prefix="https" /&gt;
			&lt;remove prefix="https:" /&gt;
			&lt;add prefix="http" type="RegionOrebroLan.EClient.OperationInformation.Net.HttpWebRequestFactory, RegionOrebroLan.EClient.OperationInformation" /&gt;
		&lt;/webRequestModules&gt;
	&lt;/system.net&gt;
&lt;/configuration&gt;
</pre>