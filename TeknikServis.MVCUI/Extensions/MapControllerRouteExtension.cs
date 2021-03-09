using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknikServis.MVCUI.Extensions
{
    public static class MapControllerRouteExtension
    {
        public static void Admin(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                name: "adminLogin",
                areaName: "AdminPanel",
                pattern: "admin",
                defaults: new { controller = "Admin", action = "LogIn" });

                endpoints.MapAreaControllerRoute(
                  name: "adminHome",
                  areaName: "AdminPanel",
                  pattern: "admin-home",
                  defaults: new { controller = "Home", action = "Index" });

                endpoints.MapAreaControllerRoute(
                    name: "adminList",
                    areaName: "AdminPanel",
                    pattern: "admin-list",
                    defaults: new { controller = "Admin", action = "List" });

                endpoints.MapAreaControllerRoute(
                    name: "adminForgotPassword",
                    areaName: "AdminPanel",
                    pattern: "forgot-password",
                    defaults: new { controller = "Admin", action = "ForgotPassword" });

                endpoints.MapAreaControllerRoute(
                    name: "adminLogOut",
                    areaName: "AdminPanel",
                    pattern: "logout",
                    defaults: new { controller = "Admin", action = "LogOut" });

                endpoints.MapAreaControllerRoute(
                    name: "adminPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "admin-photo-upload",
                    defaults: new { controller = "Admin", action = "PhotoUpload" });

                endpoints.MapAreaControllerRoute(
                    name: "adminNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-admin",
                    defaults: new { controller = "Admin", action = "New" });

                endpoints.MapAreaControllerRoute(
                    name: "adminDetailsById",
                    areaName: "AdminPanel",
                    pattern: "admin-details",
                    defaults: new { controller = "Admin", action = "DetailsById" });

                endpoints.MapAreaControllerRoute(
                 name: "adminPhotoUpdate",
                 areaName: "AdminPanel",
                 pattern: "admin-photo-update",
                 defaults: new { controller = "Admin", action = "PhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                    name: "adminUpdate",
                    areaName: "AdminPanel",
                    pattern: "update-admin",
                    defaults: new { controller = "Admin", action = "Update" });

                endpoints.MapAreaControllerRoute(
                   name: "adminDelete",
                   areaName: "AdminPanel",
                   pattern: "delete-admin",
                   defaults: new { controller = "Admin", action = "DeleteAdmin" });
            });
        }
        public static void Service(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "serviceList",
                  areaName: "AdminPanel",
                  pattern: "service-list",
                  defaults: new { controller = "Service", action = "List" });

                endpoints.MapAreaControllerRoute(
                    name: "serviceNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-service",
                    defaults: new { controller = "Service", action = "New" });

                endpoints.MapAreaControllerRoute(
                   name: "serviceDetails",
                   areaName: "AdminPanel",
                   pattern: "details-service",
                   defaults: new { controller = "Service", action = "ServiceDetails" });

                endpoints.MapAreaControllerRoute(
                 name: "serviceUpdate",
                 areaName: "AdminPanel",
                 pattern: "update-service",
                 defaults: new { controller = "Service", action = "ServiceUpdate" });

                endpoints.MapAreaControllerRoute(
                 name: "serviceDeleteDetails",
                 areaName: "AdminPanel",
                 pattern: "delete-service-details",
                 defaults: new { controller = "Service", action = "ServiceDeleteDetails" });

                endpoints.MapAreaControllerRoute(
                 name: "serviceDelete",
                 areaName: "AdminPanel",
                 pattern: "delete-service",
                 defaults: new { controller = "Service", action = "ServiceDelete" });
            });
        }
        public static void Fault(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
               name: "faultList",
               areaName: "AdminPanel",
               pattern: "fault-list",
               defaults: new { controller = "Fault", action = "FaultList" });

                endpoints.MapAreaControllerRoute(
                 name: "newFault",
                 areaName: "AdminPanel",
                 pattern: "fault-new",
                 defaults: new { controller = "Fault", action = "NewFault" });

                endpoints.MapAreaControllerRoute(
                name: "detailsFault",
                areaName: "AdminPanel",
                pattern: "fault-details",
                defaults: new { controller = "Fault", action = "FaultDetails" });

                endpoints.MapAreaControllerRoute(
               name: "updateFault",
               areaName: "AdminPanel",
               pattern: "fault-update",
               defaults: new { controller = "Fault", action = "FaultUpdate" });
            });
        }
        public static void Message(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute(
                    name:"adminMessageList",
                    areaName:"AdminPanel",
                    pattern:"message-list-admin",
                    defaults:new { controller= "AdminMessage", action= "MessageList" });

                endpoints.MapAreaControllerRoute(
                   name: "adminMessageDetails",
                   areaName: "AdminPanel",
                   pattern: "message-details",
                   defaults: new { controller = "AdminMessage", action = "MessageDetails" });

                endpoints.MapAreaControllerRoute(
                   name: "adminSendMessage",
                   areaName: "AdminPanel",
                   pattern: "send-message",
                   defaults: new { controller = "AdminMessage", action = "NewMessage" });

                endpoints.MapAreaControllerRoute(
                   name: "adminMessageDelete",
                   areaName: "AdminPanel",
                   pattern: "message-delete",
                   defaults: new { controller = "AdminMessage", action = "MessageDelete" });

                endpoints.MapAreaControllerRoute(
                    name:"sendMessageList",
                    areaName:"AdminPanel",
                    pattern:"send-message-list",
                    defaults: new {controller="AdminMessage",action= "SendMessageList" });

                endpoints.MapAreaControllerRoute(
                   name: "sendMessageDelete",
                   areaName: "AdminPanel",
                   pattern: "send-messages-delete",
                   defaults: new { controller = "AdminMessage", action = "SendMessageDelete" });


            });



        }

    }
}
