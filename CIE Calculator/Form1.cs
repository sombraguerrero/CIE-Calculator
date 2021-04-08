using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;

namespace CIE_Calculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        { 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                HttpWebRequest lightRequest = WebRequest.CreateHttp($"http://{ConfigurationManager.AppSettings.Get("hueIP")}/api/{Environment.GetEnvironmentVariable("hueKey", EnvironmentVariableTarget.User)}/lights/{ConfigurationManager.AppSettings.Get("bulb")}/state");
                lightRequest.ContentType = "application/json;charset=utf-8";
                lightRequest.Method = "PUT";

                //Convert each color channel into a value between 0 and 1
                double selectedRed = colorDialog1.Color.R / 255.00;
                double selectedGreen = colorDialog1.Color.G / 255.00;
                double selectedBlue = colorDialog1.Color.B / 255.00;

                //Apply a gamma correction to each color channel value to account for difference of appearance on-screen versus from the actual light.
                double gammaRed = (selectedRed > 0.04045) ? Math.Pow((selectedRed + 0.055) / 1.055, 2.4) : (selectedRed / 12.92);
                double gammaGreen = (selectedGreen > 0.04045) ? Math.Pow((selectedGreen + 0.055) / 1.055, 2.4) : (selectedGreen / 12.92);
                double gammaBlue = (selectedBlue > 0.04045) ? Math.Pow((selectedBlue + 0.055) / 1.055, 2.4) : (selectedBlue / 12.92);

                //Use the gamma-corrected values to calculate the intermediate XYZ values.
                double X = gammaRed * 0.649926 + gammaGreen * 0.103455 + gammaBlue * 0.197109;
                double Brightness = gammaRed * 0.234327 + gammaGreen * 0.743075 + gammaBlue * 0.022598;
                double Z = gammaRed * 0.0000000 + gammaGreen * 0.053077 + gammaBlue * 1.035763;
           
                LightObject lightObject = new LightObject
                {
                    bri = (uint)(Brightness * 254),
                    on = true
                };
                lightObject.xy[0] = (X / (X + Brightness + Z));
                lightObject.xy[1] = (Brightness / (X + Brightness + Z));

                textBox1.Text = lightObject.xy[0].ToString();
                textBox2.Text = lightObject.xy[1].ToString();
                textBox3.Text = lightObject.bri.ToString();
                textBox4.Text = JsonConvert.SerializeObject(lightObject);

                using (StreamWriter streamWriter = new StreamWriter(lightRequest.GetRequestStream()))
                {
                    streamWriter.Write(textBox4.Text);
                }
                
                using (StreamReader streamReader = new StreamReader(lightRequest.GetResponse().GetResponseStream()))
                {
                    textBox4.Text += Environment.NewLine + Environment.NewLine + streamReader.ReadToEnd();
                }
            }
        }

        class LightObject
        {
            public uint bri { get;  set; }
            public double[] xy = new double[2];
            public bool on { get; set; }
        }
    }
}
