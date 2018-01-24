using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Atividade1_Xamarin
{
    public partial class ConfigPage : ContentPage
    {
        bool recebeEmails;
        String email;


        public String Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public bool Recebe
        {
            get { return recebeEmails; }
            set { recebeEmails = value; }
        }

        public ConfigPage()
        {
            InitializeComponent();
            swRecebeEmails_Switched(null, null);
        }

        public void swRecebeEmails_Switched(Object sender, EventArgs e)
        {
            if (swfCell.On)
            {
                entryEmail.IsEnabled = true;
                recebeEmails = true;
            }
            else
            {
                entryEmail.IsEnabled = false;
                recebeEmails = false;
            }
        }

        public void email_Completed(Object sender, EventArgs e)
        {
            email = entryEmail.Text;
        }

    }
}
