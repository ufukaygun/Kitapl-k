using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplık.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //Katmanlı Mimari Nedir?

        //Temel anlamda üç katmanda oluşuyor ihtiyaçlar doğrultusunda katman sayısı arttırılmaktasır.

        //Üç Katmanlı Mimari

        //1) Gösterimi (UI,Presentation) Katmanı; Son kullanıcının uygulamayla iletişim kurduğu, uygulamanın iletişim katmanıve kullanıcı arayüzüdür
        //Öncelikli amacı, kullanıcıyla bilgileri göstermek ve kullanıcıdan bilgileri toplamaktır.

        //2) Veri AKtmanı (Data Access Katmanı); VErilerimizi yöneten katmandır. Uygulama tarafından işlenen bilgilerin depolandığı ve
        //yönetildiği yerdir.(CRUD) işlemleri yapılır.

        //3) Uygulama (Business) katmanı; Ara katmanda olarak bilinen uygulama katmanıdır. Uygulamanın kalbidir.Bu katmanda, gösterim katmanında toplanan bigiler,
        //kimi zamaan veri


        //Avantajları:

    }
}
