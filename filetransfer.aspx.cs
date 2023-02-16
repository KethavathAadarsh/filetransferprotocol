using System;
using System.IO;
using System.Web;

public partial class filetransfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve the source and destination file paths from the POST request
        string sourceFilePath = Request.Form["sourceFilePath"];
        string destinationFilePath = Request.Form["destinationFilePath"];

        try
        {
            // Copy the file from the source path to the destination path
            File.Copy(sourceFilePath, destinationFilePath, true);

            // Return a success response
            Response.StatusCode = 200;
        }
        catch (Exception ex)
        {
            // Return an error response with the exception message
            Response.StatusCode = 500;
            Response.Write(ex.Message);
        }

        // End the response
        Response.End();
    }
}
