using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS74Framework.config.env
{
    public static class AppConfig
    {
        enum Site
        {
            Title = "Welcome to MS74 Framework",
            Logo = "Logo",
            Description = "Xây dựng MS74 Framework",
            Keywords = "MS74 | Thiết kế website | ASP.net | Xây dựng Web services",
            language = "en_US"
        }

        enum connectDatabase
        {
            sqlServer = "",
            postgresql = "",
            mysql = "",
            mongodb = ""
        }
        enum mailerConfig
        {
            service = "Gmail",
            username = "lephuhai0511@gmail.com",
            password = "SD*&JHH(**",
            mailer_from = "Vietworm <lephuhai0511@gmail.com>",
            mailer_to = "lephuhai0511@gmail.com"
        }
        enum component
        {
            admin_prefix = "admin",
            date_format = "Y-m-d",
            pagination = 10
        }
    }
}
