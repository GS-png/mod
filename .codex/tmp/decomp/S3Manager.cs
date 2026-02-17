using System;
using System.IO;
using System.Net;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using RSG;
using SAES;
using UnityEngine;

public class S3Manager : MonoBehaviour
{
	public static S3Manager instance;

	private const string ABN = "Js23DGKu7RMNik4XECoQVkNFIW//dsZNcfyKb49RlFU";

	private const string AAK = "VvrCEe1TcUBvQeiSelndpl1Plc4FoMxddSglHA2Fe0M";

	private const string ASK = "WVbbIlYTAH37Glxvl1MSDpKPffhczwdbi5FRgkSs8mkLEuLzE6YCiouHH71vVgLS";

	private string _abnn;

	private IAmazonS3 _s3_client;

	private IAmazonS3 _client
	{
		get
		{
			if (_s3_client == null)
			{
				try
				{
					global::SAES.SAES sAES = new global::SAES.SAES();
					_abnn = sAES.ToString("Js23DGKu7RMNik4XECoQVkNFIW//dsZNcfyKb49RlFU");
					_s3_client = new AmazonS3Client(sAES.ToString("VvrCEe1TcUBvQeiSelndpl1Plc4FoMxddSglHA2Fe0M"), sAES.ToString("WVbbIlYTAH37Glxvl1MSDpKPffhczwdbi5FRgkSs8mkLEuLzE6YCiouHH71vVgLS"), RegionEndpoint.USEast2);
					sAES.init();
				}
				catch (Exception ex)
				{
					Debug.LogError("s3 manager not working");
					Debug.LogError(ex.Message);
				}
			}
			return _s3_client;
		}
	}

	private void Start()
	{
		instance = this;
		Config.upload_available = false;
	}

	public Promise<string> uploadFileToAWS3(string pFileName, byte[] pFileRawBytes)
	{
		Promise<string> promise = new Promise<string>();
		try
		{
			MemoryStream inputStream = new MemoryStream(pFileRawBytes);
			PutObjectRequest putObjectRequest = new PutObjectRequest
			{
				BucketName = _abnn,
				Key = pFileName,
				InputStream = inputStream,
				CannedACL = S3CannedACL.Private
			};
			if (_client.PutObjectAsync(putObjectRequest).WaitAndUnwrapException().HttpStatusCode == HttpStatusCode.OK)
			{
				promise.Resolve(putObjectRequest.Key);
			}
			else
			{
				promise.Reject(new Exception("Error when uploading!"));
			}
		}
		catch (WebException ex)
		{
			using (Stream stream = ex.Response.GetResponseStream())
			{
				using StreamReader streamReader = new StreamReader(stream);
				Debug.Log(streamReader.ReadToEnd());
			}
			promise.Reject(ex);
		}
		catch (Exception ex2)
		{
			promise.Reject(ex2);
		}
		return promise;
	}
}
