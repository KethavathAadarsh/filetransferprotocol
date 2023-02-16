string sourceFilePath = Request.Form["sourceFilePath"];
string destinationFilePath = Request.Form["destinationFilePath"];
string ftpServerAddress = "ftp://example.com";
string ftpUsername = "username";
string ftpPassword = "password";

FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerAddress + "/" + destinationFilePath);
request.Method = WebRequestMethods.Ftp.UploadFile;
request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

using (Stream fileStream = File.OpenRead(sourceFilePath))
using (Stream ftpStream = request.GetRequestStream())
{
    fileStream.CopyTo(ftpStream);
}

FtpWebResponse response = (FtpWebResponse)request.GetResponse();
response.Close();
