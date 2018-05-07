using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;

namespace ControleApp.Util
{
    public class clsEnviarEmail
    {
        public string EnviarEmail(string smtpDominio, string smtpUsuario, string smtpSenha, string smtpPorta, string EmailTo, string EmailAssunto, string EmailBody, string PatchAnexo, string ComCopia, MemoryStream pdfStream, string BrochuraJpg)
        {
            try
            {
                //var body = "<p>Email From: {0} ({1})</p><p>Mensagem:</p><p>{2}</p>";
                //var message = new MailMessage();
                //message.To.Add(new MailAddress(EmailTo));  // replace with valid value 
                //if (ComCopia != string.Empty)
                //{
                //    message.CC.Add(new MailAddress(ComCopia));
                //}
                //message.From = new MailAddress("noreply@noreply.net", "Imóvel Fantástico");  // replace with valid value
                //message.Subject = EmailAssunto;
                //message.Body = string.Format(body, smtpUsuario, "MLS", EmailBody);
                //if (PatchAnexo != string.Empty)
                //{
                //    message.Attachments.Add(new Attachment(pdfStream, PatchAnexo));
                //}
                ////if (BrochuraJpg != string.Empty)
                ////{
                ////    LinkedResource brochura = new LinkedResource(BrochuraJpg);
                ////    brochura.ContentId = "brochura";

                ////    //now do the HTML formatting
                ////    AlternateView av1 = AlternateView.CreateAlternateViewFromString(
                ////        message.Body +
                ////          "<html><body><img src=cid:brochura/>" +
                ////          "<br></body></html>",
                ////          null, MediaTypeNames.Text.Html);

                ////    //now add the AlternateView
                ////    av1.LinkedResources.Add(brochura);

                ////    //now append it to the body of the mail
                ////    message.AlternateViews.Add(av1);
                ////    //message.Attachments.Add(new Attachment(BrochuraJpg));
                ////}
                //message.IsBodyHtml = true;
                //using (var smtp = new SmtpClient(smtpDominio))
                //{
                //    //smtp.EnableSsl = false; // GMail requer SSL
                //    smtp.EnableSsl = true; // MLS nao requer SSL

                //    smtp.Port = Convert.ToInt32(smtpPorta);       // porta para SSL
                //    //smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                //    smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                //    // seu usuário e senha para autenticação
                //    smtp.Credentials = new NetworkCredential(smtpUsuario, smtpSenha);

                //    // envia o e-mail
                //    smtp.Send(message);
                //    message.Attachments.Clear();
                //    message.Dispose();
                //    smtp.Dispose();
                return "E-Mail Enviado com Sucesso";
                //}
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
