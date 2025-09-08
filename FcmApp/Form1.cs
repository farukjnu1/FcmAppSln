using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FcmApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string txtTo = txtDevice.Text.Trim();
                string shortDesc = txtShortDesc.Text.Trim();
                string incidentNo = txtIncidentNo.Text.Trim();
                string description = txtDescription.Text.Trim();
                string title = txtTitle.Text.Trim();
                string text = txtText.Text.Trim();
                string str = SendNotificationFromFirebaseCloud(txtTo
                                                                , shortDesc
                                                                , incidentNo
                                                                , description
                                                                , title
                                                                , text);
                MessageBox.Show("success: " + str);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static String SendNotificationFromFirebaseCloud(
            string to
            ,string ShortDesc
            ,string IncidentNo
            ,string Description
            ,string title
            ,string text)
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "key=TEST");
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string strNJson = @"{
                    ""to"": """+to+@""",
                    ""data"": {
                        ""ShortDesc"": """+ShortDesc+ @""",
                        ""IncidentNo"": """ + IncidentNo + @""",
                        ""Description"": """ + Description + @"""
                          },
                          ""notification"": {
                                        ""title"": """ + title + @""",
                            ""text"": """ + text + @""",
                        ""sound"":""default""
                          }
                                }";
                streamWriter.Write(strNJson);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
