using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class SendMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("sender_emailId", "password");
                FileUpload1.PostedFile.SaveAs(Server.MapPath(FileUpload1.FileName));
                string file = Server.MapPath(FileUpload1.FileName);
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(file);
                MailMessage mm = new MailMessage("1994dkdeepak@gmail.com", "1994dkdeepak@gmail.com", "test", "test");
                mm.Attachments.Add(attachment);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mm);
                //after send delete the file which is save by using "ileUpload1.PostedFile.SaveAs".
            }
            catch (Exception ex)
            { 
                
            }
        }
    }
}