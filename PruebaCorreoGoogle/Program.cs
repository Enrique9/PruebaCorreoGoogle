using Marzam.Utiles.Comunicaciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PruebaCorreoGoogle
{
    class Program
    {

        static string servidorcorreo = ConfigurationManager.AppSettings["servidorcorreo"].ToString();
        static int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puertocorreo"].ToString());
        static string correodestino = ConfigurationManager.AppSettings["correodestino"].ToString();
        static string correode = ConfigurationManager.AppSettings["correoorigen"].ToString();
        static string usuario = ConfigurationManager.AppSettings["usuario"].ToString();
        static string password = ConfigurationManager.AppSettings["pass"].ToString();
        static bool ssl = Convert.ToBoolean(ConfigurationManager.AppSettings["autentificacionssl"].ToString());



        static void Main(string[] args)
        {
            try
            {
                Marzam.Utiles.Comunicaciones.Email email = new Email(correode, "", true, System.Net.Mail.DeliveryNotificationOptions.OnSuccess, System.Net.Mail.MailPriority.High, servidorcorreo, puerto, usuario, password, ssl);
                email.Enviar(correodestino, "", "INVITO COCAS", "INVITO COCAS");
                
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
               
            }
           

        }
    }
}
