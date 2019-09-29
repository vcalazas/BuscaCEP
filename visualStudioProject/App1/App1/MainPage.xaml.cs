using App1.services;
using App1.services.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BtGo.Clicked += SearchCep;
        }

        private void SearchCep(object mSender, EventArgs mEventArgs)
        {
            try
            {
                string cep = EnCep.Text.Trim().Replace(".", "").Replace("-", "");
                if (!cep.Equals("") && cep.Length == 8 && int.TryParse(cep, out int newCep))
                {
                    Address address = ZipCode.ConsultZipCode(EnCep.Text.Trim());
                    if (address.Success)
                    {
                        message(address.minify());
                    }
                    else
                    {
                        message("CEP inválido.");
                    }
                }
                else
                {
                    message("CEP inválido.");
                }
            }
            catch (Exception) {
                message("Erro ao consultar o CEP");
            }
        }

        private void message(string mMsg)
        {
            try
            {
                LbResponse.Text = mMsg;
            }
            catch (Exception) { }
        }
    }
}
