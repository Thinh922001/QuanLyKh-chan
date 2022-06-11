using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DXApplication1
{
   public class SendMail
    {
      public static void sendMail(string from,string to,string content,string pass)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Phiếu Thanh Toán Hóa Đơn Khách Sạn Ngàn Sao";
            mail.Body = content;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new  NetworkCredential(from, pass);
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình send mail "+ex);
            }
        }
    }
}
