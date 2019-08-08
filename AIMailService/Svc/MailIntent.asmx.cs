using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AIMailService.Svc
{
    /// <summary>
    /// MailIntent의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    // [System.Web.Script.Services.ScriptService]
    public class MailIntent : System.Web.Services.WebService
    {
        private MailAIIntent mailIntent = new MailAIIntent();
        [WebMethod]
        public string GetMailIntent(string subOrBody)
        {
            return mailIntent.GetMailIent(subOrBody);
            return "Reply:0.77777777";
        }

        [WebMethod]
        public string GetMailIntent(string subject, string body)
        {
            return mailIntent.GetMailIent(subject, body);
            //return "Reply:0.77777777"; // 답변필요: 70%
        }
    }
}
